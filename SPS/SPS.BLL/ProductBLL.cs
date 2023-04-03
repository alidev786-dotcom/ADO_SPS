using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPS.Common;
using SPS.DAL;
using System.Collections;

namespace SPS.BLL
{
    public class ProductBLL
    {
        public bool insertProduct(Product p)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.addProduct(p);
        }
        public List<Product> returnAllProducts()
        {
            ProductDAL productDAL=new ProductDAL();
            return productDAL.getAllProducts();
        }
    }
}
