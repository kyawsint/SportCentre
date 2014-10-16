using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Group8b.App_Data;

namespace Group8b
{
    public partial class Enquiry1 : Form
    {

        public Enquiry1(string str, DateTime time)
            : this()
        {
            this.label6.Text = str;
            label8.Text = time.DayOfWeek.ToString() + "," + time.ToShortDateString();

            List<App_Data.Facility> infos = new List<App_Data.Facility>();
            group8bEntities entities = new group8bEntities();

            int buttonWidth = 60;
            int buttonHeight = 23;
            int startX = 100;
            int startY = 100;

            Button b = null;

            Label label = null;
            DateTime today = DateTime.Today;

            int currentX = 200;
            int currentY = 120;
            int startTime = 9;
            //time
            for (int i = 0; i < 10; i++)
            {
                currentX = startX + i * buttonWidth;
                currentY = startY - buttonHeight;
                label = new Label();
                label.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                label.Text = startTime++ + ":00";

                label.Location = new System.Drawing.Point(currentX, currentY);
                this.panel1.Controls.Add(label);
            }


            var sport = entities.Sports.First(x => x.Name==str);
            int number = sport.ID;
          

            var court = from x in entities.Facilities
                        where x.SportID == number
                        select x;


            int k = 0;
            //courtname
            foreach (var j in court)
            {
                currentX = startX - buttonWidth;
                currentY = startY + k * buttonHeight;
                label = new Label();
                label.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                label.Text = j.CourtName;
                label.Location = new System.Drawing.Point(currentX, currentY);
                this.panel1.Controls.Add(label);
                k++;
            }


           

            var faci = entities.Facilities.First(x => x.SportID == number);
            //button
            int t = (int)faci.ID-1;
                for (int i = 0; i < k; i++)
                {
                    
                    t++;
                    var status = from n in entities.BookingInfoes
                                 where n.SportID == number && n.FacilityID == t
                                 select n;

                    //time
                    for (int j = 0; j <10; j++)
                    { 

                        currentX = startX + j * buttonWidth;
                        currentY = startY + i* buttonHeight;
                        b = new Button();
                        b.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                        b.BackColor = Color.White;
                        b.Location = new System.Drawing.Point(currentX, currentY);
                        this.panel1.Controls.Add(b);
                        b.BackColor = Color.Lavender;

                        foreach (var t2 in status)
                        {

                            if (t2.DateIssue.ToShortDateString() == time.ToShortDateString()
                               && t2.SlotID == j + 1 && t2.SportID == number)
                            {
                                b.Text = t2.Status;
                                
                                if (t2.Status == "available")
                                { 
                                    b.BackColor = Color.Tomato;
                                }
                                if (t2.Status == "comfirmed")
                                {
                                    b.BackColor = Color.GreenYellow;
                                }
                                b.Enabled = false;
                            }

        


                        }
                    }
                }
        

}
        
        

        public Enquiry1()
        {
           
        
            InitializeComponent();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Enquiry1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
