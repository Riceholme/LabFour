using LabFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Services
{
    public interface IPersonRepository<T>
    {
        //Uppgift 1
        Task<IEnumerable<T>> GetAll();
        //Upgift 2
        Task<IEnumerable<T>> GetAllPersonsInterests(int id);
        Task<T> GetSingle(int id);
        Task<T> Add(T newEntity);
        Task<T> Update(T Entity);
        Task<T> Delete(int id);
    }
}
