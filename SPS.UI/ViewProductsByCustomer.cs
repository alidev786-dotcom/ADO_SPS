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
    public partial class ViewProductsByCustomer : Form
    {
        public int login_id;
        public ViewProductsByCustomer(int id)
        {
            this.login_id = id;
            InitializeComponent();
        }

        private void ViewProductsByCustomer_Load(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            productsDataGridView.DataSource = productBLL.getAllProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainCustomerPanel panel = new MainCustomerPanel(this.login_id);
            this.Hide();
            panel.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(nameTF.Text=="")
            {
                ProductBLL productBLL = new ProductBLL();
                productsDataGridView.DataSource = productBLL.getAllProducts();
                //MessageBox.Show("Fields are empty!");
                //return;
            }
            else
            {
                ProductBLL prodBLL = new ProductBLL();
                Product prod = new Product();
                prod = prodBLL.searchProductByName(nameTF.Text);
                if(prod!=null)
                {
                    List<Product> products = new List<Product>();
                    products.Add(prod);
                    productsDataGridView.DataSource = products;
                }
                else
                {
                    MessageBox.Show("Product Does not Exists!");
                    nameTF.Text = "";
                }
            }
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
