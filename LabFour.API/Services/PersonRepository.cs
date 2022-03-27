using LabFour.API.Model;
using LabFour.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Services
{
    public class PersonRepository : IPersonRepository<Person>
    {
        private LabContext _personContext;
        public PersonRepository(LabContext personContext)
        {
            _personContext = personContext;
        }

        public async Task<Person> Add(Person newPerson)
        {
            var result = await _personContext.Persons
                .AddAsync(newPerson);
            await _personContext
                .SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Person> Delete(int id)
        {
            var result = await _personContext.Persons
                .FirstOrDefaultAsync(p => p.PersonId == id);
            if (result != null)
            {
                _personContext.Persons
                    .Remove(result);
                await _personContext
                    .SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _personContext.Persons
                .ToListAsync();
        }

        public async Task<IEnumerable<Person>> GetPersonsInterests(int id)
        {
            return await _personContext.Persons
                .Include(p => p.Interests)
                .Where(p => p.PersonId == id)
                .ToListAsync();
        }

        public async Task<Person> GetSingle(int id)
        {
            return await _personContext.Persons
                .FirstOrDefaultAsync(p => p.PersonId == id);
        }

        public async Task<Person> Update(Person person)
        {
            var result = await _personContext.Persons
                .FirstOrDefaultAsync(p => p.PersonId == person.PersonId);
            if (result != null)
            {
                result.Name = person.Name;
                result.PhoneNumber = person.PhoneNumber;
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Person>> GetPersonsLinks(int id)
        {
            var links = await _personContext.Persons
                .Include(person => person.Interests)
                .ThenInclude(interest => interest.WebSites)
                .Where(p => p.PersonId == id)
                .ToListAsync();
            return links;
        }
        //public async Task<IEnumerable<string>> GetPersonsLinks2(int id)
        //{

        //    var links = await _personContext.Persons
        //        .Where(p => p.PersonId == id)
        //        .FirstOrDefault()
        //        .Interests.Select(x => x.Title);
        //        //.Include(person => person.Interests)
        //        //.ThenInclude(interest => interest.WebSites)

        //    return links;
        //}
    }
}
