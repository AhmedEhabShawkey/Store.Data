using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Data.Model;
using Store.Services.Services.Interface;

namespace Store.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<BrandTypeDetails>>> GetAllBrand()
            =>Ok(await _productService .GetAllBrandAsync());
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductDetails>>> GetALLTypes()
            => Ok(await _productService.GetAllTypesAsync());

        public async Task<ActionResult<IReadOnlyList<ProductDetails>>> GetALLProductsByid(int? id)
            => Ok(await _productService.GetAllProductByIdAsync(id));
    }
}
