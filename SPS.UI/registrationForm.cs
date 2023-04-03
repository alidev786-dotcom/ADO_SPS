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
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
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
            //checking if all the fields are filled
            if(nameTF.Text!="" && emailTF.Text!="" && passwordTF.Text!="" && confirmPassTF.Text!="")
            {
                //checking if password and confirm password matches or not
                if(passwordTF.Text!=confirmPassTF.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                }
                else
                {
                    //now getting all the data
                    User newUser = new User();
                    newUser.name = nameTF.Text;
                    newUser.email = emailTF.Text;
                    newUser.password = passwordTF.Text;
                    newUser.isAdmin = isAdmin.Checked;
                    UserBLL userBLL = new UserBLL();
                    if(userBLL.userPresent(newUser.email,newUser.password,newUser.isAdmin))
                    {
                        MessageBox.Show("User already exists!");
                        return;
                    }
                    var result = userBLL.insertUser(newUser);
                    if(result>0)
                    {
                        MessageBox.Show("Welcome " + newUser.name + "! You are registered successfully!");
                        customersPanel myForm = new customersPanel();
                        this.Hide();
                        myForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful attemp!");
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory!");
            }
        }

        private void isAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void passwordTF_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPassTF_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTF_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
