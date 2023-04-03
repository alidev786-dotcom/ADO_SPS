using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPS.DAL;
using SPS.Common;

namespace SPS.BLL
{
    public class ProductBLL
    {
        public int insertProduct(Product newProduct)
        {
            ProductDAL prodDAL = new ProductDAL();
            return prodDAL.addProduct(newProduct);
        }
        public bool ProductExists(string name,string category)
        {
            ProductDAL prodDAL = new ProductDAL();
            return prodDAL.productExists(name,category);
        }
        public List<Product> getAllProducts()
        {
            ProductDAL prodDAL = new ProductDAL();
            return prodDAL.getAllProducts();
        }

        public int updateProduct(int id,Product newProduct)
        {
            ProductDAL prodDAL = new ProductDAL();
            return prodDAL.updateProduct(id,newProduct);
        }
        public int deleteProduct(int id)
        {
            ProductDAL prodDAL = new ProductDAL();
            return prodDAL.deleteProduct(id);
        }
        public Product searchProductByName(string name)
        {
            ProductDAL prodDAL = new ProductDAL();
            return prodDAL.searchProductsByName(name);
        }
    }
}
