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

namespace SPS
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(idTF.Text=="")
            {
                MessageBox.Show("All fields are mandatory!");
            }
            else if(nameTF.Text=="")
            {
                MessageBox.Show("All fields are mandatory!");
            }
            else if(categoryTF.Text=="")
            {
                MessageBox.Show("All fields are mandatory!");
            }
            else if(priceTF.Text=="")
            {
                MessageBox.Show("All fields are mandatory!");
            }
            else if(quantityTF.Text=="")
            {
                MessageBox.Show("All fields are mandatory!");
            }
            else
            {
                //making product object
                Product prod = new Product();
                prod.ID = Convert.ToInt32(idTF.Text);
                prod.name = nameTF.Text;
                prod.category = categoryTF.Text;
                prod.price = Convert.ToDouble(priceTF.Text);
                prod.quantity = Convert.ToInt32(quantityTF.Text);
                ProductBLL productBLL = new ProductBLL();
                if (productBLL.insertProduct(prod))
                {
                    MessageBox.Show("Product added successfully!");
                }
                else
                    MessageBox.Show("Error in adding product!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPanel f = new adminPanel();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
