using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabCoffeeShopApp.Data
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public float Price { get; set; }
    }
}
