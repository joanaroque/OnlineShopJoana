using OnlineShopJoana.WEB.Data.Entities;
using OnlineShopJoana.WEB.Models;

namespace OnlineShopJoana.WEB.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, string Path, bool isNew);

        ProductViewModel ToProductViewModel(Product model);
    }
}
