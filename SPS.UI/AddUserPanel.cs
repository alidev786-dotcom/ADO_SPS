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
    public partial class AddUserPanel : Form
    {
        public AddUserPanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customersPanel myForm = new customersPanel();
            this.Hide();
            myForm.ShowDialog();    
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checking if all the fields are filled
            if (nameTF.Text != "" && emailTF.Text != "" && passwordTF.Text != "" && confirmPassTF.Text != "")
            {
                //checking if password and confirm password matches or not
                if (passwordTF.Text != confirmPassTF.Text)
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
                    if (result > 0)
                    {
                        MessageBox.Show("User Added");
                        customersPanel myForm = new customersPanel();
                        this.Hide();
                        myForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User cannot be added!");
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory!");
            }
        }
    }
    
}
