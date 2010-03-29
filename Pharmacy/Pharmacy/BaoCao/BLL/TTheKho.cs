using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BaoCao.BLL
{
    class TTheokho
    {
        Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
        DataTable data = new DataTable();
        DataTable dataSQL = new DataTable();
        public TTheokho()
        {
            DataColumn[] dc = new DataColumn[]{ 
                               new DataColumn("SoDK", Type.GetType("System.String")),
                              
                               new DataColumn("TenHH", Type.GetType("System.String")),
                               new DataColumn("QuyCach", Type.GetType("System.String")),
                               new DataColumn("SoLo", Type.GetType("System.String")),
                               new DataColumn("DVT", Type.GetType("System.String")),
                               new DataColumn("HanDung", Type.GetType("System.String")),
                               new DataColumn("NgayThang", Type.GetType("System.String")),

                               new DataColumn("PhieuNhap", Type.GetType("System.String")),
                                new DataColumn("PhieuXuat", Type.GetType("System.String")),
                               new DataColumn("DienGiai", Type.GetType("System.String")),
                               new DataColumn("SLNhap", Type.GetType("System.String")),
                                new DataColumn("SLXuat", Type.GetType("System.String")),
                                 new DataColumn("SLTon", Type.GetType("System.String")),
                                  new DataColumn("GhiChu", Type.GetType("System.String"))

            };
            data.Columns.AddRange(dc);

        }
        public DataTable GetXuat(int MaHH, int MaKho, DateTime from, DateTime to)
        {
            DataTable data = connect.GetDataByStoredProcedure("sp_thekho",
               new string[] { "@mahh", "@makho","@tungay","@denngay" },
               new object[] { MaHH, MaKho,from ,to }
                );
            return data;
        }
        public DataTable SetData(int MaHH, int MaKho, DateTime from, DateTime to)
        {
            int i = 0;
            dataSQL = GetXuat(MaHH,MaKho,from, to);
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {
                DataRow r = data.NewRow();
                r["SoDK"]= dataSQL.Rows[i]["sodk"];
                r["TenHH"]= dataSQL.Rows[i]["tenhang"];
                r["QuyCach"]= dataSQL.Rows[i]["quycach"];
                r["SoLo"]= dataSQL.Rows[i]["solo"]; 
                r["DVT"]= dataSQL.Rows[i]["donvitinh"]; 
                r["HanDung"]= dataSQL.Rows[i]["handung"];
                r["NgayThang"]= dataSQL.Rows[i]["ngay"];
                r["PhieuNhap"]= dataSQL.Rows[i]["hdnhap"];
                r["PhieuXuat"]= dataSQL.Rows[i]["hdxuat"];
                r["DienGiai"]= dataSQL.Rows[i]["diengiai"]; 
                r["SLNhap"]= dataSQL.Rows[i]["nhap"]; 
                r["SLXuat"]= dataSQL.Rows[i]["xuat"];
                r["SLTon"]= dataSQL.Rows[i]["ton"];
                r["GhiChu"]= dataSQL.Rows[i]["ghichu"];

                data.Rows.Add(r);
            }
            return data;
        }
    }
}
