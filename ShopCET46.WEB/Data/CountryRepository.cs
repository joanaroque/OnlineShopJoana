using ShopCET46.WEB.Data.Entities;

namespace ShopCET46.WEB.Data
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {

        public CountryRepository(DataContext context) : base(context)
        {

        }
    }
}
