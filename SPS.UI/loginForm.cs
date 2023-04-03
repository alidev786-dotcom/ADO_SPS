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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationForm myForm = new registrationForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checking if all the fields are entered
            if(emailTF.Text!="" && passwordTF.Text!="")
            {
                UserBLL userBLL = new UserBLL();
                bool is_admin = isAdmin.Checked;
                if (userBLL.userPresent(emailTF.Text, passwordTF.Text,is_admin)==true)
                {
                    if(is_admin==true)  //admin login
                    {
                        mainAdminPanel myForm = new mainAdminPanel();
                        this.Hide();
                        myForm.ShowDialog();
                        this.Close();
                    }
                    else                       //customer login
                    {
                        int id = userBLL.getID(emailTF.Text, passwordTF.Text);
                        MainCustomerPanel form = new MainCustomerPanel(id);
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("User/Admin does not exist!");
            }
            else
            {
                MessageBox.Show("All fields are mandatory!");
            }
        }
    }
}
