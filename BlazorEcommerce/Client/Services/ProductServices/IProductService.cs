﻿using BlazorEcommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Client.Services.ProductServices
{
 public interface IProductService
  {
    event Action ProductsChanged;
    List<Product> Products { get; set; }
    string Message { get; set; }
    Task GetProducts(string categoryUrl = null);
    Task<ServiceResponse<Product>> GetProductAsync(int productId);
    Task SearchProducts(string searchText);
    Task<List<string>> GetProductSearchSuggestions(string searchText);
  }
}
