using NewsWebsite.ViewModels.Video;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsite.Data.Contracts
{
    public interface IVideoRepository
    {
        string CheckVideoFileName(string fileName);
        //Task<List<VideoViewModel>> GetPaginateVideosAsync(int offset, int limit, bool? titleSortAsc, bool? publishDateTimeSortAsc, string searchText);
        List<VideoViewModel> GetPaginateVideos(int offset, int limit, Func<VideoViewModel, object> orderByAcsFunc, Func<VideoViewModel, object> orderByDescFunc, string searchText);
    }
}
