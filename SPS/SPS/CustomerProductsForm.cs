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
    public partial class CustomerProductsForm : Form
    {
        public CustomerProductsForm()
        {
            InitializeComponent();
        }

        private void CustomerProductsForm_Load(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            List<Product> products = productBLL.returnAllProducts();
            productsGridView.DataSource = products;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
