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
    public partial class Enquiry : Form
    {
        
        public Enquiry()
        {
            InitializeComponent();
            group8bEntities entities = new group8bEntities();
            var sportname = from n in entities.Sports
                               group n by n.Name;
            foreach (var t in sportname)
            {
                comboBox1.Items.Add(t.Key);
            }

            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddHours(24);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
           
            
        }

        private void Enquiry_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedItem.ToString();
            DateTime time = dateTimePicker1.Value;
           Enquiry1 enquiry1 = new Enquiry1(str,time);
            enquiry1.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
