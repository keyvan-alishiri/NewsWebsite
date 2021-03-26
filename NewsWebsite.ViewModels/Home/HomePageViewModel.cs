using NewsWebsite.ViewModels.News;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsWebsite.ViewModels.Home
{
   public class HomePageViewModel
    {
        public List<NewsViewModel> News { get; set; }
        public List<NewsViewModel> MostViewedNews { get; set; }
        public HomePageViewModel(List<NewsViewModel> news, List<NewsViewModel> mostViewedNews)

        {
            MostViewedNews = mostViewedNews;
            News = news;
        }

        
    }
}
