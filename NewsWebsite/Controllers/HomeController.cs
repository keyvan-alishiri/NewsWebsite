﻿using System;
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
        public async Task<IActionResult> Index()
        {
            var news = await _uw.NewsRepository.GetPaginateNewsAsync(0, 10, null, null, null, null, false, "", true);
            var homePageViewModel = new HomePageViewModel(news);
            return View(homePageViewModel);
        }
    }
}