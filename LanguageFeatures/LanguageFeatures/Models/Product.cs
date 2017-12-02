using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Catagory { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get;}

        public Product(bool stock = true)
        {
            InStock = true;

        } 


        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Catagory = "Water Craft",
                Price = 275M
            };

            Product lifeJacket = new Product(false)
            {
                Name = "Life Jacket",
                Price = 48.95M
            };

            kayak.Related = lifeJacket;

            //adding the null to demonstrate how the new null reference check works. Normally this would dumb to do ¯\_(ツ)_/¯
            return new Product[] 
            {
                kayak,
                lifeJacket,
                null
            };
        }
    }
}
