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
    public partial class SportLookUp : Form
    {
        SportController sc = new SportController();
       

        public string SportIDString
        {
            get { return dgvsport.CurrentRow.Cells["ID"].Value.ToString(); }
        }

        public SportLookUp()
        {
            InitializeComponent();
        }

        private void FacilityLookUp_Load(object sender, EventArgs e)
        {
            dgvsport.DataSource = sc.GetSports();
            dgvsport.Columns["BookingInfoes"].Visible = false;
            dgvsport.Columns["Facilities"].Visible = false;
            
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        

        private void btCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        }
    }

