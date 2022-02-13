using AviationWebAPI.Repositories;
using DomainModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AviationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountryRepository _countryRepository;
        public CountryController(CountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        [HttpGet]
        public IActionResult GetCountries()
        {
            try
            {
                var countries = _countryRepository.GetCountries();
                return Ok(countries);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult AddCountry([FromBody] Country country)
        {
            if (country == null)
                return BadRequest();
            try
            {
                _countryRepository.InsertCountry(country);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        public IActionResult UpdateCountry([FromBody] Country country)
        {
            if (country == null)
                return BadRequest();
            try
            {
                _countryRepository.UpdateCountry(country);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{countryId:int}")]
        public IActionResult GetCountry(int countryId)
        {
            try
            {
                return Ok(_countryRepository.GetCountry(countryId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{countryId:int}")]
        public IActionResult Deletecountry(int countryId)
        {
            try
            {
                _countryRepository.DeleteCountry(countryId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
