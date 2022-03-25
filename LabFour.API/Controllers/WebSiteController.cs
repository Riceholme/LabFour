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
    public class WebSiteController : ControllerBase
    {
        private IWebSiteRepository<WebSite> _webSiteRepo;

        public WebSiteController(IWebSiteRepository<WebSite> webSiteRepo)
        {
            _webSiteRepo = webSiteRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPersons()
        {
            return Ok(await _webSiteRepo.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Interest>> GetLinksByPersonId(int id)
        {
            try
            {
                var result = await _webSiteRepo.GetAllPersonsLinksBynId(id);
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound($"No Links were found of that persons id");

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get persons links");
            }
        }
    }
}
