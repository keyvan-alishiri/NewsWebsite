﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsWebsite.Data.Contracts;
using NewsWebsite.Entities;
using NewsWebsite.ViewModels.Home;

namespace NewsWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IHttpContextAccessor _accessor;
        public HomeController(IUnitOfWork uw, IHttpContextAccessor accessor)
        {
            _uw = uw;
            _accessor = accessor;
        }

        public async Task<IActionResult> Index(string duration,string TypeOfNews)
        {
            var isAjax = Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            if (isAjax && TypeOfNews == "MostViewedNews")
                return PartialView("_MostViewedNews", await _uw.NewsRepository.MostViewedNews(0, 3, duration));


            else if (isAjax && TypeOfNews == "MostTalkNews")
                return PartialView("_MostTalkNews", await _uw.NewsRepository.MostTalkNews(0, 5, duration));

            else
            {
                var news = _uw.NewsRepository.GetPaginateNews(0, 10, item => "", item => item.First().PersianPublishDate, "", true , null);
                var mostViewedNews = await _uw.NewsRepository.MostViewedNews(0, 3, "day");
                var mostTalkNews = await _uw.NewsRepository.MostTalkNews(0, 5, "day");
                var mostPopulerNews = await _uw.NewsRepository.MostPopularNews(0, 5);
                var internalNews = _uw.NewsRepository.GetPaginateNews(0, 10, item => "", item => item.First().PersianPublishDate, "", true, true);
                var foreignNews = _uw.NewsRepository.GetPaginateNews(0, 10, item => "", item => item.First().PersianPublishDate, "", true, false);
                var videos = await _uw.VideoRepository.GetPaginateVideosAsync(0, 10, null, false, "");
                var homePageViewModel = new HomePageViewModel(news, mostViewedNews,mostTalkNews,mostPopulerNews,internalNews,foreignNews, videos);
                return View(homePageViewModel);
            }
           
        }

        [Route("News/{newsId}/{url}")]
        public async Task<IActionResult> NewsDetails(string newsId, string url)
        {
            string ipAddress = _accessor.HttpContext?.Connection?.RemoteIpAddress.ToString();
            Visit visit = _uw.BaseRepository<Visit>().FindByConditionAsync(n => n.NewsId == newsId && n.IpAddress == ipAddress).Result.FirstOrDefault();
            if (visit != null && visit.LastVisitDateTime.Date != DateTime.Now.Date)
            {
                visit.NumberOfVisit = visit.NumberOfVisit + 1;
                visit.LastVisitDateTime = DateTime.Now;
                await _uw.Commit();
            }
            else if (visit == null)
            {
                visit = new Visit { IpAddress = ipAddress, LastVisitDateTime = DateTime.Now, NewsId = newsId, NumberOfVisit = 1 };
                await _uw.BaseRepository<Visit>().CreateAsync(visit);
                await _uw.Commit();
            }

            var news = await _uw.NewsRepository.GetNewsById(newsId);
            var newsComments = await _uw.NewsRepository.GetNewsCommentsAsync(newsId);
            var nextAndPreviousNews = await _uw.NewsRepository.GetNextAndPreviousNews(news.PublishDateTime);
            var newsRelated = await _uw.NewsRepository.GetRelatedNews(2, news.TagIdsList, newsId);
            var newsDetailsViewModel = new NewsDetailsViewModel(news, newsComments, newsRelated, nextAndPreviousNews);
            return View(newsDetailsViewModel);
        }
    }
}