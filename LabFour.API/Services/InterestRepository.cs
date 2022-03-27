using LabFour.API.Model;
using LabFour.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Interest> Add(Interest newInterest)
        {
            var result = await _interestContext.Interests.AddAsync(newInterest);
            await _interestContext.SaveChangesAsync();
            return result.Entity;
        }

        public Task<Interest> AddNewInterestWithPerson(Interest newInterest)
        {
            throw new NotImplementedException();
        }

        public async Task<Interest> Delete(int id)
        {
            var result = await _interestContext.Interests.FirstOrDefaultAsync(p => p.PersonId == id);
            if (result != null)
            {
                _interestContext.Interests.Remove(result);
                await _interestContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Interest>> GetAll()
        {
            return await _interestContext.Interests.Include(i => i.Person).ToListAsync();
        }
        //GET ALL INTERESTS WITH AN ID OF PERSON.
        public async Task<IEnumerable<Interest>> GetInterestsByPersonId(int id)
        {
            return await _interestContext.Interests
                .Include(i => i.Person)
                .Where(i => i.PersonId == id && i.PersonId == i.Person.PersonId).ToListAsync();
        }

        public Task<IEnumerable<Interest>> GetAllLinksByPersonId(int id)
        {
            throw new NotImplementedException();
            //Method for this exists in WebSite's repos and controller
        }

        public async Task<Interest> GetSingle(int id)
        {
            return await _interestContext.Interests.Include(i => i.Person).FirstOrDefaultAsync(p => p.InterestId == id);
        }

        public async Task<Interest> Update(Interest interest)
        {
            var result = await _interestContext.Interests
                .FirstOrDefaultAsync(p => p.InterestId == interest.InterestId);
            if (result != null)
            {
                result.Title = interest.Title;
                result.Description = interest.Description;
                //result.PersonId = interest.PersonId;
                result.Person.Name = interest.Person.Name;
                result.Person.PhoneNumber = interest.Person.PhoneNumber;
                return result;
            }
            return null;
        }
    }
}
