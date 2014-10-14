using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Group8b
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewMember anm = new AddNewMember();
            anm.Show();
        }

        private void addNewSportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewSport ans = new AddNewSport();
            ans.Show();
        }

        private void addNewFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewFacility anf = new AddNewFacility();
            anf.Show();
        }

        private void addNewSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewSlot ans = new AddNewSlot();
            ans.Show();
        }

        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enquiry enq = new Enquiry();
            enq.Show();
        }

        private void newBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBooking nb = new NewBooking();
            nb.Show();
        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelBooking cb = new CancelBooking();
            cb.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member mem = new Member();
            mem.Show();
        }

        private void sportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sport s = new Sport();
            s.Show();
        }

        private void facilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facility f = new Facility();
            f.Show();
        }

        private void slotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Slot s = new Slot();
            s.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
