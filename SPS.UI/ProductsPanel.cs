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
using SPS.Common;

namespace SPS.UI
{
    public partial class ProductsPanel : Form
    {
        public ProductsPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductsPanel_Load(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            productsDataGridView.DataSource = productBLL.getAllProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainAdminPanel myForm = new mainAdminPanel();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProductPanel addProductPanel = new AddProductPanel();
            this.Hide();
            addProductPanel.ShowDialog();
            this.Close();
        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //getting index of selected row in data grid view
            int index = e.RowIndex;
            DataGridViewRow selected_row = productsDataGridView.Rows[index];
            idTF.Text = Convert.ToString(selected_row.Cells[0].Value);
            nameTF.Text = Convert.ToString(selected_row.Cells[1].Value);
            categoryTF.Text = Convert.ToString(selected_row.Cells[2].Value);
            priceTF.Text = Convert.ToString(selected_row.Cells[3].Value);
            quantityTF.Text = Convert.ToString(selected_row.Cells[4].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(nameTF.Text=="" || categoryTF.Text=="" || priceTF.Text=="" || quantityTF.Text=="")
            {
                MessageBox.Show("All fields must be filled!Select atleast one product!");
                return;
            }
            int id = Convert.ToInt32(idTF.Text);
            Product updatedProduct = new Product();
            updatedProduct.name = nameTF.Text;
            updatedProduct.category = categoryTF.Text;
            updatedProduct.price = float.Parse(priceTF.Text);
            updatedProduct.quantity = Convert.ToInt32(quantityTF.Text);
            ProductBLL productBLL = new ProductBLL();
            var result = productBLL.updateProduct(id, updatedProduct);
            if(result>0)
            {
                MessageBox.Show("Product updated successfully!");
                ProductsPanel f = new ProductsPanel();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in updating product!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (nameTF.Text == "" || categoryTF.Text == "" || priceTF.Text == "" || quantityTF.Text == "")
            {
                MessageBox.Show("All fields must be filled!Select atleast one product!");
                return;
            }
            int id = Convert.ToInt32(idTF.Text);
            ProductBLL productBLL = new ProductBLL();
            var result = productBLL.deleteProduct(id);
            if (result > 0)
            {
                MessageBox.Show("Product deleted successfully!");
                ProductsPanel f = new ProductsPanel();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in deleting product!");
            }
        }
    }
}
