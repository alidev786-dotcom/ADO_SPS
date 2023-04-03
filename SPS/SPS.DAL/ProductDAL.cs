using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPS.Common;
using System.IO;
using System.Collections;

namespace SPS.DAL
{
    public class ProductDAL
    {
        public bool addProduct(Product prod)
        {
            StreamWriter sw;
            try
            {
                sw = new StreamWriter(@"C:\Users\madina\OneDrive\Desktop\SPS\product.txt",true);
                sw.WriteLine(prod.ID + "," + prod.name + "," + prod.category + "," + prod.price + "," + prod.quantity);
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in reading product file");
                return false;
            }
            sw.Close();
        }
        public List<Product> getAllProducts()
        {
            List<Product> products = new List<Product>();
            StreamReader sr = new StreamReader(@"C:\Users\madina\OneDrive\Desktop\SPS\product.txt");
            string line = null;
            while((line=sr.ReadLine())!=null)
            {
                Product prod = new Product();
                string[] data = line.Split(',');
                prod.ID = Convert.ToInt32(data[0]);
                prod.name = data[1];
                prod.category = data[2];
                prod.price = Convert.ToDouble(data[3]);
                prod.quantity = Convert.ToInt32(data[4]);
                products.Add(prod);
            }
            return products;
        }
    }
}
