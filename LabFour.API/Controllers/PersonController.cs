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
        public async Task<ActionResult<Person>> GetInterestOfPerson(int id, Person person)
        {
            try
            {
                var result = await _personRepository.GetPersonsInterests(id, person);
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound($"No interests were found of that person");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get persons interests");
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPersonsLinks(int id)
        {
            try
            {
                var result = await _personRepository.GetPersonsLinks(id);
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound($"No links were found, ID was not found");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get persons links");
            }
        }
    }
}
