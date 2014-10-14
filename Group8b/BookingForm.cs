﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Group8b.App_Data;
using System.Collections;

namespace Group8b
{
    public partial class BookingForm : Form
    {
        SportController sc = new SportController();
        FacilityController fc = new FacilityController();
        SlotController slotc = new SlotController();
        BookTransController bt = new BookTransController();
        group8bEntities ctx = new group8bEntities();

        string memname, sportname, courtname;
        DateTime date;
        int size, sportid, courtid;

        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            txtmemname.Text = memname;
            txtsportname.Text = sportname;
            txtdate.Text = date.Date.ToString();
            txtnoofpeople.Text = size.ToString();
            var fname = fc.GetFacilities(sportid);
            foreach (App_Data.Facility f in fname)
            {
                ddlCCourt.Items.Add(f.CourtName);
            }

            dgvavailable.DataBindings.Clear();
            dgvavailable.DataSource = bt.GetBookTrans(date,sportid);
            dgvavailable.FirstDisplayedScrollingRowIndex = 0;
            dgvavailable.Columns["time"].Visible = false;
            dgvavailable.Columns["status"].Visible = false;
            dgvavailable.Columns["sportid"].Visible = false;
            dgvavailable.Columns["slotid"].Visible = false;
            dgvavailable.Columns["facilityid"].Visible = false;
            dgvavailable.Columns["date"].Visible = false;
        }

        internal void SetBooking(string memname, string sportname, int sportid, DateTime date, int size)
        {
            this.memname = memname;
            this.sportname = sportname;
            this.date = date;
            this.size = size;
            this.sportid = sportid;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NewBooking nb = new NewBooking();
            nb.Show();
            this.Close();
        }

        private void ddlCCourt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int facid = fc.GetFacility(ddlCCourt.SelectedItem.ToString()).ID;
            this.courtname=ddlCCourt.SelectedItem.ToString();
            courtid = facid;
            dgvslot.DataBindings.Clear();
            label2.Text = ddlCCourt.SelectedItem.ToString();

            dgvslot.DataSource = bt.GetBookTrans(facid,date);
            dgvslot.Columns["available"].Visible = false;
            dgvslot.Columns["courtname"].Visible = false;
            dgvslot.Columns["sportid"].Visible = false;
            dgvslot.Columns["slotid"].Visible = false;
            dgvslot.Columns["facilityid"].Visible = false;
            dgvslot.Columns["date"].Visible = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int slotid= Convert.ToInt16(dgvslot.CurrentRow.Cells["slotid"].Value.ToString());
            bt.AddBookingInfo(3, sportid, courtid, slotid, date, "Reversed");
            BookingInfo bi = new BookingInfo();
            bi.MemberID = '1';
            bi.SportID = sportid;
            bi.FacilityID = courtid;
            ConfirmBooking cb = new ConfirmBooking();
            cb.SetData(memname, sportname, courtname, "9:00", size);
            cb.ShowDialog();
        }
    }
}
