using ShopCET46.WEB.Data.Entities;
using ShopCET46.WEB.Models;

namespace ShopCET46.WEB.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, string Path, bool isNew);

        ProductViewModel ToProductViewModel(Product model);
    }
}
