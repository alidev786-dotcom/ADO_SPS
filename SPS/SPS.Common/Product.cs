using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.Common
{
    public enum Category
    {
        sports,
        garments,
        stationary,
        grocery
    }
    public class Product
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
    }
}
