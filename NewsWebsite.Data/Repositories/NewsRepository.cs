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


        public  List<NewsViewModel> GetPaginateNews(int offset, int limit, Func<IGrouping<string, NewsViewModel>, Object> orderByAscFunc, Func<IGrouping<string, NewsViewModel>, Object> orderByDesFunc, string searchText,bool? isPublish)
        {
            string NameOfCategories = "";
            string NameOfTags = "";
            List<NewsViewModel> newsViewModel = new List<NewsViewModel>();
          
           
            var newsGroup =  (from n in _context.News.Include(v => v.Visits).Include(l => l.Likes).Include(u=>u.User).Include(c=>c.Comments)
                                   join e in _context.NewsCategories on n.NewsId equals e.NewsId into bc
                                   from bct in bc.DefaultIfEmpty()
                                   join c in _context.Categories on bct.CategoryId equals c.CategoryId into cg
                                   from cog in cg.DefaultIfEmpty()
                                   join a in _context.NewsTags on n.NewsId equals a.NewsId into ac
                                   from act in ac.DefaultIfEmpty()
                                   join t in _context.Tags on act.TagId equals t.TagId into tg
                                   from tog in tg.DefaultIfEmpty()
                                   where (n.Title.Contains(searchText) && isPublish ==null?(n.IsPublish==true || n.IsPublish==false):(isPublish==true?n.IsPublish==true && n.PublishDateTime <= DateTime.Now : n.IsPublish==false))
                                   select (new NewsViewModel
                                   {
                                      NewsId= n.NewsId,
                                      Title= n.Title,
                                       ShortTitle = n.Title.Length > 50 ? n.Title.Substring(0, 50) + "..." : n.Title,
                                     Url=  n.Url,
                                     Abstract=  n.Abstract,
                                     ImageName=  n.ImageName,
                                     Description=  n.Description,
                                       NumberOfVisit = n.Visits.Select(v => v.NumberOfVisit).Sum(),
                                       NumberOfLike = n.Likes.Where(l => l.IsLiked == true).Count(),
                                       NumberOfDisLike = n.Likes.Where(l => l.IsLiked == false).Count(),
                                       NumberOfComments = n.Comments.Count(),
                                     NameOfCategories = cog != null ? cog.CategoryName : "",
                                       NameOfTags= tog!=null ? tog.TagName :"",
                                       AuthorName=n.User.FirstName+" "+ n.User.LastName,
                                     IsPublish=   n.IsPublish,
                                       NewsType = n.IsInternal == true ? "داخلی" : "خارجی",
                                       PublishDateTime=n.PublishDateTime==null? new DateTime(01,01,01):n.PublishDateTime,
                                       PersianPublishDate = n.PublishDateTime==null?"-": n.PublishDateTime.ConvertMiladiToShamsi("yyyy/MM/dd ساعت HH:mm:ss"),
                                   })).GroupBy(b => b.NewsId).OrderBy(orderByAscFunc).OrderByDescending(orderByDesFunc).Select(g => new { NewsId = g.Key, NewsGroup = g }).Skip(offset).Take(limit).ToList();

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
                    ImageName = item.NewsGroup.First().ImageName,
                    Description = item.NewsGroup.First().Description,
                    NumberOfVisit = item.NewsGroup.First().NumberOfVisit,
                    NumberOfDisLike = item.NewsGroup.First().NumberOfDisLike,
                    NumberOfLike = item.NewsGroup.First().NumberOfLike,
                    PersianPublishDate = item.NewsGroup.First().PersianPublishDate,
                    NewsType = item.NewsGroup.First().NewsType,
                    Status = item.NewsGroup.First().IsPublish==false?"پیش نویس": (item.NewsGroup.First().PublishDateTime > DateTime.Now ? "انتشار در آینده" : "منتشر شده"),
                    NameOfCategories = NameOfCategories,
                    NameOfTags = NameOfTags,
                    AuthorName = item.NewsGroup.First().AuthorName,
                    NumberOfComments = item.NewsGroup.First().NumberOfComments,
                    PublishDateTime=item.NewsGroup.First().PublishDateTime
                };
                newsViewModel.Add(news);
            }

           

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
    }
}
