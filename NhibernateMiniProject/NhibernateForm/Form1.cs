using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using ServiceSample;

namespace NhibernateForm
{
    public partial class Form1 : Form
    {
        private readonly UserService userService=new UserService(); 


        public Form1()
        {
            InitializeComponent();

            GetUser();

        }

        private void GetUser()
        {
            List<User> userList = userService.UserList().ToList();
            dataGridView1.DataSource = userList;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            User _user=new User
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Age = Convert.ToInt32(textBox3.Text),
                RegisteredDate = DateTime.Now
            };
            userService.UserAdded(_user);
            GetUser();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
