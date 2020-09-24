using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShopJoana.WEB.Data.Repositories;

namespace OnlineShopJoana.WEB.API
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] // para entrar na api é preciso ter um token deste tipo
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
            return Ok(_productRepository.GetAllWithUsers());
        }
    }
}
