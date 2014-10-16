using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Group8b.App_Data;

namespace Group8b
{
    public partial class EditMember : Form
    {
        public string name;
        public string Address;
        public string PostalCode;
        public string PhoneNumber;
        public string Email;

        public void GetData(string name, string address, string postalcode, string phonenumber, string email)
        {
            this.name = name;
            this.Address = address;
            this.PostalCode = postalcode;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }

        public EditMember()
        {
            InitializeComponent();
        }

        private void EditMember_Load(object sender, EventArgs e)
        {
            textBoxN.Text = name;
            textBoxA.Text = Address;
            textBoxPC.Text = PostalCode;
            textBoxPN.Text = PhoneNumber;
            textBoxE.Text = Email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            group8bEntities context = new group8bEntities();
            var query = from x in context.Members
                        where x.Name == textBoxN.Text
                        select x;

            App_Data.Member m = query.First();
            m.Name = textBoxN.Text;
            m.Address = textBoxA.Text;
            m.PostalCode = textBoxPC.Text;
            m.PhoneNumber = textBoxPN.Text;
            m.Email = textBoxE.Text;

            context.SaveChanges();
            MessageBox.Show("Successfully edited!");

            ViewMember vm = new ViewMember();
            vm.Reload();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
