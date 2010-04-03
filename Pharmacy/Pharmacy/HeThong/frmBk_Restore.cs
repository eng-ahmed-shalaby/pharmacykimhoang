using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Common;
namespace Pharmacy.HeThong
{
    public partial class frmBk_Restore : BASIC.frmChild
    {
        public frmBk_Restore()
        {
            InitializeComponent();
        }
        public void LoadServer() {
            DataTable dtServers = SmoApplication.EnumAvailableSqlServers(true);
            // If there are any servers at all
            if (dtServers.Rows.Count > 0)
            {
                // Loop through each server in the DataTable
                foreach (DataRow drServer in dtServers.Rows)
                {
                    // Add the name to the combobox
                    cmbNameSer.Items.Add(drServer["Name"]);
                }
            }
        }

        private void frmBk_Restore_Load(object sender, EventArgs e)
        {
            SetTitle("LƯU TRỮ DỮ LIỆU");
            LoadServer();
            
        }

        private void cmdback_Click(object sender, EventArgs e)
        {
            BLL.TBackupRestore tbak = new HeThong.BLL.TBackupRestore(cmbNameSer.Text, txtDB.Text, txtUser.Text, txtPass.Text);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (tbak.BackUp(saveFileDialog1.FileName))
                MessageBox.Show("Thành công");
                else 
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            BLL.TBackupRestore tbak = new HeThong.BLL.TBackupRestore(cmbNameSer.Text, txtDB.Text, txtUser.Text, txtPass.Text);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (tbak.Restore(openFileDialog1.FileName))
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

    }
}
