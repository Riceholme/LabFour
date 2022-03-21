using LabFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Services
{
    public interface IInterestRepository
    {
        IEnumerable<Interest> GetInterests();
        Interest GetInterest(int id);
        Interest AddInterest(Interest newInterest);
        void DeleteInterest(Interest interest);
        Interest Update(Interest interest);
    }
}
