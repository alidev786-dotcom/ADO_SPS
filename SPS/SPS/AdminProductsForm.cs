using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPS.BLL;
using System.Collections;
using SPS.Common;

namespace SPS
{
    public partial class AdminProductsForm : Form
    {
        public AdminProductsForm()
        {
            InitializeComponent();
        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
           ProductBLL productBLL = new ProductBLL();
           List<Product> products = productBLL.returnAllProducts();
            productGridView.DataSource = products;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPanel admin = new adminPanel();
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }
    }
}
