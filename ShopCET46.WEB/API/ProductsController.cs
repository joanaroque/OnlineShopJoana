using Microsoft.AspNetCore.Mvc;
using ShopCET46.WEB.Data;

namespace ShopCET46.WEB.API
{
    [Route("api/controller")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(_productRepository.GetAll());
        }
    }
}
