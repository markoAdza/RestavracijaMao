using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using web.Models;
using web.Services;

namespace web.Views
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;

        public IEnumerable<Product> Products { get; set; }

        public IndexModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}