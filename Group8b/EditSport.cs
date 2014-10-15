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
    public partial class EditSport : Form
    {
        group8bEntities context = new group8bEntities();
        SportController sc = new SportController();
        int id;

        public EditSport()
        {
            InitializeComponent();
        }



        //overload constructor for pass the value
        public EditSport(int id, string name, string type, string size, string description)
            : this()
        {
            this.id = id;
            this.tbnName.Text = name;
            this.cbType.Text = type;
            this.tbnSize.Text = size;
            this.tbnDes.Text = description;
 
        }

        //load
        private void EditSport_Load(object sender, EventArgs e)
        {


            var cn = (from c in context.Sports select c).Distinct();
            foreach (App_Data.Sport s in cn.ToList())
            {
                cbType.Items.Add(s.SportType);
            }
        }

        //save

        private void tbnSave_Click(object sender, EventArgs e)
        {
          

            App_Data.Sport s = new App_Data.Sport();

            s.Name = tbnName.Text;
            s.SportType = cbType.Text;
            s.Size = Convert.ToInt16(tbnSize.Text);
            s.Description = tbnDes.Text;

            
            sc.UpdateSport(id, s);
            MessageBox.Show("Succesfully!");
            this.DialogResult = DialogResult.OK;
        }



        //cancle
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}
