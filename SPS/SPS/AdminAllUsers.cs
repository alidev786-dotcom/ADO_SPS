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
using System.Collections;

namespace SPS
{
    public partial class AdminAllUsers : Form
    {
        public AdminAllUsers()
        {
            InitializeComponent();
        }

        private void usersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            List<User> users = new List<User>();
            users = userBLL.returnAllUsers();
            usersGridView.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPanel admin = new adminPanel();
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }
    }
}
