using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Group8b
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMember emem = new EditMember();
            emem.ShowDialog();
        }
    }
}
