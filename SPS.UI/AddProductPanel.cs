using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPS.Common;
using SPS.BLL;

namespace SPS.UI
{
    public partial class AddProductPanel : Form
    {
        public AddProductPanel()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductsPanel myForm = new ProductsPanel();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void nameTF_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nameTF.Text!="" && categoryTF.Text!="" && priceTF.Text!="" && quantityTF.Text!="")
            {
                //checking if price and quantity tags contain numbers
                if(priceTF.Text.All(char.IsDigit)==false || quantityTF.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("Price and Quantity must contain numbers!");
                }
                else
                {
                    //checking if product already exists or not
                    ProductBLL productBLL = new ProductBLL();
                    Product prod = new Product();
                    prod.name = nameTF.Text;
                    prod.category = categoryTF.Text;
                    prod.price = float.Parse(priceTF.Text);
                    prod.quantity = Convert.ToInt32(quantityTF.Text);
                    if(productBLL.ProductExists(prod.name,prod.category))
                    {
                        MessageBox.Show("Product already exists!");
                        return;
                    }
                    var res = productBLL.insertProduct(prod);
                    if(res>0)
                    {
                        MessageBox.Show("Product inserted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error in inserting product");
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory!");
            }
        }
    }
}
