using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPS.Common;
using System.Data.SqlClient;

namespace SPS.DAL
{
    public class ProductDAL
    {
        public int addProduct(Product newProduct)
        {
            string connString = "server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string myQuery = "insert into [products](name,category,price,quantity) values('"+newProduct.name+"','"+newProduct.category+"',"+newProduct.price+","+newProduct.quantity+") ;";
            SqlCommand cmd = new SqlCommand(myQuery,myConn);
            var result = cmd.ExecuteNonQuery();
            return result;
        }
        public List<Product> getAllProducts()
        {
            List<Product> products = new List<Product>();
            string connString = @"server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string myQuery = "select * from [products];";
            SqlCommand cmd = new SqlCommand(myQuery, myConn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.id = Convert.ToInt32(reader["id"]);
                product.name = Convert.ToString(reader["name"]);
                product.category = Convert.ToString(reader["category"]);
                product.price = float.Parse(Convert.ToString(reader["price"]));
                product.quantity = Convert.ToInt32(reader["quantity"]);
                //adding user to user list
                products.Add(product);
            }
            return products;
        }
        public bool productExists(string name, string category)
        {
            string connString = @"server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string myQuery = "select name,category from [products];";
            SqlCommand cmd = new SqlCommand(myQuery, myConn);
            SqlDataReader sdr = cmd.ExecuteReader();
            bool found = false;
            while (sdr.Read())
            {
                if (Convert.ToString(sdr["name"]) == name && Convert.ToString(sdr["category"]) == category)
                {
                    found = true;
                }
            }
            return found;
        }
        public int updateProduct(int id, Product updatedProduct)
        {
            string connString = @"server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string myQuery = "update [products] set name='"+updatedProduct.name+"',category='"+updatedProduct.category+"',price="+updatedProduct.price+",quantity="+updatedProduct.quantity+" where id="+id+";";
            SqlCommand cmd = new SqlCommand(myQuery, myConn);
            var result = cmd.ExecuteNonQuery();
            myConn.Close();
            cmd.Dispose();
            myConn.Dispose();
            return result;
        }
        public int deleteProduct(int id)
        {
            string connString = "server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string myQuery = "delete from [products] where id=" + id + ";";
            SqlCommand cmd = new SqlCommand(myQuery, myConn);
            var result = cmd.ExecuteNonQuery();
            return result;
        }
        public Product searchProductsByName(string name)
        {
            Product prod  = new Product();
            string connString = @"server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string myQuery = "select * from [products] where name='"+name+"';";
            SqlCommand cmd = new SqlCommand(myQuery, myConn);
            SqlDataReader sdr = cmd.ExecuteReader();
            bool found = false;
            while (sdr.Read())
            {
                prod.id = Convert.ToInt32(sdr["ID"]); 
                prod.name = Convert.ToString(sdr["name"]);
                prod.category = Convert.ToString(sdr["category"]);
                prod.price = float.Parse(Convert.ToString(sdr["price"]));
                prod.quantity = Convert.ToInt32(sdr["quantity"]);
            }
            return prod;
        }
    }
}
