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
    public partial class customersPanel : Form
    {
        public customersPanel()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainAdminPanel myForm = new mainAdminPanel();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void customersPanel_Load(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            List<User> users = new List<User>();
            users = userBLL.returnAllUsers();
            customersDataGridView.DataSource = users;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUserPanel myForm = new AddUserPanel();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void customersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //getting index of selected row in data grid view
            int index = e.RowIndex;
            DataGridViewRow selected_row = customersDataGridView.Rows[index];
            idTF.Text = Convert.ToString(selected_row.Cells[0].Value);
            nameTF.Text = Convert.ToString(selected_row.Cells[1].Value);
            passwordTF.Text = Convert.ToString(selected_row.Cells[2].Value);
            emailTF.Text = Convert.ToString(selected_row.Cells[3].Value);
            isAdmin.Checked = Convert.ToBoolean(selected_row.Cells[4].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(idTF.Text=="" || nameTF.Text=="" || passwordTF.Text=="" || emailTF.Text=="")
            {
                MessageBox.Show("Fields are empty! Please select a record");
                return;
            }
            User user = new User();
            user.name = nameTF.Text;
            user.password = passwordTF.Text;
            user.email =   emailTF.Text;
            user.isAdmin = isAdmin.Checked;
            UserBLL userBLL = new UserBLL();
            //getting current id
            int id = Convert.ToInt32(idTF.Text) ;
            var res = userBLL.updateUser(id,user);
            if (res > 0)
            {
                MessageBox.Show("User Updated successfully!");
                //updating the data grid view
                customersPanel myForm = new customersPanel();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("User could not be updated!");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idTF.Text == "" || nameTF.Text == "" || passwordTF.Text == "" || emailTF.Text == "")
            {
                MessageBox.Show("Fields are empty! Please select a record");
                return;
            }
            //getting id first
            int id = Convert.ToInt32(idTF.Text);
            UserBLL userBLL = new UserBLL();
            var result = userBLL.deleteUser(id);
            if(result> 0)
            {
                MessageBox.Show("User deleted successfully!");
                customersPanel myForm = new customersPanel();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in deleting User!");
            }
        }
    }
}
