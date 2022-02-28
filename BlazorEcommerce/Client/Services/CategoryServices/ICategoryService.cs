using BlazorEcommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Client.Services.CategoryServices
{
  public interface ICategoryService
  {
    List<Category> Categories { get; set; }
    Task GetCategories();
  }
}
