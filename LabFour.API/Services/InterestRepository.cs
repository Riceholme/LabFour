using LabFour.API.Model;
using LabFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Services
{
    public class InterestRepository : IInterestRepository<Interest>
    {
        private LabContext _interestContext;
        public InterestRepository(LabContext interestContext)
        {
            _interestContext = interestContext;
        }

        public Task<Interest> Add(Interest newInterest)
        {
            throw new NotImplementedException();
        }

        public Task<Interest> AddNewInterestWithPerson(Interest newInterest)
        {
            throw new NotImplementedException();
        }

        public Task<Interest> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Interest>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Interest>> GetAllLinksByPersonId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Interest> GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Interest> Update(Interest interest)
        {
            throw new NotImplementedException();
        }
    }
}
