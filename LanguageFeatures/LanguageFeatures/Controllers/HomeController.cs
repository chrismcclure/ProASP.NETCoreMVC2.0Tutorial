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
       

        //Practice with async
        public async Task<ViewResult> Index()
        {
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length: {length}" });
        }



        //public ViewResult Index()
        //{
        //    List<string> results = new List<string>();

        //    foreach (Product p in Product.GetProducts())
        //    {

        //        ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

        //        //This is the sweet spot, here is the use of extension method. 
        //        decimal cartTotal = cart.TotalPrices();



        //        string name = p?.Name  ?? "<No Name>";
        //        decimal? price = p?.Price ?? 0;
        //        string relatedName = p?.Related?.Name ?? "<None>";
        //        //This causes a big fat null reference exception since one of the products is null in the array 
        //        //I could have just check to see if "p" was null ¯\_(ツ)_/¯ like this 
        //        //if(p != null)
        //        //Then do the rest of the stuff
        //        //bool instock = p.InStock;
        //        results.Add(string.Format($"Name: {name}, Price: {price}, Releated {relatedName}"));
        //    }

        //    return View(results);
          
        //}
    }
}
