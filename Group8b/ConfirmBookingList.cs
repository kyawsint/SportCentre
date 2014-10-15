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

        public ConfirmBookingList()
        {
            InitializeComponent();
        }

        private void ConfirmBookingList_Load(object sender, EventArgs e)
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
            Convert.ToInt32(dgvCBooking.CurrentRow.Cells["ID"].Value.ToString());
        }
    }
}
