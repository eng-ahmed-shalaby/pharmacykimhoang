﻿namespace Pharmacy.QuanLy
{
    partial class frmTinhThanh
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
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdSuaNhom = new DevComponents.DotNetBar.ButtonX();
            this.cmdXoaNhom = new DevComponents.DotNetBar.ButtonX();
            this.cmdThemNhom = new DevComponents.DotNetBar.ButtonX();
            this.txtten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmdIn = new DevComponents.DotNetBar.ButtonX();
            this.lvTinhThanh = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.groupPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtMa);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.panel5);
            this.groupPanel2.Controls.Add(this.txtten);
            this.groupPanel2.Controls.Add(this.labelX26);
            this.groupPanel2.Location = new System.Drawing.Point(190, 38);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(388, 129);
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
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "THÔNG TIN TỈNH THÀNH";
            // 
            // txtMa
            // 
            // 
            // 
            // 
            this.txtMa.Border.Class = "TextBoxBorder";
            this.txtMa.FocusHighlightEnabled = true;
            this.txtMa.Location = new System.Drawing.Point(70, 5);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(238, 24);
            this.txtMa.TabIndex = 75;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(5, 6);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(80, 30);
            this.labelX2.TabIndex = 74;
            this.labelX2.Text = "Mã:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.cmdSuaNhom);
            this.panel5.Controls.Add(this.cmdXoaNhom);
            this.panel5.Controls.Add(this.cmdThemNhom);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 75);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(382, 29);
            this.panel5.TabIndex = 70;
            // 
            // cmdSuaNhom
            // 
            this.cmdSuaNhom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdSuaNhom.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdSuaNhom.Location = new System.Drawing.Point(156, 2);
            this.cmdSuaNhom.Margin = new System.Windows.Forms.Padding(0);
            this.cmdSuaNhom.Name = "cmdSuaNhom";
            this.cmdSuaNhom.Size = new System.Drawing.Size(70, 25);
            this.cmdSuaNhom.TabIndex = 1;
            this.cmdSuaNhom.Text = "&Sửa";
            this.cmdSuaNhom.Click += new System.EventHandler(this.cmdSuaNhom_Click);
            // 
            // cmdXoaNhom
            // 
            this.cmdXoaNhom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdXoaNhom.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdXoaNhom.Location = new System.Drawing.Point(238, 2);
            this.cmdXoaNhom.Margin = new System.Windows.Forms.Padding(0);
            this.cmdXoaNhom.Name = "cmdXoaNhom";
            this.cmdXoaNhom.Size = new System.Drawing.Size(70, 25);
            this.cmdXoaNhom.TabIndex = 2;
            this.cmdXoaNhom.Text = "&Xóa";
            this.cmdXoaNhom.Click += new System.EventHandler(this.cmdXoaNhom_Click);
            // 
            // cmdThemNhom
            // 
            this.cmdThemNhom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdThemNhom.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdThemNhom.Location = new System.Drawing.Point(73, 2);
            this.cmdThemNhom.Margin = new System.Windows.Forms.Padding(0);
            this.cmdThemNhom.Name = "cmdThemNhom";
            this.cmdThemNhom.Size = new System.Drawing.Size(70, 25);
            this.cmdThemNhom.TabIndex = 0;
            this.cmdThemNhom.Text = "&Thêm";
            this.cmdThemNhom.Click += new System.EventHandler(this.cmdThemNhom_Click);
            // 
            // txtten
            // 
            // 
            // 
            // 
            this.txtten.Border.Class = "TextBoxBorder";
            this.txtten.FocusHighlightEnabled = true;
            this.txtten.Location = new System.Drawing.Point(70, 40);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(238, 24);
            this.txtten.TabIndex = 1;
            // 
            // labelX26
            // 
            this.labelX26.Location = new System.Drawing.Point(3, 40);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(51, 25);
            this.labelX26.TabIndex = 60;
            this.labelX26.Text = "Tên:";
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmdIn);
            this.groupPanel1.Controls.Add(this.lvTinhThanh);
            this.groupPanel1.Location = new System.Drawing.Point(14, 173);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(703, 345);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 78;
            this.groupPanel1.Text = "DANH SÁCH TỈNH THÀNH";
            // 
            // cmdIn
            // 
            this.cmdIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdIn.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdIn.Location = new System.Drawing.Point(7, 295);
            this.cmdIn.Margin = new System.Windows.Forms.Padding(0);
            this.cmdIn.Name = "cmdIn";
            this.cmdIn.Size = new System.Drawing.Size(70, 25);
            this.cmdIn.TabIndex = 72;
            this.cmdIn.Text = "&In ";
            this.cmdIn.Click += new System.EventHandler(this.cmdIn_Click);
            // 
            // lvTinhThanh
            // 
            this.lvTinhThanh.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.lvTinhThanh.Border.Class = "ListViewBorder";
            this.lvTinhThanh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader4});
            this.lvTinhThanh.FullRowSelect = true;
            this.lvTinhThanh.GridLines = true;
            this.lvTinhThanh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTinhThanh.Location = new System.Drawing.Point(7, 3);
            this.lvTinhThanh.Name = "lvTinhThanh";
            this.lvTinhThanh.Size = new System.Drawing.Size(687, 289);
            this.lvTinhThanh.TabIndex = 71;
            this.lvTinhThanh.UseCompatibleStateImageBehavior = false;
            this.lvTinhThanh.View = System.Windows.Forms.View.Details;
            this.lvTinhThanh.SelectedIndexChanged += new System.EventHandler(this.lvTinhThanh_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STT";
            this.columnHeader7.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã";
            this.columnHeader2.Width = 302;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên";
            this.columnHeader4.Width = 298;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // frmTinhThanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 530);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.Name = "frmTinhThanh";
            this.Text = "Quản lý nhóm hàng hóa";
            this.Controls.SetChildIndex(this.groupPanel2, 0);
            this.Controls.SetChildIndex(this.groupPanel1, 0);
            this.groupPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.ButtonX cmdSuaNhom;
        private DevComponents.DotNetBar.ButtonX cmdXoaNhom;
        private DevComponents.DotNetBar.ButtonX cmdThemNhom;
        private DevComponents.DotNetBar.Controls.TextBoxX txtten;
        private DevComponents.DotNetBar.LabelX labelX26;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ListViewEx lvTinhThanh;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX cmdIn;
        private System.Drawing.Printing.PrintDocument printDoc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMa;
    }
}