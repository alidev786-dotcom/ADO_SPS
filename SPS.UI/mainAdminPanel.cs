using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS.UI
{
    public partial class mainAdminPanel : Form
    {
        public mainAdminPanel()
        {
            InitializeComponent();
        }

        private void mainAdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm myForm = new loginForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersPanel myForm = new customersPanel();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductsPanel myForm = new ProductsPanel();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
