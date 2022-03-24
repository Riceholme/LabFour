using LabFour.API.Model;
using LabFour.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<WebSite>> GetAll()
        {
            return await _websiteContext.WebSites.Include(w => w.Interest).ToListAsync();
        }

        public async Task<IEnumerable<WebSite>> GetAllPersonsLinksBynId(int id)
        {
            return await _websiteContext.WebSites.Include(w => w.Interest).ThenInclude(w => w.PersonId).Include(x => x.InterestId == x.WebSiteId).ToListAsync();
            //return await _websiteContext.WebSites.Include(w => w.Interest).ThenInclude(x => x.Person).Where(w => w.InterestId == w.WebSiteId)
        }

        public async Task<WebSite> GetSingle(int id)
        {
            return await _websiteContext.WebSites.Include(w => w.Interest).FirstOrDefaultAsync(w => w.WebSiteId == id);
        }

        public Task<WebSite> Update(WebSite Entity)
        {
            throw new NotImplementedException();
        }
    }
}
