using AviationWebAPI.DatabaseContext;
using DomainModel.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AviationWebAPI.Repositories
{
    public class AirportRepository
    {
        private readonly AviationContext _aviationContext;
        public AirportRepository(AviationContext aviationContext)
        {
            _aviationContext = aviationContext;
        }
        public IEnumerable<Airport> GetAirports()
        {
            return _aviationContext.Airports.OrderByDescending(p => p.Date).ToList();
        }
        public void InsertAirport(Airport airport)
        {
            _aviationContext.Airports.Add(airport);
            _aviationContext.SaveChanges();
        }
        public void UpdateAirport(Airport airport)
        {
            var airportForUpdate = GetAirport(airport.Id);
            if (airportForUpdate != null)
            {
                airportForUpdate.Name = airport.Name;
                airportForUpdate.Address = airport.Address;
                airportForUpdate.Date = airport.Date;
                airportForUpdate.CountryId =airport.CountryId;

                _aviationContext.SaveChanges();
            }
        }
        public Airport GetAirport(int airportId)
        {
            return _aviationContext.Airports.FirstOrDefault(airport => airport.Id.Equals(airportId));
        }
        public void DeleteAirport(int airportId)
        {
            var airportForDelete = GetAirport(airportId);
            if (airportForDelete != null)
            {
                _aviationContext.Airports.Remove(airportForDelete);
                _aviationContext.SaveChanges();
            }
        }
        public void ArchiveAirport(int airportId)
        {
            var airport = GetAirport(airportId);
            if (airport != null)
            {
                airport.IsArchived = true;
                _aviationContext.SaveChanges();
            }
        }
        public List<Airport> GetAirports(bool archived)
        {
            return _aviationContext.Airports.Include(airport => airport.Country).Where(airport => airport.IsArchived.Equals(archived)).ToList();
        }
    }
}
