using LabFour.API.Services;
using LabFour.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        private IInterestRepository<Interest> _interestRepo;

        public InterestController(IInterestRepository<Interest> interestRepo)
        {
            _interestRepo = interestRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllInterests()
        {
            return Ok(await _interestRepo.GetAll());
        }

        [HttpGet]
        [Route("{id}/personinterest")]
        public async Task<ActionResult<Interest>> GetInterestOfPerson(int id)
        {
            try
            {
                var result = await _interestRepo.GetInterestsByPersonId(id);
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
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Interest>> GetInterest(int id)
        {
            try
            {
                var result = await _interestRepo.GetSingle(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, " Error to get Data from Database....");
            }

        }
        [HttpPost]
        public async Task<ActionResult<Interest>> AddNewInterest(Interest newInterest)
        {
            try
            {
                if (newInterest == null)
                {
                    return BadRequest("Interest was not added");
                }
                var createdInterest = await _interestRepo.Add(newInterest);
                return CreatedAtAction(nameof(GetInterest), new { id = createdInterest.InterestId }, createdInterest);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error To Add Interest");
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Interest>> UpdateInterest(int id, Interest interest)
        {
            try
            {
                if (id != interest.InterestId)
                {
                    return BadRequest("Interest with given ID was not found");
                }
                var interestToUpdate = await _interestRepo.GetSingle(id);
                if (interestToUpdate == null)
                {
                    return NotFound($"Interest withe ID: {id} was not found");
                }
                return await _interestRepo.Update(interest);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error To Update Interest");
            }
        }
    }
}
