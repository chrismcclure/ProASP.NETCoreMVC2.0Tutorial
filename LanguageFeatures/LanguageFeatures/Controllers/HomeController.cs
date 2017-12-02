using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
       
        public ViewResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {              
                string name = p?.Name  ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                //This causes a big fat null reference exception since one of the products is null in the array ¯\_(ツ)_/¯
                //bool instock = p.InStock;
                results.Add(string.Format($"Name: {name}, Price: {price}, Releated {relatedName}"));
            }

            return View(results);
          
        }
    }
}
