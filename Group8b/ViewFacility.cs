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
    public partial class ViewFacility : Form
    {
        FacilityController  fc = new FacilityController();
        group8bEntities context = new group8bEntities();
        
        int id;  
        string sportid;
        string courtcode;
        string courtname;
        string description;
        
        
        public ViewFacility()
        {
            InitializeComponent();
            ShowFacility();
        }
       
        //load      

        private void Facility_Load(object sender, EventArgs e)
        {
            var cn = (from c in context.Facilities select c).Distinct();
            foreach (App_Data.Facility f in cn.ToList())
            {
                cbcourtname.Items.Add(f.CourtName);
            }

            ShowFacility();
        
        }

        private void ShowFacility()
        {
            dataGridView1.DataSource = fc.GetFacilities();
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["BookingInfoes"].Visible = false;
            dataGridView1.Columns["Sport"].Visible = false;
            dataGridView1.Columns["Slots"].Visible = false;
        }
        
        //Edit

        private void btEdit_Click(object sender, EventArgs e)
        {
            id = Convert .ToInt32 (dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            sportid = dataGridView1.CurrentRow.Cells["SportID"].Value.ToString();
            courtcode = dataGridView1.CurrentRow.Cells["CourtCode"].Value.ToString();
            courtname = dataGridView1.CurrentRow.Cells["CourtName"].Value.ToString();
            description = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();

            EditFacility ef = new EditFacility(id,sportid,courtcode,courtname,description);
            DialogResult dr= ef.ShowDialog();

            if (dr == DialogResult.OK)
                ShowFacility();
            

            ef.Dispose();
            
        }
        
        //Add new Facility
        
        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddNewFacility f = new AddNewFacility();

            DialogResult r = f.ShowDialog();
        }




        //Search

        private void cbcourtname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            var q = from x in context.Facilities
                    where x.CourtName == cbcourtname.Text
                    select x;

            dataGridView1.DataSource = q.ToList();
        }




        //Delete
        private void btDelete_Click(object sender, EventArgs e)
        { 
            App_Data.Facility f = new App_Data.Facility();
            
           
            id= Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            

            
            fc.DeleteFacility(id, f);
            MessageBox.Show("Succesfully!");
            this.DialogResult = DialogResult.OK;


        }

        

        

        

        

        
        

       
    }
}
