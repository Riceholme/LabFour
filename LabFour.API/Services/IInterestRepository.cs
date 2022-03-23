using LabFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Services
{
    public interface IInterestRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        //Upgift 3
        Task<IEnumerable<T>> GetAllLinksByPersonId(int id);
        //Uppift 4
        Task<T> AddNewInterestWithPerson(T newEntity);
        Task<T> GetSingle(int id);
        Task<T> Add(T newEntity);
        Task<T> Update(T Entity);
        Task<T> Delete(int id);
    }
}
