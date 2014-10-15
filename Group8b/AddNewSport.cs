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
    public partial class AddNewSport : Form
    {
        SportController sc = new SportController();


        public AddNewSport()
        {
            InitializeComponent();
        }

        private void btSve_Click(object sender, EventArgs e)
        {
            group8bEntities context = new group8bEntities();


            var q = from x in context.Sports
                    where x.Name == tbName.Text
                    select x;

            App_Data.Sport s = new App_Data.Sport();
            
            
            s.Name = tbName.Text;
            s.SportType = cbType.Text;
            s.Size = Convert.ToInt16 (tbSize.Text);
            s.Description = tbDes.Text;
            
            context.AddToSports(s);
            context.SaveChanges();
            MessageBox.Show("Successfully!");
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private void AddNewSport_Load(object sender, EventArgs e)
        {
            var source = new AutoCompleteStringCollection();
            var sportlist=sc.GetSports();
            foreach(App_Data.Sport s in sportlist )
            {
                source .AddRange (new string []{s.Name +Environment .NewLine });

            }
            tbName .AutoCompleteCustomSource =source ;
            tbName .AutoCompleteMode =AutoCompleteMode .SuggestAppend ;
            tbName .AutoCompleteSource =AutoCompleteSource.CustomSource;
            
        }
    }
}
