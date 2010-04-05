using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.HeThong
{
    public partial class frmExport : BASIC.frmChild
    {
        public frmExport()
        {
            InitializeComponent();
        }
        DataTable datatable1 = new DataTable();
        private void frmExport_Load(object sender, EventArgs e)
        {

            initData();
           // Export2Word();
            ExpExce();
        }
        // Tạo một nguồn dữ liệu (ví dụ Datatable) để kết xuất ra word.
        void initData()
        {
            DataColumn Col1 = new DataColumn("STT", System.Type.GetType("System.Int16"));
            datatable1.Columns.Add(Col1);

            DataColumn Col2 = new DataColumn("HoTen", System.Type.GetType("System.String"));
            datatable1.Columns.Add(Col2);

            for (int i = 1; i <= 100; i++)
            {
                DataRow row = datatable1.NewRow();
                row["STT"] = i;
                row["HoTen"] = "Sinh vien " + i.ToString();
                datatable1.Rows.Add(row);
            }
        }

      

        // Hiển thị dữ liệu nguồn ra màn hình để quan sát.
      
        //Thực hiện Export dữ liệu trong datatable ra MS word
        void Export2Word()
        {
            //Tạo các đối tượng application, document, table của MS Word
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc;
            Microsoft.Office.Interop.Word.Table table;

            //Hiện (mở) ứng dụng word
            app.Visible = true;

            //Tham số truyền vào các hàm có đối là tuỳ chọn
            object obj = Type.Missing;

            //Tạo một tài liệu mới (để chứa dữ liệu xuất ra)
            doc = app.Documents.Add(ref obj, ref obj, ref obj, ref obj);
            Microsoft.Office.Interop.Word.Range range = doc.Range(ref obj, ref obj);

            //Thêm một bảng có 2 cột và số hàng bằng với số hàng trong datatable.
            table = doc.Tables.Add(range, datatable1.Rows.Count, 2, ref obj, ref obj);

            //Xuất dữ liệu từ datatable sang bảng (trong word). Chú ý: đối với các đối tượng tập hợp
            // trong word thì phần tử đầu tiên có chỉ số là 1 thay vì 0 như trong C#
            for (int i = 0; i < datatable1.Rows.Count; i++)
            {
                doc.Tables[1].Rows[i + 1].Cells[1].Range.Text = datatable1.Rows[i]["STT"].ToString();
                doc.Tables[1].Rows[i + 1].Cells[2].Range.Text = datatable1.Rows[i]["HoTen"].ToString();
            }

            //Thêm đường viền cho Table nếu cần.
            doc.Select();
            Microsoft.Office.Interop.Word.WdLineStyle BorderValue = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
            app.Selection.Borders[Microsoft.Office.Interop.Word.WdBorderType.wdBorderTop].LineStyle = BorderValue;
            app.Selection.Borders[Microsoft.Office.Interop.Word.WdBorderType.wdBorderBottom].LineStyle = BorderValue;
            app.Selection.Borders[Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft].LineStyle = BorderValue;
            app.Selection.Borders[Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight].LineStyle = BorderValue;
            app.Selection.Borders[Microsoft.Office.Interop.Word.WdBorderType.wdBorderVertical].LineStyle = BorderValue;
            app.Selection.Borders[Microsoft.Office.Interop.Word.WdBorderType.wdBorderHorizontal].LineStyle = BorderValue;
        }

        public void ExpExce() {

//            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();

//// Thêm file temp xls
//            Microsoft.Office.Interop.Excel.Workbook exBook = (Microsoft.Office.Interop.Excel.Workbook)(Microsoft.Office.Interop.Excel.Workbooks.Add());

//// Lấy sheet 1.
//            Microsoft.Office.Interop.Excel.Worksheet exSheet = (Microsoft.Office.Interop.Excel.Worksheet)exBook.Worksheets[1];

//            string workbookPath = "c:/SomeWorkBook.xls";

//           exBook = exApp.Workbooks.Open(workbookPath,
//                    0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "",
//                    true, false, 0, true, false, false);
//            exSheet.Activate();
//            exSheet.Name = "Export Data Sheet";

//            Microsoft.Office.Interop.Excel.Range r = (Microsoft.Office.Interop.Excel.Range)exSheet.get_Range("A1", "A4");
//            r.Value2 = "My Value";
//            r.Columns.AutoFit();

//            exBook.SaveAs("C:\\file.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
//                null,null,false,false,
//                 Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
//                false,false,false,false,false);
//exApp.Quit();

        }
    }
}
