﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Group8b
{
    public partial class Sport : Form
    {
        public Sport()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSport esport = new EditSport();
            esport.ShowDialog();
        }
    }
}
