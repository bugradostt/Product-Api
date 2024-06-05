using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Business.Interfaces;
using Product.DataAccess.Dtos.Product;

namespace Product.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : CustomBaseController
    {
        readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("get-product")]
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            var result = await _productService.GetProductAsync();
            return ActionResultInstance(result);
        }

        [Route("get-by-product-id")]
        [HttpPost]
        public async Task<IActionResult> GetByProductId(RequestProductIdDto request)
        {
            var result = await _productService.GetByProductIdAsync(request.ProductStatusId);
            return ActionResultInstance(result);
        }

        [Route("add-product")]
        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductDto product)
        {
            var result = await _productService.AddProductAsync(product);
            return ActionResultInstance(result);
        }


        [Route("update-product")]
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto product)
        {
            var result = await _productService.UpdateProductAsync(product);
            return ActionResultInstance(result);
        }

        [Route("delete-product")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(RequestProductIdDto request)
        {
            var result = await _productService.DeleteProductAsync(request.ProductStatusId);
            return ActionResultInstance(result);
        }

    }
}
