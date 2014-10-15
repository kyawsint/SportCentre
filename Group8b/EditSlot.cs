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
    public partial class EditSlot : Form
    {

        public int FacilityID;
        public DateTime TimeFrom;
        public DateTime TimeTo;

        public EditSlot()
        {
            InitializeComponent();
        }

        public void GetData(int facilityID,DateTime timeFrom,DateTime timeTo)
        {
            this.FacilityID = facilityID;
            this.TimeFrom = timeFrom;
            this.TimeTo = timeTo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            group8bEntities context = new group8bEntities();
            int fID = Convert.ToInt32(textBoxANSFID.Text);

            var query = from x in context.Slots
                        where x.FacilityID == fID
                        select x;

            App_Data.Slot s = query.First();
            s.FacilityID = Convert.ToInt32(textBoxANSFID.Text);
            s.TimeFrom = dateTimePicker1.Value.TimeOfDay;
            s.TimeTo = dateTimePicker2.Value.TimeOfDay;

            context.SaveChanges();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditSlot_Load(object sender, EventArgs e)
        {
            textBoxANSFID.Text = FacilityID.ToString();
            dateTimePicker1.Text = TimeFrom.ToString();
            dateTimePicker2.Text = TimeTo.ToString();
        }



    }
}
