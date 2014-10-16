using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Group8b.App_Data;

namespace Group8b
{

    public partial class AddNewSlot : Form
    {
        SlotController sc = new SlotController();
        group8bEntities context = new group8bEntities();

        public AddNewSlot()
        {
            InitializeComponent();
        }

        private void btnAddNewSlot_Click(object sender, EventArgs e)
        {

            var query = from x in context.Slots
                        where x.FacilityID == Convert.ToInt32(textBoxANSFID.Text)
                        select x;

            App_Data.Slot s2 = new App_Data.Slot();

            s2.FacilityID = Convert.ToInt32(textBoxANSFID.Text);
            s2.TimeFrom = dateTimePicker1.Value.TimeOfDay;
            s2.TimeTo = dateTimePicker2.Value.TimeOfDay;

            context.AddToSlots(s2);
            context.SaveChanges();
            lblsuccess.Text = "Successfully!";
            this.Close();
        }

        private void AddNewSlot_Load(object sender, EventArgs e)
        {
            //var source = new AutoCompleteStringCollection();
            //var slotlist = sc.GetSlot();
            //foreach (App_Data.Slot s in slotlist)
            //{
            //    source.AddRange(new string[] { s.FacilityID + Environment.NewLine });
            //}

            //textBoxANSFID.AutoCompleteCustomSource = source;
            //textBoxANSFID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //textBoxANSFID.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfacid_Click(object sender, EventArgs e)
        {
            FacilityLookUp flu = new FacilityLookUp();
            DialogResult dr = flu.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBoxANSFID.Text = flu.FacilityID.ToString();
            }
            flu.Dispose();
        }
    }

}
