using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraThaoMoc.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController{
        [HttpGet("products")]
        public List<Product> GetProduct([FromQuery]int numberOfProduct, [FromQuery] string searchBy)
        {
            var products = new List<Product>
            { 
                new Product { Id = 1, Name = "Bot Gung", Description = "San pham chong viem"},
                new Product { Id = 1, Name = "Dau gio", Description = "Chua tinh dau bac ha"},
                new Product { Id = 1, Name = "La xong", Description = "Khong hoa chat"},
                new Product { Id = 1, Name = "Gao nep", Description = "Khong hoa chat"}
            };

            if(!string.IsNullOrEmpty(searchBy)){
                products = products.Where(s => s.Name.ToLower().Contains(searchBy)).ToList();
            }
            
            return products.Take(numberOfProduct).ToList();
        }
    }
}