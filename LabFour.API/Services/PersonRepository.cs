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
            var result = await _personContext.Persons.AddAsync(newPerson);
            await _personContext.SaveChangesAsync();
            return result.Entity;
        }

        public Task<Person> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _personContext.Persons.ToListAsync();
        }

        public Task<IEnumerable<Person>> GetPersonsInterests(int id, Person person)
        {
            throw new NotImplementedException();
            //return await _personContext.Persons.Include(i => i.Interests).Where(i => i.Interests == i.PersonId).ToListAsync();
        }

        public async Task<Person> GetSingle(int id)
        {
            return await _personContext.Persons.FirstOrDefaultAsync(p => p.PersonId == id);
        }

        public async Task<Person> Update(Person person)
        {
            var result = await _personContext.Persons.FirstOrDefaultAsync(p => p.PersonId == person.PersonId);
            if (result != null)
            {
                result.Name = person.Name;
                result.PhoneNumber = person.PhoneNumber;
                return result;
            }
            return null;
        }
    }
}
