using BackPrueba.Infrastructure.Dtos;
using BackPrueba.Infrastructure.Managers.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JourneyController : ControllerBase
    {
        private readonly IJourneyManager _journeyManager;

        public JourneyController(IJourneyManager journeyManager) 
        {
            _journeyManager = journeyManager;
        }

        // GET: api/<JourneyController>
        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] JourneySearchDto journeyDto)
        {
            Response Response = await _journeyManager.Search(journeyDto);

            return Ok(Response);
        }

    }
}
