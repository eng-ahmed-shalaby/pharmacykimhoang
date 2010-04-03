namespace Pharmacy.HeThong
{
    partial class frmPhanQuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lvTDV = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.grpQuyen = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lvChucNang = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdLuu = new DevComponents.DotNetBar.ButtonX();
            this.cmdBo = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.grpQuyen.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.groupPanel2);
            this.panel1.Controls.Add(this.grpQuyen);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 357);
            this.panel1.TabIndex = 5;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.lvTDV);
            this.groupPanel2.Location = new System.Drawing.Point(4, 4);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(354, 294);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 69;
            this.groupPanel2.Text = "Trình dược viên";
            // 
            // lvTDV
            // 
            // 
            // 
            // 
            this.lvTDV.Border.Class = "ListViewBorder";
            this.lvTDV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTDV.FullRowSelect = true;
            this.lvTDV.GridLines = true;
            this.lvTDV.Location = new System.Drawing.Point(3, 3);
            this.lvTDV.Name = "lvTDV";
            this.lvTDV.Size = new System.Drawing.Size(343, 245);
            this.lvTDV.TabIndex = 0;
            this.lvTDV.UseCompatibleStateImageBehavior = false;
            this.lvTDV.View = System.Windows.Forms.View.Details;
            this.lvTDV.SelectedIndexChanged += new System.EventHandler(this.lvTDV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã TDV";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            this.columnHeader3.Width = 214;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã";
            this.columnHeader4.Width = 0;
            // 
            // grpQuyen
            // 
            this.grpQuyen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpQuyen.BackColor = System.Drawing.Color.Transparent;
            this.grpQuyen.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpQuyen.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpQuyen.Controls.Add(this.lvChucNang);
            this.grpQuyen.Location = new System.Drawing.Point(376, 4);
            this.grpQuyen.Name = "grpQuyen";
            this.grpQuyen.Size = new System.Drawing.Size(374, 294);
            // 
            // 
            // 
            this.grpQuyen.Style.BackColor = System.Drawing.Color.Transparent;
            this.grpQuyen.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.grpQuyen.Style.BackColorGradientAngle = 90;
            this.grpQuyen.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpQuyen.Style.BorderBottomWidth = 1;
            this.grpQuyen.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpQuyen.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpQuyen.Style.BorderLeftWidth = 1;
            this.grpQuyen.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpQuyen.Style.BorderRightWidth = 1;
            this.grpQuyen.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpQuyen.Style.BorderTopWidth = 1;
            this.grpQuyen.Style.CornerDiameter = 4;
            this.grpQuyen.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpQuyen.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpQuyen.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpQuyen.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.grpQuyen.TabIndex = 70;
            this.grpQuyen.Text = "Quyền";
            // 
            // lvChucNang
            // 
            // 
            // 
            // 
            this.lvChucNang.Border.Class = "ListViewBorder";
            this.lvChucNang.CheckBoxes = true;
            this.lvChucNang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader6,
            this.columnHeader7});
            this.lvChucNang.FullRowSelect = true;
            this.lvChucNang.GridLines = true;
            this.lvChucNang.Location = new System.Drawing.Point(3, 3);
            this.lvChucNang.Name = "lvChucNang";
            this.lvChucNang.Size = new System.Drawing.Size(358, 245);
            this.lvChucNang.TabIndex = 0;
            this.lvChucNang.UseCompatibleStateImageBehavior = false;
            this.lvChucNang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quyền";
            this.columnHeader5.Width = 65;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "STT";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Chức Năng";
            this.columnHeader6.Width = 229;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ma";
            this.columnHeader7.Width = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.cmdLuu);
            this.panel5.Controls.Add(this.cmdBo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 330);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(753, 27);
            this.panel5.TabIndex = 57;
            // 
            // cmdLuu
            // 
            this.cmdLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdLuu.Location = new System.Drawing.Point(303, 1);
            this.cmdLuu.Margin = new System.Windows.Forms.Padding(0);
            this.cmdLuu.Name = "cmdLuu";
            this.cmdLuu.Size = new System.Drawing.Size(70, 25);
            this.cmdLuu.TabIndex = 55;
            this.cmdLuu.Text = "Lưu lại";
            this.cmdLuu.Click += new System.EventHandler(this.cmdLuu_Click);
            // 
            // cmdBo
            // 
            this.cmdBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdBo.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdBo.Location = new System.Drawing.Point(380, 1);
            this.cmdBo.Margin = new System.Windows.Forms.Padding(0);
            this.cmdBo.Name = "cmdBo";
            this.cmdBo.Size = new System.Drawing.Size(70, 25);
            this.cmdBo.TabIndex = 53;
            this.cmdBo.Text = "Bỏ";
            this.cmdBo.Click += new System.EventHandler(this.cmdBo_Click);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 401);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.grpQuyen.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.ButtonX cmdLuu;
        private DevComponents.DotNetBar.ButtonX cmdBo;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel grpQuyen;
        private DevComponents.DotNetBar.Controls.ListViewEx lvTDV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevComponents.DotNetBar.Controls.ListViewEx lvChucNang;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}