using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Group8b
{
    public partial class Main : Form
    {
        public string uname;//For testing
        public string str;
        public SqlConnection con;
        public Main(string username)
        {
            uname = username;//For testing
            InitializeComponent();
        }

        private void connection()//connnection
        {
            str = "Data Source=(local);" + "Initial Catalog=group8b;Integrated Security=SSPI";
            con = new SqlConnection(str);
            con.Open();
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
            ViewMember mem = new ViewMember();
            mem.Show();
        }

        private void sportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSport s = new ViewSport();
            s.Show();
        }

        private void facilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFacility f = new ViewFacility();
            f.Show();
        }

        private void slotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSlot s = new ViewSlot();
            s.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            lblActiveUser.Text = "Current Active User:" + " " + Convert.ToString(uname);
            Login Lg = new Login();
            Lg.Hide();

            //indoor facilities
            connection();
            string indoor_sqlquery = "select top(5)* from sports where sporttype='indoor'";
            SqlCommand indoor_cmd = new SqlCommand(indoor_sqlquery, con);
            SqlDataReader indoor_rd = indoor_cmd.ExecuteReader();
            lblIndoorFacilitiies.Text = "";
            while (indoor_rd.Read())
            {

                lblIndoorFacilitiies.Text += indoor_rd["Name"].ToString() + "\t" + indoor_rd["Description"].ToString()+Environment.NewLine+Environment.NewLine;
                
            }
            indoor_rd.Close();

            //outdoor facilities
            connection();
            string outdoor_sqlquery = "select top(5)* from sports where sporttype='outdoor'";
            SqlCommand outdoor_cmd = new SqlCommand(outdoor_sqlquery, con);
            SqlDataReader outdoor_rd = outdoor_cmd.ExecuteReader();
            lblOutdoorFacilitiies.Text = "";
            while (outdoor_rd.Read())
            {

                lblOutdoorFacilitiies.Text += outdoor_rd["Name"].ToString() + "\t" + outdoor_rd["Description"].ToString() + Environment.NewLine + Environment.NewLine;

            }
            outdoor_rd.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Lg = new Login();
            Lg.Show();
        }

        private void confirmBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmBookingList cbl = new ConfirmBookingList();
            cbl.Show();
        }

     
    }
}
