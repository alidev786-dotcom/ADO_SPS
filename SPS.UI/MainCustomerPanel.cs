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
    public partial class MainCustomerPanel : Form
    {
        public int login_id;
        public MainCustomerPanel(int id)
        {
            this.login_id = id;
            InitializeComponent();
        }

        private void MainCustomerPanel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm myForm = new loginForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewProfile myForm = new ViewProfile(this.login_id);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewProductsByCustomer panel = new ViewProductsByCustomer(this.login_id);
            this.Hide();
            panel.ShowDialog();
            this.Close();
        }
    }
}
