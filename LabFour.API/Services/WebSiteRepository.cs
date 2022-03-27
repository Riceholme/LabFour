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

        public async Task<WebSite> Add(WebSite newWebSite)
        {
            var result = await _websiteContext.WebSites.AddAsync(newWebSite);
            await _websiteContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<WebSite> AddWebsiteForPerson(WebSite newWebSite)
        {
            var result = await _websiteContext.WebSites
                .AddAsync(newWebSite);
            await _websiteContext
                .SaveChangesAsync();
            return result.Entity;
            //Add Foreign Key "PersonId" with reference "Person Person"
        }

        public async Task<WebSite> Delete(int id)
        {
            var result = await _websiteContext.WebSites.FirstOrDefaultAsync(p => p.WebSiteId == id);
            if (result != null)
            {
                _websiteContext.WebSites
                    .Remove(result);
                await _websiteContext
                    .SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<WebSite>> GetAll()
        {
            return await _websiteContext.WebSites.Include(w => w.Interest).ToListAsync();
        }

        public async Task<IEnumerable<WebSite>> GetAllPersonsLinksBynId(int id)
        {
            return await _websiteContext.WebSites
                .Include(w => w.Interest)
                .ThenInclude(w => w.PersonId)
                .Include(x => x.InterestId == x.WebSiteId)
                .ToListAsync();
            //return await _websiteContext.WebSites.Include(w => w.Interest).ThenInclude(x => x.Person).Where(w => w.InterestId == w.WebSiteId)
        }

        //public async Task<WebSite> GetSingle(int id)
        //{
        //    return await _websiteContext.WebSites.Include(w => w.Interest).FirstOrDefaultAsync(w => w.WebSiteId == id);
        //}
        public async Task<WebSite> GetSingle(int id)
        {
            return await _websiteContext.WebSites.Include(w => w.Interest).FirstOrDefaultAsync(w => w.WebSiteId == id);
        }

        public async Task<WebSite> Update(WebSite webSite)
        {
            var result = await _websiteContext.WebSites.FirstOrDefaultAsync(p => p.WebSiteId == webSite.WebSiteId);
            if (result != null)
            {
                result.Link = webSite.Link;
                result.Description = webSite.Description;
                result.InterestId = webSite.InterestId;

                return result;
            }
            return null;
        }
    }
}
