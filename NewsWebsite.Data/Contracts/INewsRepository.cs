using NewsWebsite.ViewModels.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsite.Data.Contracts
{
    public interface INewsRepository
    {
        string CheckNewsFileName(string fileName);
        // Task<List<NewsViewModel>> GetPaginateNewsAsync(int offset, int limit, bool? titleSortAsc, bool? visitSortAsc, bool? likeSortAsc, bool? dislikeSortAsc, bool? publishDateTimeSortAsc, string searchText,bool? isPublish);
        List<NewsViewModel> GetPaginateNews(int offset, int limit, Func<IGrouping<string, NewsViewModel>, Object> orderByAscFunc, Func<IGrouping<string, NewsViewModel>, Object> orderByDesFunc, string searchText, bool? isPublish);
        Task<List<NewsViewModel>> MostViewedNews(int offset, int limit, string duration);
        Task<List<NewsViewModel>> MostPopularNews(int offset, int limit);
        Task<List<NewsViewModel>> MostTalkNews(int offset, int limit, string duration);
    }
}
