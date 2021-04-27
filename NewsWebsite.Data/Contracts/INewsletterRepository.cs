using NewsWebsite.ViewModels.Newsletter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsite.Data.Contracts
{
    public interface INewsletterRepository
    {
      //Todo : Use Method Before Migaration To .NetCore 3
      //List<NewsletterViewModel> GetPaginateNewsletter(int offset, int limit, Func<NewsletterViewModel, Object> orderByAscFunc, Func<NewsletterViewModel, Object> orderByDescFunc, string searchText);
      Task<List<NewsletterViewModel>> GetPaginateNewsletterAsync(int offset, int limit, string orderBy, string searchText);
   }
}
