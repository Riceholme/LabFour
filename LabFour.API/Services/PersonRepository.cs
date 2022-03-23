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

        public Task<Person> Add(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public Task<Person> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> GetAllPersonsInterests(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
