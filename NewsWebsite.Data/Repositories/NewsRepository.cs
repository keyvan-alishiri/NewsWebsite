﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NewsWebsite.Common;
using NewsWebsite.Data.Contracts;
using NewsWebsite.Entities;
using NewsWebsite.ViewModels.News;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsite.Data.Repositories
{
    public class NewsRepository : INewsRepository
    {
        private readonly NewsDBContext _context;
        private readonly IMapper _mapper;
        public NewsRepository(NewsDBContext context, IMapper mapper)
        {
            _context = context;
            _context.CheckArgumentIsNull(nameof(_context));

            _mapper = mapper;
            _mapper.CheckArgumentIsNull(nameof(_mapper));
        }

        public int CountNewsPublished() => _context.News.Where(n => n.IsPublish == true && n.PublishDateTime <= DateTime.Now).Count();
        public List<NewsViewModel> GetPaginateNews(int offset, int limit, Func<IGrouping<string, NewsViewModel>, Object> orderByAscFunc, Func<IGrouping<string, NewsViewModel>, Object> orderByDescFunc, string searchText,bool? isPublish,bool? isInternal)
        {
            string NameOfCategories = "";
            string NameOfTags = "";
            List<NewsViewModel> newsViewModel = new List<NewsViewModel>();

            var newsGroup = (from n in _context.News.Include(v => v.Visits).Include(l => l.Likes).Include(u=>u.User).Include(c=>c.Comments)
                                   join e in _context.NewsCategories on n.NewsId equals e.NewsId into bc
                                   from bct in bc.DefaultIfEmpty()
                                   join c in _context.Categories on bct.CategoryId equals c.CategoryId into cg
                                   from cog in cg.DefaultIfEmpty()
                                   join a in _context.NewsTags on n.NewsId equals a.NewsId into ac
                                   from act in ac.DefaultIfEmpty()
                                   join t in _context.Tags on act.TagId equals t.TagId into tg
                                   from tog in tg.DefaultIfEmpty()
                                   where (n.Title.Contains(searchText) && isPublish==null?(n.IsPublish==true || n.IsPublish==false) : (isPublish==true?n.IsPublish==true && n.PublishDateTime<=DateTime.Now : n.IsPublish==false)  && isInternal == null ? n.IsInternal == true || n.IsInternal == false : (isInternal == true ? n.IsInternal == true : n.IsInternal == false))
                                   select (new NewsViewModel
                                   {
                                       NewsId= n.NewsId,
                                       Title= n.Title,
                                       Abstract= n.Abstract,
                                       ShortTitle = n.Title.Length > 50 ? n.Title.Substring(0, 50) + "..." : n.Title,
                                       Url= n.Url,
                                       ImageName= n.ImageName,
                                       Description= n.Description,
                                       NumberOfVisit = n.Visits.Select(v => v.NumberOfVisit).Sum(),
                                       NumberOfLike = n.Likes.Where(l => l.IsLiked == true).Count(),
                                       NumberOfDisLike = n.Likes.Where(l => l.IsLiked == false).Count(),
                                       NumberOfComments=n.Comments.Count(),
                                       NameOfCategories = cog != null ? cog.CategoryName : "",
                                       NameOfTags= tog!=null ? tog.TagName :"",
                                       AuthorName=n.User.FirstName+" "+ n.User.LastName,
                                       IsPublish= n.IsPublish,
                                       NewsType = n.IsInternal == true ? "داخلی" : "خارجی",
                                       PublishDateTime=n.PublishDateTime==null? new DateTime(01,01,01):n.PublishDateTime,
                                       PersianPublishDate = n.PublishDateTime==null?"-": n.PublishDateTime.ConvertMiladiToShamsi("yyyy/MM/dd ساعت HH:mm:ss"),
                                   })).GroupBy(b => b.NewsId).OrderBy(orderByAscFunc).OrderByDescending(orderByDescFunc).Select(g => new { NewsId = g.Key, NewsGroup = g }).Skip(offset).Take(limit).ToList();

            foreach (var item in newsGroup)
            {
                NameOfCategories = "";
                NameOfTags = "";
                foreach (var a in item.NewsGroup.Select(a => a.NameOfCategories).Distinct())
                {
                    if (NameOfCategories == "")
                        NameOfCategories = a;
                    else
                        NameOfCategories = NameOfCategories + " - " + a;
                }

                foreach (var a in item.NewsGroup.Select(a => a.NameOfTags).Distinct())
                {
                    if (NameOfTags == "")
                        NameOfTags = a;
                    else
                        NameOfTags = NameOfTags + " - " + a;
                }

                NewsViewModel news = new NewsViewModel()
                {
                    NewsId = item.NewsId,
                    Title = item.NewsGroup.First().Title,
                    ShortTitle = item.NewsGroup.First().ShortTitle,
                    Abstract = item.NewsGroup.First().Abstract,
                    Url = item.NewsGroup.First().Url,
                    Description = item.NewsGroup.First().Description,
                    NumberOfVisit = item.NewsGroup.First().NumberOfVisit,
                    NumberOfDisLike = item.NewsGroup.First().NumberOfDisLike,
                    NumberOfLike = item.NewsGroup.First().NumberOfLike,
                    PersianPublishDate = item.NewsGroup.First().PersianPublishDate,
                    NewsType = item.NewsGroup.First().NewsType,
                    Status = item.NewsGroup.First().IsPublish==false?"پیش نویس": (item.NewsGroup.First().PublishDateTime > DateTime.Now ? "انتشار در آینده" : "منتشر شده"),
                    NameOfCategories = NameOfCategories,
                    NameOfTags = NameOfTags,
                    ImageName= item.NewsGroup.First().ImageName,
                    AuthorName = item.NewsGroup.First().AuthorName,
                    NumberOfComments=item.NewsGroup.First().NumberOfComments,
                    PublishDateTime= item.NewsGroup.First().PublishDateTime,
                };
                newsViewModel.Add(news);
            }

            foreach (var item in newsViewModel)
                item.Row = ++offset;

            return newsViewModel;

        }

        public string CheckNewsFileName(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);
            int fileNameCount = _context.News.Where(f => f.ImageName == fileName).Count();
            int j = 1;
            while (fileNameCount != 0)
            {
                fileName = fileName.Replace(fileExtension, "") + j + fileExtension;
                fileNameCount = _context.Videos.Where(f => f.Poster == fileName).Count();
                j++;
            }

            return fileName;
        }

        public async Task<List<NewsViewModel>> MostViewedNews(int offset, int limit, string duration)
        {
            string NameOfCategories = "";
            List<NewsViewModel> newsViewModel = new List<NewsViewModel>();
            DateTime StartMiladiDate;
            DateTime EndMiladiDate = DateTime.Now;

            if (duration == "week")
            {
                int NumOfWeek = ConvertDateTime.ConvertMiladiToShamsi(DateTime.Now, "dddd").GetNumOfWeek();
                StartMiladiDate = DateTime.Now.AddDays((-1) * NumOfWeek).Date + new TimeSpan(0, 0, 0);
            }

            else if (duration == "day")
                StartMiladiDate = DateTime.Now.Date + new TimeSpan(0, 0, 0);

            else
            {
                string DayOfMonth = ConvertDateTime.ConvertMiladiToShamsi(DateTime.Now, "dd").Fa2En();
                StartMiladiDate = DateTime.Now.AddDays((-1) * (int.Parse(DayOfMonth) - 1)).Date + new TimeSpan(0, 0, 0);
            }

            var newsGroup = await (from n in _context.News.Include(v => v.Visits).Include(l => l.Likes).Include(c => c.Comments)
                                   join e in _context.NewsCategories on n.NewsId equals e.NewsId into bc
                                   from bct in bc.DefaultIfEmpty()
                                   join c in _context.Categories on bct.CategoryId equals c.CategoryId into cg
                                   from cog in cg.DefaultIfEmpty()
                                   where (n.PublishDateTime <= EndMiladiDate && StartMiladiDate <= n.PublishDateTime)
                                   select (new
                                   {
                                       n.NewsId,
                                       ShortTitle = n.Title.Length > 60 ? n.Title.Substring(0, 60) + "..." : n.Title,
                                       n.Url,
                                       NumberOfVisit = n.Visits.Select(v => v.NumberOfVisit).Sum(),
                                       NumberOfLike = n.Likes.Where(l => l.IsLiked == true).Count(),
                                       NumberOfDisLike = n.Likes.Where(l => l.IsLiked == false).Count(),
                                       NumberOfComments = n.Comments.Count(),
                                       n.ImageName,
                                       CategoryName = cog != null ? cog.CategoryName : "",
                                       PublishDateTime = n.PublishDateTime == null ? new DateTime(01, 01, 01) : n.PublishDateTime,
                                   })).GroupBy(b => b.NewsId).Select(g => new { NewsId = g.Key, NewsGroup = g }).OrderByDescending(g => g.NewsGroup.First().NumberOfVisit).Skip(offset).Take(limit).AsNoTracking().ToListAsync();

            foreach (var item in newsGroup)
            {
                NameOfCategories = "";
                foreach (var a in item.NewsGroup.Select(a => a.CategoryName).Distinct())
                {
                    if (NameOfCategories == "")
                        NameOfCategories = a;
                    else
                        NameOfCategories = NameOfCategories + " - " + a;
                }

                NewsViewModel news = new NewsViewModel()
                {
                    NewsId = item.NewsId,
                    ShortTitle = item.NewsGroup.First().ShortTitle,
                    Url = item.NewsGroup.First().Url,
                    NumberOfVisit = item.NewsGroup.First().NumberOfVisit,
                    NumberOfDisLike = item.NewsGroup.First().NumberOfDisLike,
                    NumberOfLike = item.NewsGroup.First().NumberOfLike,
                    NameOfCategories = NameOfCategories,
                    PublishDateTime = item.NewsGroup.First().PublishDateTime,
                    ImageName = item.NewsGroup.First().ImageName,
                };
                newsViewModel.Add(news);
            }

            return newsViewModel;
        }


        public async Task<List<NewsViewModel>> MostTalkNews(int offset, int limit, string duration)
        {
            DateTime StartMiladiDate;
            DateTime EndMiladiDate = DateTime.Now;

            if (duration == "week")
            {
                int NumOfWeek = ConvertDateTime.ConvertMiladiToShamsi(DateTime.Now, "dddd").GetNumOfWeek();
                StartMiladiDate = DateTime.Now.AddDays((-1) * NumOfWeek).Date + new TimeSpan(0, 0, 0);
            }

            else if (duration == "day")
                StartMiladiDate = DateTime.Now.Date + new TimeSpan(0, 0, 0);

            else
            {
                string DayOfMonth = ConvertDateTime.ConvertMiladiToShamsi(DateTime.Now, "dd").Fa2En();
                StartMiladiDate = DateTime.Now.AddDays((-1) * (int.Parse(DayOfMonth) - 1)).Date + new TimeSpan(0, 0, 0);
            }

            return await (from n in _context.News.Include(v => v.Visits).Include(l => l.Likes).Include(c => c.Comments)
                          where (n.PublishDateTime <= EndMiladiDate && StartMiladiDate <= n.PublishDateTime)
                          select (new NewsViewModel
                          {
                              NewsId = n.NewsId,
                              ShortTitle = n.Title.Length > 50 ? n.Title.Substring(0, 50) + "..." : n.Title,
                              Url = n.Url,
                              NumberOfVisit = n.Visits.Select(v => v.NumberOfVisit).Sum(),
                              NumberOfLike = n.Likes.Where(l => l.IsLiked == true).Count(),
                              NumberOfDisLike = n.Likes.Where(l => l.IsLiked == false).Count(),
                              NumberOfComments = n.Comments.Count(),
                              ImageName = n.ImageName,
                              PublishDateTime = n.PublishDateTime == null ? new DateTime(01, 01, 01) : n.PublishDateTime,
                          })).OrderByDescending(o => o.NumberOfComments).Skip(offset).Take(limit).AsNoTracking().ToListAsync();
        }

        public async Task<List<NewsViewModel>> MostPopularNews(int offset, int limit)
        {
            return await (from n in _context.News.Include(v => v.Visits).Include(l => l.Likes).Include(c => c.Comments)
                          where (n.IsPublish == true && n.PublishDateTime <= DateTime.Now)
                          select (new NewsViewModel
                          {
                              NewsId = n.NewsId,
                              ShortTitle = n.Title.Length > 50 ? n.Title.Substring(0, 50) + "..." : n.Title,
                              Url = n.Url,
                              Title = n.Title,
                              NumberOfVisit = n.Visits.Select(v => v.NumberOfVisit).Sum(),
                              NumberOfLike = n.Likes.Where(l => l.IsLiked == true).Count(),
                              NumberOfDisLike = n.Likes.Where(l => l.IsLiked == false).Count(),
                              NumberOfComments = n.Comments.Count(),
                              ImageName = n.ImageName,
                              PublishDateTime = n.PublishDateTime == null ? new DateTime(01, 01, 01) : n.PublishDateTime,
                          })).OrderByDescending(o => o.NumberOfLike).Skip(offset).Take(limit).AsNoTracking().ToListAsync();

        }

        public async Task<NewsViewModel> GetNewsById(string newsId)
        {
            string NameOfCategories = "";
            var newsGroup = await (from n in _context.News.Include(v => v.Visits).Include(l => l.Likes).Include(u => u.User).Include(c => c.Comments)
                                   join e in _context.NewsCategories on n.NewsId equals e.NewsId into bc
                                   from bct in bc.DefaultIfEmpty()
                                   join c in _context.Categories on bct.CategoryId equals c.CategoryId into cg
                                   from cog in cg.DefaultIfEmpty()
                                   join a in _context.NewsTags on n.NewsId equals a.NewsId into ac
                                   from act in ac.DefaultIfEmpty()
                                   join t in _context.Tags on act.TagId equals t.TagId into tg
                                   from tog in tg.DefaultIfEmpty()
                                   where (n.NewsId == newsId)
                                   select (new NewsViewModel
                                   {
                                       NewsId = n.NewsId,
                                       Title = n.Title,
                                       Abstract = n.Abstract,
                                       ShortTitle = n.Title.Length > 50 ? n.Title.Substring(0, 50) + "..." : n.Title,
                                       Url = n.Url,
                                       ImageName = n.ImageName,
                                       Description = n.Description,
                                       NumberOfVisit = n.Visits.Select(v => v.NumberOfVisit).Sum(),
                                       NumberOfLike = n.Likes.Where(l => l.IsLiked == true).Count(),
                                       NumberOfDisLike = n.Likes.Where(l => l.IsLiked == false).Count(),
                                       NumberOfComments = n.Comments.Where(c => c.IsConfirm == true).Count(),
                                       NameOfCategories = cog != null ? cog.CategoryName : "",
                                       NameOfTags = tog != null ? tog.TagName : "",
                                       IdOfTags = tog != null ? tog.TagId : "",
                                       AuthorInfo = n.User,
                                       IsPublish = n.IsPublish,
                                       NewsType = n.IsInternal == true ? "داخلی" : "خارجی",
                                       PublishDateTime = n.PublishDateTime == null ? new DateTime(01, 01, 01) : n.PublishDateTime,
                                       PersianPublishDate = n.PublishDateTime == null ? "-" : n.PublishDateTime.ConvertMiladiToShamsi("yyyy/MM/dd ساعت HH:mm:ss"),
                                   })).GroupBy(b => b.NewsId).Select(g => new { NewsId = g.Key, NewsGroup = g }).AsNoTracking().ToListAsync();


            foreach (var a in newsGroup.First().NewsGroup.Select(a => a.NameOfCategories).Distinct())
            {
                if (NameOfCategories == "")
                    NameOfCategories = a;
                else
                    NameOfCategories = NameOfCategories + " - " + a;
            }

            var news = new NewsViewModel()
            {
                NewsId = newsGroup.First().NewsGroup.First().NewsId,
                Title = newsGroup.First().NewsGroup.First().Title,
                ShortTitle = newsGroup.First().NewsGroup.First().ShortTitle,
                Abstract = newsGroup.First().NewsGroup.First().Abstract,
                Url = newsGroup.First().NewsGroup.First().Url,
                Description = newsGroup.First().NewsGroup.First().Description,
                NumberOfVisit = newsGroup.First().NewsGroup.First().NumberOfVisit,
                NumberOfDisLike = newsGroup.First().NewsGroup.First().NumberOfDisLike,
                NumberOfLike = newsGroup.First().NewsGroup.First().NumberOfLike,
                PersianPublishDate = newsGroup.First().NewsGroup.First().PersianPublishDate,
                NewsType = newsGroup.First().NewsGroup.First().NewsType,
                Status = newsGroup.First().NewsGroup.First().IsPublish == false ? "پیش نویس" : (newsGroup.First().NewsGroup.First().PublishDateTime > DateTime.Now ? "انتشار در آینده" : "منتشر شده"),
                NameOfCategories = NameOfCategories,
                TagNamesList = newsGroup.First().NewsGroup.Select(a => a.NameOfTags).Distinct().ToList(),
                TagIdsList = newsGroup.First().NewsGroup.Select(a => a.IdOfTags).Distinct().ToList(),
                ImageName = newsGroup.First().NewsGroup.First().ImageName,
                AuthorInfo = newsGroup.First().NewsGroup.First().AuthorInfo,
                NumberOfComments = newsGroup.First().NewsGroup.First().NumberOfComments,
                PublishDateTime = newsGroup.First().NewsGroup.First().PublishDateTime,
            };

            return news;
        }

        public async Task<List<NewsViewModel>> GetNextAndPreviousNews(DateTime? PublishDateTime)
        {
            var newsList = new List<NewsViewModel>();
            newsList.Add(await (from n in _context.News.Include(v => v.Visits).Include(l => l.Likes).Include(c => c.Comments)
                                where (n.IsPublish == true && n.PublishDateTime <= DateTime.Now && n.PublishDateTime < PublishDateTime)
                                select (new NewsViewModel
                                {
                                    NewsId = n.NewsId,
                                    ShortTitle = n.Title.Length > 50 ? n.Title.Substring(0, 50) + "..." : n.Title,
                                    Url = n.Url,
                                    Title = n.Title,
                                    NumberOfVisit = n.Visits.Select(v => v.NumberOfVisit).Sum(),
                                    NumberOfLike = n.Likes.Where(l => l.IsLiked == true).Count(),
                                    NumberOfDisLike = n.Likes.Where(l => l.IsLiked == false).Count(),
                                    NumberOfComments = n.Comments.Count(),
                                    ImageName = n.ImageName,
                                    PublishDateTime = n.PublishDateTime == null ? new DateTime(01, 01, 01) : n.PublishDateTime,
                                })).OrderByDescending(o => o.PublishDateTime).AsNoTracking().FirstOrDefaultAsync());

            newsList.Add(await (from n in _context.News.Include(v => v.Visits).Include(l => l.Likes).Include(c => c.Comments)
                                where (n.IsPublish == true && n.PublishDateTime <= DateTime.Now && n.PublishDateTime > PublishDateTime)
                                select (new NewsViewModel
                                {
                                    NewsId = n.NewsId,
                                    ShortTitle = n.Title.Length > 50 ? n.Title.Substring(0, 50) + "..." : n.Title,
                                    Url = n.Url,
                                    Title = n.Title,
                                    NumberOfVisit = n.Visits.Select(v => v.NumberOfVisit).Sum(),
                                    NumberOfLike = n.Likes.Where(l => l.IsLiked == true).Count(),
                                    NumberOfDisLike = n.Likes.Where(l => l.IsLiked == false).Count(),
                                    NumberOfComments = n.Comments.Count(),
                                    ImageName = n.ImageName,
                                    PublishDateTime = n.PublishDateTime == null ? new DateTime(01, 01, 01) : n.PublishDateTime,
                                })).OrderBy(o => o.PublishDateTime).AsNoTracking().FirstOrDefaultAsync());

            return newsList;
        }

        public async Task<List<Comment>> GetNewsCommentsAsync(string newsId)
        {
            var comments = await (from c in _context.Comments
                                  where (c.ParentCommentId == null && c.NewsId == newsId && c.IsConfirm == true)
                                  select new Comment { CommentId = c.CommentId, Desription = c.Desription, Email = c.Email, PostageDateTime = c.PostageDateTime, Name = c.Name ,IsConfirm=c.IsConfirm}).ToListAsync();
            foreach (var item in comments)
                await BindSubComments(item);

            return comments;
        }

        public async Task BindSubComments(Comment comment)
        {
            var subComments = await (from c in _context.Comments
                                     where (c.ParentCommentId == comment.CommentId && c.IsConfirm == true)
                                     select new Comment { CommentId = c.CommentId, Desription = c.Desription, Email = c.Email, PostageDateTime = c.PostageDateTime, Name = c.Name ,IsConfirm=c.IsConfirm }).ToListAsync();
          
                foreach (var item in subComments)
                {
                    await BindSubComments(item);
                    comment.comments.Add(item);
                }
            
            
        }

        public async Task<List<NewsViewModel>> GetRelatedNews(int number, List<string> tagIdList, string newsId)
        {
            var newsList = new List<NewsViewModel>();
            int randomRow;
            int newsCount = _context.News.Include(t => t.NewsTags).Where(n => n.IsPublish == true && n.PublishDateTime <= DateTime.Now && tagIdList.Any(y => n.NewsTags.Select(x => x.TagId).Contains(y)) && n.NewsId != newsId).Count();
            for (int i = 0; i < number && i < newsCount; i++)
            {
                randomRow = CustomMethods.RandomNumber(1, newsCount + 1);
                var news = await _context.News.Include(t => t.NewsTags).Include(c => c.Comments).Include(l => l.Likes).Include(l => l.Visits).Where(n => n.IsPublish == true && n.PublishDateTime <= DateTime.Now && tagIdList.Any(y => n.NewsTags.Select(x => x.TagId).Contains(y)) && n.NewsId != newsId)
                    .Select(n => new NewsViewModel
                    {
                        Title = n.Title,
                        Url = n.Url,
                        NewsId = n.NewsId,
                        ImageName = n.ImageName,
                        PublishDateTime = n.PublishDateTime,
                        NumberOfVisit = n.Visits.Select(v => v.NumberOfVisit).Sum(),
                        NumberOfLike = n.Likes.Where(l => l.IsLiked == true).Count(),
                        NumberOfDisLike = n.Likes.Where(l => l.IsLiked == false).Count(),
                        NumberOfComments = n.Comments.Count(),
                    })
                    .Skip(randomRow - 1).Take(1).FirstOrDefaultAsync();

                newsList.Add(news);
            }

            return newsList;
        }
    }
}
