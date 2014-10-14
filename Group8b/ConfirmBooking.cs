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
    public partial class ConfirmBooking : Form
    {
        string memname, sportname, courtname, time;
        int noofpeople;
        
        public ConfirmBooking()
        {
            InitializeComponent();
        }

        private void ConfirmBooking_Load(object sender, EventArgs e)
        {
            txtmemname.Text = memname;
            txtsportname.Text = sportname;
            txtcourtname.Text = courtname;
            txttime.Text = time;
            txtnoofpeople.Text = noofpeople.ToString();
        }

        public void SetData(string memname, string sportname, string courtname, string time, int noofpeople)
        {
            this.memname = memname;
            this.sportname = sportname;
            this.courtname = courtname;
            this.time = time;
            this.noofpeople = noofpeople;
        }
    }
}
