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
    public partial class AddNewMember : Form
    {
        MemberController msc = new MemberController();

        public group8bEntities context = new group8bEntities();

        public AddNewMember()
        {
            InitializeComponent();
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            var query = from x in context.Members
                        where x.Name == textBoxN.Text
                        select x;

            App_Data.Member m2 = new App_Data.Member();

            m2.Name = textBoxN.Text;
            m2.Address = textBoxA.Text;
            m2.PostalCode = textBoxPC.Text;
            m2.PhoneNumber = textBoxPN.Text;
            m2.Email = textBoxE.Text;

            context.AddToMembers(m2);
            context.SaveChanges();
            MessageBox.Show("Successfully added!");
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewMember_Load(object sender, EventArgs e)
        {
            var source = new AutoCompleteStringCollection();
            var memberlist = msc.GetMembers();
            foreach (App_Data.Member m in memberlist)
            {
                source.AddRange(new string[] { m.Name + Environment.NewLine });
            }

            textBoxN.AutoCompleteCustomSource = source;
            textBoxN.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxN.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }



    }
}
