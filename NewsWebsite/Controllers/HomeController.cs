using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsWebsite.Data.Contracts;
using NewsWebsite.ViewModels.Home;

namespace NewsWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _uw;
        public HomeController(IUnitOfWork uw)
        {
            _uw = uw;
        }
        public async Task<IActionResult> Index(string duration, string TypeOfNews)
        {
            var isAjax = Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            if (isAjax && TypeOfNews == "MostViewedNews")
                return PartialView("_MostViewedNews", await _uw.NewsRepository.MostViewedNews(0, 3, duration));

            else
            {
                var news = _uw.NewsRepository.GetPaginateNews(0, 10, item => "", item => item.First().PersianPublishDate, "", true);
                var mostViewedNews = await _uw.NewsRepository.MostViewedNews(0, 3, "day");
                var homePageViewModel = new HomePageViewModel(news, mostViewedNews);
                return View(homePageViewModel);
            }

        }
    }
}