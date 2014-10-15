using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Group8b.App_Data;

namespace Group8b
{
    public partial class Login : Form
    {
        public string query, userName, Password;
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUserId.Text;
            Password = txtPassword.Text;
            UsersController uc = new UsersController();
            if (userName == "" && Password == "")
            {
                MessageBox.Show("Please Enter Login Id and Password");
            }
            else
            {
                if (uc.Is_Valid_User(userName, Password))
                {
                    this.Hide(); //hiding form 1
                    Main M1 = new Main(userName);//passing user Name to Second form so we can user Logged user Name
                    M1.Show();
                }
                else
                    MessageBox.Show("LoginId or Password Is wrong"); //if user Name is not available in database
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            userName = txtUserId.Text;
            Password = txtPassword.Text;
            UsersController uc=new UsersController();

            if (userName == "" && Password == "")
            {
                MessageBox.Show("Please Enter Login Id and Password");
            }
            else
            {
                if (uc.Is_Valid_User(userName, Password))
                {
                    this.Hide(); //hiding form 1
                    ChangePassword c1 = new ChangePassword(userName);//passing to ChangePassword Form
                    c1.Show();
                }
                else
                    MessageBox.Show("LoginId or Password Is wrong"); //if user Name is not available in database
                }
        }
        
    }
}
