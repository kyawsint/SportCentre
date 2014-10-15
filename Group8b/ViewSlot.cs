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
using System.Text.RegularExpressions;

namespace Group8b
{
    public partial class ViewSlot : Form
    {
        public int FacilityID;
        public DateTime TimeFrom;
        public DateTime TimeTo;

        SlotController sc = new SlotController();

        public ViewSlot()
        {
            InitializeComponent();
        }

        private void btnAddNewSlot_Click(object sender, EventArgs e)
        {
            AddNewSlot form_ans = new AddNewSlot();
            form_ans.Show();
        }

        private void btnEditSlot_Click(object sender, EventArgs e)
        {
            EditSlot es = new EditSlot();

            FacilityID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["FacilityID"].Value.ToString());
            TimeFrom = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["TimeFrom"].Value.ToString());
            TimeTo = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["TimeTo"].Value.ToString());
            es.GetData(FacilityID, TimeFrom, TimeTo);
            es.ShowDialog();
        }

        private void btnSearchSlot_Click(object sender, EventArgs e)
        {
            group8bEntities context = new group8bEntities();

            var q = from s in context.Slots
                    where s.Facility.CourtName == txtCourtname.Text
                    select s;
            //string fID = Convert.ToString(Regex.Split(textBox1.Text, "\r\n")[0]);
            //int facilityID = Convert.ToInt32(fID);
            //var q = from s in context.Slots
            //        where s.FacilityID == facilityID
            //        select s;

            dataGridView1.DataSource = q.ToList();
        }

        private void Slot_Load(object sender, EventArgs e)
        {
            group8bEntities ctx = new group8bEntities();
            var slotlist = sc.GetSlot();
            dataGridView1.DataSource = slotlist;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["facility"].Visible = false;
            dataGridView1.Columns["bookinginfoes"].Visible = false;

            var source = new AutoCompleteStringCollection();
            foreach (App_Data.Slot s in slotlist)
            {
                source.AddRange(new string[] { s.Facility.CourtName + Environment.NewLine });
            }

            txtCourtname.AutoCompleteCustomSource = source;
            txtCourtname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCourtname.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }


        private void btnDeleteSlot_Click(object sender, EventArgs e)
        {
            group8bEntities context3 = new group8bEntities();

            App_Data.Slot s = new App_Data.Slot();

            var q = from x in context3.Slots
                    where x.ID == Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString())
                    select x;
            s.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

            App_Data.Slot ss = context3.Slots.Where(p => p.ID == s.ID).Single();
            context3.Slots.DeleteObject(ss);
            context3.SaveChanges();
        }
    }

}
