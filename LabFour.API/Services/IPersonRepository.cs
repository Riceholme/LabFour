using LabFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Services
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
        Person GetPerson(int id);
        Person AddPerson(Person newPerson);
        void DeletePerson(Person person);
        Person Update(Person person);
        IEnumerable<Person> GetPersonInterests();

    }
}
