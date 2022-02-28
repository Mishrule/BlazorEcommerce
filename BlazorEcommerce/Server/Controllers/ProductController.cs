using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Server.Services.ProductService;
using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController : ControllerBase
  {
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
      _productService = productService;
    }
    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
    {
      var result = await _productService.GetProductAsync();
      return Ok(result);
    }

    [HttpGet("{productId}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct(int productId)
    {
      var result = await _productService.GetProductAsync(productId);
      return Ok(result);
    }
    [HttpGet("category/{categoryUrl}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategory(string categoryUrl)
    {
      var result = await _productService.GetProductsByCategory(categoryUrl);
      return Ok(result);
    }

    [HttpGet("search/{searchText}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> SearchProduct(string searchText)
    {
      var result = await _productService.SearchProducts(searchText);
      return Ok(result);
    }

    [HttpGet("searchSuggestions/{searchText}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductSearchSuggestions(string searchText)
    {
      var result = await _productService.SearchProducts(searchText);
      return Ok(result);
    }
  }
}
