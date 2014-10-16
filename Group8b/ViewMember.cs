using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Group8b.App_Data;
using System.Text.RegularExpressions;

namespace Group8b
{
    public partial class ViewMember : Form
    {
        string name, Address, PostalCode, PhoneNumber, Email;

        MemberController mc = new MemberController();

        public ViewMember()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMember emem = new EditMember();
            name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            Address = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            PostalCode = dataGridView1.CurrentRow.Cells["PostalCode"].Value.ToString();
            PhoneNumber = dataGridView1.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            Email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            emem.GetData(name, Address, PostalCode, PhoneNumber, Email);
            emem.ShowDialog();
            Reload();
            emem.Dispose();
        }

        private void btnAddNewMember_Click_1(object sender, EventArgs e)
        {
            AddNewMember form_anm = new AddNewMember();
            form_anm.Show();
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            group8bEntities context2 = new group8bEntities();
            string memname = Convert.ToString(Regex.Split(textBox1.Text, "\r\n")[0]);
            
            var q = from m in context2.Members
                    where m.Name == memname
                    select m;

            dataGridView1.DataSource = q.ToList();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            group8bEntities context3 = new group8bEntities();

            App_Data.Member m =new App_Data.Member();

            var q = from x in context3.Members
                    where x.ID==Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString())
                    select x;
            m.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

            App_Data.Member mm = context3.Members.Where(p=>p.ID == m.ID).Single();
            context3.Members.DeleteObject(mm);
            context3.SaveChanges();
            group8bEntities ctx = new group8bEntities();
            dataGridView1.DataSource = ctx.Members;

            dataGridView1.Rows[0].Selected = false;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["bookinginfoes"].Visible = false;
        }

        private void Member_Load(object sender, EventArgs e)
        {
            group8bEntities ctx = new group8bEntities();
            dataGridView1.DataSource = ctx.Members;

            dataGridView1.Rows[0].Selected = false;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["bookinginfoes"].Visible = false;

            var source = new AutoCompleteStringCollection();
            var memberlist = mc.GetMembers();
            foreach (App_Data.Member m in memberlist)
            {
                source.AddRange(new string[] { m.Name + Environment.NewLine });
            }

            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
