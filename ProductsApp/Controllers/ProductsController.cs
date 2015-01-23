using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;


namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]{
        
            new Product{id=1, name="Domates Çorbası" , category="Çorbalar" , price=12},
            new Product{id=2, name="Yo-Yo" , category="Oyuncaklar" , price=123},
            new Product{id=3, name="HDD" , category="Donanım" , price=1234},
            new Product{id=4, name="Toplantı Masası" , category="Mobilyalar" , price=12345},

        };



        public IEnumerable<Product> getAllProducts() {
            return products;
        }


        public IHttpActionResult getProduct(int id) {
            var product = products.FirstOrDefault(p => p.id == id);
            return Ok(product);
        }

    }
}
