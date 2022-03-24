using Microsoft.AspNetCore.Http;
using LabFour.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabFour.Models;

namespace LabFour.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonRepository<Person> _personRepository;
        public PersonController(IPersonRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPersons()
        {
            return Ok(await _personRepository.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetInterestOfPerson(int id)
        {
            try
            {
                if (id != null)
                {
                    return BadRequest("Id was not found");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
