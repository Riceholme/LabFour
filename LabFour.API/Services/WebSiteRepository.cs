using LabFour.API.Model;
using LabFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Services
{
    public class WebSiteRepository : IWebSiteRepository<WebSite>
    {
        private LabContext _websiteContext;
        public WebSiteRepository(LabContext websiteContext)
        {
            _websiteContext = websiteContext;
        }
       
        public Task<WebSite> Add(WebSite newEntity)
        {
            throw new NotImplementedException();
        }

        public Task<WebSite> AddNewWebsiteWithIdRelations(WebSite newEntity)
        {
            throw new NotImplementedException();
        }

        public Task<WebSite> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WebSite>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<WebSite> GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WebSite> Update(WebSite Entity)
        {
            throw new NotImplementedException();
        }
    }
}
