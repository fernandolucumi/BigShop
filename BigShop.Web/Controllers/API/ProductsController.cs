
namespace BigShop.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    [Route("api/[Controller]")]
    public class ProductsController: Controller
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(this.productRepository.GetAllWithUsers());
        }
    }
}
