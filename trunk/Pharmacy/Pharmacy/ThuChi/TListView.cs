using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Pharmacy.ThuChi
{
    class TListView: DevComponents.DotNetBar.Controls.ListViewEx
    {
        private ListViewItem li;
		public int X=0;
		private int Y=0;
		private string subItemText ;
		private int subItemSelected = 0 ;
        private DevComponents.DotNetBar.Controls.TextBoxX editBox = new DevComponents.DotNetBar.Controls.TextBoxX();
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
        private float TienNo;
        int colName;
        public TListView()
		{

           this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();

			this.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																			this.columnHeader1,
																			this.columnHeader2,
																			this.columnHeader3,
																			this.columnHeader4});
			//this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FullRowSelect = true;
			this.Name = "listView1";
			this.Size = new System.Drawing.Size(0,0);
			this.TabIndex = 0;
			this.View = System.Windows.Forms.View.Details;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SMKMouseDown);
			this.DoubleClick += new System.EventHandler(this.SMKDoubleClick);
			this.GridLines = true ;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số HD";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Trả";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Còn Lại";
			this.columnHeader4.Width = 100;

			editBox.Size  = new System.Drawing.Size(0,0);
			editBox.Location = new System.Drawing.Point(0,0);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.editBox});			
			editBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditOver);
			editBox.LostFocus += new System.EventHandler(this.FocusOver);
			editBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			editBox.BackColor = Color.LightYellow; 
			editBox.BorderStyle = BorderStyle.Fixed3D;
			editBox.Hide();
			editBox.Text = "";
		}
		private void EditOver(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ( e.KeyChar == 13 ) 
			{
				li.SubItems[subItemSelected].Text = editBox.Text;
				editBox.Hide();
			}

			if ( e.KeyChar == 27 ) 
				editBox.Hide();
		}

		private void FocusOver(object sender, System.EventArgs e)
		{
           // TienNo =float.Parse(li.SubItems[subItemSelected+1].Text)+ float.Parse(li.SubItems[subItemSelected].Text);
            if (colName == 2)
            {
                try
                {
                    li.SubItems[subItemSelected].Text = editBox.Text;
                    li.SubItems[subItemSelected + 1].Text = (TienNo - float.Parse(editBox.Text)).ToString();
                
                }
                catch(Exception ex) {
                    TLog.WriteLog("TListView_FocusOver", ex.Message); 
               }
            }editBox.Hide();
                
		}

		public  void SMKDoubleClick(object sender, System.EventArgs e)
		{

			// Check the subitem clicked .
			int nStart = X ;
			int spos = 0 ; 
			int epos = this.Columns[0].Width ;
			for ( int i=0; i < this.Columns.Count ; i++)
			{
				if ( nStart > spos && nStart < epos ) 
				{
					subItemSelected = i ;
					break; 
				}
				
				spos = epos ; 
				epos += this.Columns[i].Width;
			}

			Console.WriteLine("SUB ITEM SELECTED = " + li.SubItems[subItemSelected].Text);
			subItemText = li.SubItems[subItemSelected].Text ;
            colName = this.Columns[subItemSelected].Index ;
			if ( colName == 2 ) 
			{
                TienNo = float.Parse(li.SubItems[subItemSelected + 1].Text) + float.Parse(li.SubItems[subItemSelected].Text);
                Rectangle r = new Rectangle(spos, li.Bounds.Y, epos, li.Bounds.Bottom);
                editBox.Size = new System.Drawing.Size(epos - spos, li.Bounds.Bottom - li.Bounds.Top);
                editBox.Location = new System.Drawing.Point(spos, li.Bounds.Y);
                editBox.Show();
                editBox.Text = subItemText;
                editBox.SelectAll();
                editBox.Focus();
			}
			else
			{
		//////////////////////////////////
                return;
			}
		}

		public void SMKMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			li = this.GetItemAt(e.X , e.Y);
			X = e.X ;
			Y = e.Y ;
		}
    }
}
