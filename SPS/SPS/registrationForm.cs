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
    public partial class registrationForm : Form
    {
        public registrationForm()
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
            else if(emailTF.Text=="")
            {
                MessageBox.Show("All fields are mandatory!");
            }
            else if(passwordTF.Text=="")
            {
                MessageBox.Show("All fields are mandatory!");
            }
            else
            {
                if(passwordTF.Text!=confirmTF.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                }
                else
                {
                    //making object of user and passing to UserBLL 
                    User newUser = new User();
                    newUser.ID = Convert.ToInt32(idTF.Text);
                    newUser.Name = nameTF.Text;
                    newUser.email = emailTF.Text;
                    newUser.password  = passwordTF.Text;
                    newUser.isAdmin = isAdmin.Checked;

                    UserBLL userBLL = new UserBLL();
                    if (userBLL.addUser(newUser))
                    {
                        MessageBox.Show("User added successfully!");
                    }
                    else
                        MessageBox.Show("User couldn't be added!");
                }
            }
        }
    }
}
