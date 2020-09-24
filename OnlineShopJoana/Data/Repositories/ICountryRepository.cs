using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineShopJoana.WEB.Data.Entities;
using OnlineShopJoana.WEB.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopJoana.WEB.Data.Repositories
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
		//todos os paises e todas as cidades
		IQueryable GetCountriesWithCities();


		Task<Country> GetCountryWithCitiesAsync(int id);


		Task<City> GetCityAsync(int id);


		Task AddCityAsync(CityViewModel model);


		Task<int> UpdateCityAsync(City city);


		Task<int> DeleteCityAsync(City city);


		IEnumerable<SelectListItem> GetComboCountries();


		IEnumerable<SelectListItem> GetComboCities(int conuntryId);


		Task<Country> GetCountryAsync(City city);

	}
}
