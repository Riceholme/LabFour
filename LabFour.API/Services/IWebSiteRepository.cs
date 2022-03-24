using LabFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Services
{
    public interface IWebSiteRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        //Uppgift 5
        Task<T> AddNewWebsiteWithIdRelations(T newEntity);
        //Uppgift 3
        Task<IEnumerable<T>> GetAllPersonsLinksBynId(int id);
        Task<T> GetSingle(int id);
        Task<T> Add(T newEntity);
        Task<T> Update(T Entity);
        Task<T> Delete(int id);
    }
}
