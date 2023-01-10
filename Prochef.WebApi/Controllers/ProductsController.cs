using System;
using Microsoft.AspNetCore.Mvc;
using Prochef.Application.Interfaces;
using Prochef.Core.Dtos.Request.Products;

namespace Prochef.WebApi.Controllers
{

    public class ProductsController : Controller
    {

        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("products")]
        public IActionResult GetAllProducts()
        {
            return Json(_productService.GetAllProducts());
        }

        [HttpGet("productsByPlace")]
        public IActionResult GetProductsByPlace(string placeName)
        {
            return Json(_productService.GetProductsByPlace(placeName));
        }

        [HttpGet("productsByCategory")]
        public IActionResult GetProductsByCategory(string categoryName)
        {
            return Json(_productService.GetProductsByCategory(categoryName));
        }

        [HttpGet("productsByState")]
        public IActionResult GetAllProducts(string state)
        {
            return Json(_productService.GetProductsByState(state));
        }

        [HttpPost("products/add")]
        public IActionResult AddProduct(UpsertProductRequest productRequest)
        {
            try
            {
                _productService.AddProduct(productRequest);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("products/update")]
        public IActionResult UpdateProduct(UpsertProductRequest productRequest, int productId)
        {
            try
            {
                _productService.UpdateProduct(productRequest, productId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("products/delete")]
        public IActionResult DeleteProduct(int productId)
        {
            try
            {
                _productService.DeleteProduct(productId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
