using NewsWebsite.ViewModels.News;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsWebsite.ViewModels.Home
{
   public class HomePageViewModel
    {
        public List<NewsViewModel> News { get; set; }
        public HomePageViewModel(List<NewsViewModel> news)
        {
            News = news;
        }
    }
}
