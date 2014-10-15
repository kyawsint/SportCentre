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
    public partial class AddNewFacility : Form
    {
        group8bEntities context = new group8bEntities();
        public AddNewFacility()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var q = from x in context.Facilities
                    where x.CourtName == tbCN.Text
                        select x;
            App_Data.Facility f = new App_Data.Facility();
            
            f.SportID = Convert.ToInt32(tbSID.Text);
            f.CourtCode = txtcourtcode.Text;
            f.CourtName = tbCN.Text;
            f.Description = tbDes.Text;
           
            context.AddToFacilities(f);
            context.SaveChanges();
            MessageBox.Show("Successfully added!");
            this.Close();
        }
        
          
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btLookUp_Click(object sender, EventArgs e)
        {
            SportLookUp ef = new SportLookUp();
            DialogResult r= ef.ShowDialog();
             if (r == System.Windows.Forms.DialogResult.OK)
           {
               tbSID.Text = ef.SportIDString;
              
           }

           ef.Dispose();
           
        }
       
    }
}
