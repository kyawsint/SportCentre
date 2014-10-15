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
    public partial class ViewSport : Form
    {
        
        group8bEntities context = new group8bEntities();
        SportController sc = new SportController();

        int id;
        string name;
        string size;
        string type;
        string description;
        
            
        public ViewSport()
        {
            InitializeComponent();
            ShowSports();
        }



        private void Sport_Load(object sender, EventArgs e)
        {
            var sn = (from c in context.Sports select c).Distinct();
            foreach (App_Data.Sport s in sn.ToList())
            {
                cbSportName.Items.Add(s.Name);
            }
            ShowSports();
        }

        private void ShowSports()
        {
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataSource = sc.GetSports();
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["BookingInfoes"].Visible = false;
            dataGridView1.Columns["Facilities"].Visible = false;
            dataGridView1.Refresh();
        }

        //Edit
        private void btEdit_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            type = dataGridView1.CurrentRow.Cells["SportType"].Value.ToString();
            size = dataGridView1.CurrentRow.Cells["Size"].Value.ToString();
            description = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            EditSport esport = new EditSport(id, name,type,size,description);
            DialogResult dr = esport.ShowDialog();
       
            if (dr == DialogResult.OK)
                ShowSports();
            esport.Dispose();
        }

       //Add new sport 

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddNewSport f = new AddNewSport();

            DialogResult r = f.ShowDialog();
        }

        //search
        private void cbSportName_SelectedIndexChanged(object sender, EventArgs e)
        {
           Search();
        }

        private void Search()
        {
            var q = from x in context.Sports
                   where x.Name == cbSportName.Text
                    select x;

            dataGridView1.DataSource = q.ToList();
        }



        //Delete
        private void btDelete_Click(object sender, EventArgs e)
        {
           
            App_Data.Sport s = new App_Data.Sport();
                  
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            
            sc.DeleteSport(id, s);
            MessageBox.Show("Succesfully!");
            this.DialogResult = DialogResult.OK;
        }

        

       
    }
}
