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
    public partial class ViewProfile : Form
    {
        public int login_id;
        public ViewProfile(int id)
        {
            this.login_id = id;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User updatedUser = new User();
            updatedUser.name = nameTF.Text;
            updatedUser.email = emailTF.Text;
            updatedUser.password = passwordTF.Text;
            updatedUser.isAdmin = isAdmin.Checked;
            UserBLL userBLL = new UserBLL();
            var res = userBLL.updateUser(login_id, updatedUser);
            if (res > 0)
            {
                MessageBox.Show("User updated Successfully");
                ViewProfile profile = new ViewProfile(this.login_id);
                this.Hide();
                profile.ShowDialog();
                this.Close();
            }
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            User currentUser = new User();
            currentUser = userBLL.returnUser(this.login_id);
            Console.WriteLine(currentUser.name);
            idTF.Text = Convert.ToString(currentUser.id);
            nameTF.Text= currentUser.name;
            passwordTF.Text= currentUser.password;
            emailTF.Text = currentUser.email;
            isAdmin.Checked = currentUser.isAdmin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainCustomerPanel myForm = new MainCustomerPanel(this.login_id);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void passwordTF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
