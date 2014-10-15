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
    public partial class FacilityLookUp : Form
    {
        FacilityController fc = new FacilityController();

        public FacilityLookUp()
        {
            InitializeComponent();
        }

        public int FacilityID
        {
            get { return Convert.ToInt16(dgvfacility.CurrentRow.Cells["ID"].Value); }
        }

        private void FacilityLookUp_Load(object sender, EventArgs e)
        {
            dgvfacility.DataSource = fc.GetFacilities();

            dgvfacility.Columns["bookinginfoes"].Visible = false;
            dgvfacility.Columns["sport"].Visible = false;
            dgvfacility.Columns["slot"].Visible = false;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
