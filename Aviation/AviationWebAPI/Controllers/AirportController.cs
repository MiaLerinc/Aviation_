using AviationWebAPI.Repositories;
using DomainModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AviationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly AirportRepository _airportRepository;
        public AirportController(AirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }
        [HttpGet]
        public IActionResult GetAirports()
        {
            try
            {
                var airports = _airportRepository.GetAirports(false);
                return Ok(airports);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult AddFlight([FromBody] Airport airport)
        {
            if (airport == null)
                return BadRequest();
            try
            {
                _airportRepository.InsertAirport(airport);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        public IActionResult UpdateAirport([FromBody] Airport airport)
        {
            if (airport == null)
                return BadRequest();
            try
            {
                _airportRepository.UpdateAirport(airport);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{airportId:int}")]
        public IActionResult GetAirport(int airportId)
        {
            try
            {
                return Ok(_airportRepository.GetAirport(airportId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{airportId:int}")]
        public IActionResult DeleteAirport(int airportId)
        {
            try
            {
                _airportRepository.DeleteAirport(airportId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut("archiveAirport/{airportId:int}")]
        public IActionResult ArchiveAirport(int airportId)
        {
            try
            {
                _airportRepository.ArchiveAirport(airportId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("archivedAirports")]
        public IActionResult GetArchivedAirports()
        {
            try
            {
                return Ok(_airportRepository.GetAirports(true));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
