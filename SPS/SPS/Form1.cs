using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using SPS.Common;
using SPS.BLL;

namespace SPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registrationForm myForm = new registrationForm();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(emailTF.Text=="")
            {
                MessageBox.Show("All fields are mandatory!");
            }
            else if(passwordTF.Text=="")
            {
                MessageBox.Show("All fields are mandatory!");
            }
            else
            {
                UserBLL userBLL = new UserBLL();
                List<User> users = userBLL.returnAllUsers();
                for (int i = 0; i < users.Count; i++)
                {
                    //MessageBox.Show(users[i].email);
                    if (emailTF.Text == users[i].email && passwordTF.Text == users[i].password)
                    {
                        if(users[i].isAdmin)  //if admin, then show admin panel
                        {
                            adminPanel admin = new adminPanel();
                            this.Hide();
                            admin.ShowDialog();
                            this.Close();
                        }
                        else //else showing customer panel
                        {
                            CustomerProductsForm myForm = new CustomerProductsForm();
                            this.Hide();
                            myForm.ShowDialog();
                            this.Close();
                        }
                    }
                }
                MessageBox.Show("Invalid Credentials!");
            }
        }
    }
}
