using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class frmAbout : BASIC.frmChild
    {
        public frmAbout()
        {
            InitializeComponent();
            SetTitle("");
        }
        int i = 2;
        private void timer1_Tick(object sender, EventArgs e)
        {           
            lblLo.Left -= i;
            if (lblLo.Right < 0)
                lblLo.Left = 500;
            
        }

     
    }
}
