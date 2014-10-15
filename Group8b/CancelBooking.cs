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
    public partial class CancelBooking : Form
    {       
        public CancelBooking()
        {
            InitializeComponent();
        }

        private void CancelBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string memname = txtMemname.Text;

            UsersController uc= new UsersController();

            if (uc.Is_Valid_Member(memname))
            {

                dgvBookingInfo.DataSource = uc.View_Booinginfo(memname);
            }
            else
            {
                MessageBox.Show("Not Valid Member!");
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UsersController uc = new UsersController();
           // List<int> ld= new List<int>;
           int  ld = Convert.ToInt32( dgvBookingInfo.CurrentRow.Cells["ID"].Value.ToString());
            uc.Delete_Booking(ld);
            this.Refresh();
        }
    }
}
