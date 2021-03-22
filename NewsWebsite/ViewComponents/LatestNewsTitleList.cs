using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsWebsite.Data.Contracts;
using NewsWebsite.ViewModels.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsWebsite.ViewComponents
{
    public class LatestNewsTitleList :ViewComponent
    {
        private readonly IUnitOfWork _uw;
        public LatestNewsTitleList(IUnitOfWork uw)
        {
            _uw = uw;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var newsTitle =await _uw._Context.News.Where(n => n.IsPublish == true && n.PublishDateTime <= DateTime.Now).OrderByDescending(n => n.PublishDateTime).Select(n => new NewsViewModel
            {
                NewsId=n.NewsId,
                Title=n.Title,
                Url =n.Url



            }).Take(10).ToListAsync();

            return View(newsTitle);
        }
    }
}
