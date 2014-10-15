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
    public partial class ChangePassword : Form
    {
        public string uname;//For passing name data
        public string str;
        public SqlConnection con;
        public ChangePassword(string Username)
        {
            uname = Username;
            InitializeComponent();
        }
        private void connection()
        {
            str = "Data Source=(local);" + "Initial Catalog=group8b;Integrated Security=SSPI";
            con = new SqlConnection(str);
            con.Open();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtUserId.Text = uname;
            txtPassword.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string username = txtUserId.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            UsersController uc = new UsersController();
            bool f = false;
            if (newPassword == confirmPassword)
            {
                f=uc.Change_Password(username, confirmPassword);
            }
            else
                MessageBox.Show("New Password and Confirm Password are not matched"); //if new password and confirm passoword are not match

            if (f)
            {
                MessageBox.Show("Password Changed Successfully!");
                this.Close();
                Login Lg = new Login();
                Lg.Show();
            }
        }
    }
}
