using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>() { 
        
            new Product()
            { 
                id=1,ProductName="Televizyon",CategoryName="Elektronik"

            },
            new Product()
            {
                id=2,ProductName="Telefon",CategoryName="Elektronik"

            },
            new Product()
            {
                id=3,ProductName="Buzdolabı",CategoryName="Beyaz eşya"

            },
            new Product()
            {
                id=4,ProductName="Fırın", CategoryName="Beyaz eşya"

            }


        };
        public IActionResult GetAllProducts()
        {
            return View(products);
        }

        public IActionResult GetProductById(int id)
        {
            Product product = products.Find(x => x.id == id);

            if (product==null)
            {
                ViewBag.Error = "Verilen id ile bir ürün bulunamadı.";

            }
           

            return View(product);

        }
        
        public IActionResult GetProductByCategoryName(string categoryname)
        {
            List<Product> p  = products.FindAll( w => w.CategoryName == categoryname);
            // products.Where(w => w.CategoryName == categoryname);

            if (p == null)
            {
                ViewData["Error"] = "Verilen categori ismi ile ilgili bir ürün bulunamadı.";
            }
            return View(p);
        }
    }
}
