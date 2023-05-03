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
        private readonly ILogger<JourneyController> _logger;

        public JourneyController(IJourneyManager journeyManager, ILogger<JourneyController> logger) 
        {
            _journeyManager = journeyManager;
            _logger = logger;
        }

        // GET: api/<JourneyController>
        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] JourneySearchDto journeyDto)
        {
            try {

                Response Response = await _journeyManager.Search(journeyDto);

                return Ok(Response);
            }
            catch (Exception e) 
            {
                _logger.LogInformation("Error - ");
                return null;
            }
           
        }

    }
}
