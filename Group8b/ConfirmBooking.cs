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
    public partial class ConfirmBooking : Form
    {
        BookTransController btc = new BookTransController();

        string memname, sportname, courtname, time;
        int noofpeople, memid, slotid, bid;
        DateTime date;
        
        public ConfirmBooking()
        {
            InitializeComponent();
        }

        private void ConfirmBooking_Load(object sender, EventArgs e)
        {
            txtmemname.Text = memname;
            txtsportname.Text = sportname;
            txtcourtname.Text = courtname;
            txtDate.Text = date.ToString() ;
            txttime.Text = time;
            txtnoofpeople.Text = noofpeople.ToString();
        }

        public void SetData(int bid, string memname, int memid, int slotid, string sportname, string courtname, DateTime date, string time, int noofpeople)
        {
            this.bid = bid;
            this.memname = memname;
            this.memid = memid;
            this.slotid = slotid;
            this.sportname = sportname;
            this.courtname = courtname;
            this.date = date;
            this.time = time;
            this.noofpeople = noofpeople;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btc.UpdateBookingInfo(bid, "Confirmed");
            this.Close();
        }
    }
}
