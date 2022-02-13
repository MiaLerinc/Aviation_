using AviationWebAPI.DatabaseContext;
using DomainModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace AviationWebAPI.Repositories
{
    public class CountryRepository
    {
        
            private readonly AviationContext _aviationContext;
            public CountryRepository(AviationContext aviationContext)
            {
                _aviationContext = aviationContext;
            }
            public IEnumerable<Country> GetCountries()
            {
                return _aviationContext.Countries.ToList();
            }
        public void InsertCountry(Country country)
        {
            _aviationContext.Countries.Add(country);
            _aviationContext.SaveChanges();
        }
        public void UpdateCountry(Country country)
        {
            var countryForUpdate = GetCountry(country.Id);
            if (countryForUpdate != null)
            {
                countryForUpdate.Name = country.Name;               

                _aviationContext.SaveChanges();
            }
        }
        public Country GetCountry(int countryId)
        {
            return _aviationContext.Countries.FirstOrDefault(country => country.Id.Equals(countryId));
        }
        public void DeleteCountry(int countryId)
        {
            var countryForDelete = GetCountry(countryId);
            if (countryForDelete != null)
            {
                _aviationContext.Countries.Remove(countryForDelete);
                _aviationContext.SaveChanges();
            }
        }


    }
}
