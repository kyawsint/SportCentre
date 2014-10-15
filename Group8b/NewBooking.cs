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
    public partial class NewBooking : Form
    {
        SportController sc = new SportController();
        MemberController mc = new MemberController();

        int size, sportid, memid;

        public NewBooking()
        {
            InitializeComponent();
        }

        private void NewBooking_Load(object sender, EventArgs e)
        {
            var sourcecus = new AutoCompleteStringCollection();
            var memlist = mc.GetMembers();
            foreach (App_Data.Member m in memlist)
            {
                sourcecus.AddRange(new string[]
                {
                    m.Name+Environment.NewLine
                });
            }

            txtmemname.AutoCompleteCustomSource = sourcecus;
            txtmemname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtmemname.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var sport= sc.GetSports();
            foreach (App_Data.Sport s in sport)
            {
                ddlSportName.Items.Add(s.Name);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            BookingForm bf = new BookingForm();
            if (Convert.ToInt16(txtSize.Text) <= size)
            {
                bf.SetData(txtmemname.Text, memid, ddlSportName.SelectedItem.ToString(), sportid, dtpDate.Value.Date, Convert.ToInt16(txtSize.Text));
                bf.Show();
                this.Close();
            }

            else
            {
                lblnopeople.Text = "Over Limit!";
                lblnopeople.Visible = true;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSize.Clear();
            lblnopeople.Visible = false;
        }

        private void ddlSportName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblnopeople.Visible = false;
            var sportname= sc.GetSport(ddlSportName.SelectedItem.ToString());
            this.size = Convert.ToInt16(sportname.Size);
            this.sportid = Convert.ToInt16(sportname.ID);
            txtSize.Text = sportname.Size.ToString();
        }

        private void txtmemname_Leave(object sender, EventArgs e)
        {
            SetMemberID();
        }

        private void SetMemberID()
        {
            var mem = mc.GetMember(txtmemname.Text);
            this.memid = mem.ID;
        }
    }
}
