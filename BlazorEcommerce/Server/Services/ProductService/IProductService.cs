﻿using BlazorEcommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Server.Services.ProductService
{
  public interface IProductService
  {
    Task<ServiceResponse<List<Product>>> GetProductAsync();
    Task<ServiceResponse<Product>> GetProductAsync(int productId);
    Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
    Task<ServiceResponse<List<Product>>> SearchProducts(string searchText);
    Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
  }
}
