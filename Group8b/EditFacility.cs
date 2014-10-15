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
    public partial class EditFacility : Form
    {
        int id;
        FacilityController fc = new FacilityController();
        group8bEntities context = new group8bEntities();
        
        public EditFacility()
        {
            InitializeComponent();
        }
        
        //overload constructor for pass the value
        
        public EditFacility(int id,string sportid, string courtcode, string courtname, string description):this()
        {
            this.id= id;
            this.tbSID.Text = sportid;
            this.cbCourtCode.Text = courtcode;
            this.tbCN.Text = courtname;
            this.tbDES.Text = description;
 
        }
        //load

        private void EditFacility_Load(object sender, EventArgs e)
        {   
            var cn = (from c in context.Facilities select c).Distinct();
            foreach (App_Data.Facility f in cn.ToList())
            {
                cbCourtCode.Items.Add(f.CourtCode);
            }
        }

        //save
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            App_Data.Facility f = new App_Data.Facility();

            f.SportID = Convert.ToInt32(tbSID.Text);
            f.CourtCode = cbCourtCode.Text;
            f.CourtName = tbCN.Text;
            f.Description = tbDES.Text;


            fc.UpdateFacility(id, f);
            MessageBox.Show("Succesfully!");
            this.DialogResult = DialogResult.OK;
            
        }
        //Cancel

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


        
    }
}


 