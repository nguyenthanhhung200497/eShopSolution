using eShopSolution.Application;
using eShopSolution.Application.Catalog.Products;
using eShopSolution.ViewModel.Catalog.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        //product

        //GetAll thường không dùng.
        //http://localhost:port/product
        //[HttpGet("{languageId}")]
        //public async Task<IActionResult> GetAll(string languageId)
        //{
        //    var products = await _publicProductService.GetAll(languageId);
        //    return Ok(products);
        //}

        //http://localhost:port/products/1/1
        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var product = await _productService.GetById(productId, languageId);
            if (product == null)
            {
                return BadRequest("Cannot find product");
            }
            return Ok(product);
        }

        //http://localhost:port/product?pageIndex=1&pageSize=10&CategoryId=1
        [HttpGet("{languageId}")]
        public async Task<IActionResult> GetAllPaging(string languageId, [FromQuery] GetPublicProductPagingRequest request)
        {
            var products = await _productService.GetAllByCatagoryId(languageId, request);
            return Ok(products);
        }

        //http://localhost:port/product/
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _productService.Create(request);
            if (productId == 0)
                return BadRequest("Cannot create product");
            var product = await _productService.GetById(productId, request.LanguageId);

            return CreatedAtAction(nameof(GetImageById), new { id = productId }, product);
        }

        //http://localhost:port/product/1
        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var product = await _productService.Delete(productId);
            if (product == 0)
                return BadRequest();
            return Ok();
        }

        //http://localhost:port/product/update-product
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedResult = await _productService.Update(request);
            if (affectedResult == 0)
                return BadRequest();

            return Ok();
        }

        //http://localhost:port/product/price/1
        //Update 1 phần của sản phẩm thì ta dùng lệnh [HttpPatch]
        [HttpPatch("price/{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var isSuccessful = await _productService.UpdatePrice(productId, newPrice);
            if (isSuccessful == false)
                return BadRequest();

            return Ok();
        }

        [HttpPatch("stock/{productId}")]
        public async Task<IActionResult> UpdateStock(int productId, int addQuatity)
        {
            var isSuccessful = await _productService.UpdateStock(productId, addQuatity);
            if (isSuccessful == false)
                return BadRequest();

            return Ok();
        }

        //image

        [HttpPost("{productId}/images")]
        public async Task<IActionResult> Create(int productId, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _productService.AddImage(productId, request);

            if (imageId == 0)
                return BadRequest("Cannot create product");

            var image = await _productService.GetImageById(imageId);

            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.UpdateImage(imageId, request);
            if (result == 0)
                return BadRequest();

            return Ok();
        }

        //http://localhost:port/1/vi
        [HttpGet("{productId}/image/{languageId}")]
        public async Task<IActionResult> GetImageById(int productId, string languageId)
        {
            var image = await _productService.GetById(productId, languageId);
            if (image == null)
                return BadRequest("Cannot find product");
            return Ok(image);
        }

        [HttpGet("images/{imageId}")]
        public async Task<IActionResult> GetListImage(int imageId)
        {
            var images = await _productService.GetListImage(imageId);
            return Ok(images);
        }
    }
}