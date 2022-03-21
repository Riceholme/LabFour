using LabFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Services
{
    public interface IWebSiteRepository
    {
        IEnumerable<WebSite> GetWebSites();

        WebSite GetWebSite(int id);
        WebSite AddWebSite(WebSite newWebSite);
        void DeleteWebSite(WebSite webSite);
        WebSite Update(WebSite webSite);
    }
}
