using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Pharmacy.BASIC
{
    public partial class frmChild : DevComponents.DotNetBar.Office2007Form
    {
        public frmChild()
        {
            InitializeComponent();
        }
        public void SetTitle(string _title) {
            lblTitle.Text = _title;
        }
    }
}