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
    public partial class ConfirmBookingList : Form
    {
        BookTransController btc = new BookTransController();
        MemberController mc = new MemberController();

        public ConfirmBookingList()
        {
            InitializeComponent();
        }

        private void ConfirmBookingList_Load(object sender, EventArgs e)
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

            ShowBookingInfo();
        }

        private void ShowBookingInfo()
        {
            if ((btc.GetBookingInfoes()).Count != 0)
            {
                dgvCBooking.DataSource = btc.GetBookingInfoes();

                dgvCBooking.Columns["facility"].Visible = false;
                dgvCBooking.Columns["member"].Visible = false;
                dgvCBooking.Columns["slot"].Visible = false;
                dgvCBooking.Columns["sport"].Visible = false;
            }
            else
            {
                lblnorecord.Visible = true;
                lblnorecord.Text = "No record for confirmation";
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int bid= Convert.ToInt32(dgvCBooking.CurrentRow.Cells["ID"].Value.ToString());
            btc.UpdateBookingInfo(bid, "Confirmed");
            ShowBookingInfo();
        }

        private void txtmemname_Leave(object sender, EventArgs e)
        {
            dgvCBooking.DataSource = btc.GetBookingInfoes(txtmemname.Text);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dgvCBooking.DataSource = btc.GetBookingInfoes(dtpDate.Value.Date);
        }
    }
}
