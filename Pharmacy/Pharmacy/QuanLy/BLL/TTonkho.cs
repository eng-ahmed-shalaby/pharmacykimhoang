using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Pharmacy.QuanLy.BLL
{
    class TTonkho
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        //Pharmacy.BLL.TDonVi tDonvi = new Pharmacy.BLL.TDonVi();
        //Pharmacy.BLL.TNhaCC tNCC = new Pharmacy.BLL.TNhaCC();
        //Pharmacy.BLL.TLoaiSP tLoaiSP = new Pharmacy.BLL.TLoaiSP();
        //Pharmacy.BLL.TQuycach tQuycach = new Pharmacy.BLL.TQuycach();
        //Pharmacy.BLL.TNhomHH tNHH = new Pharmacy.BLL.TNhomHH();
        //Pharmacy.BLL.THangHoa tHH = new Pharmacy.BLL.THangHoa();
        //Pharmacy.BLL.TQG tQG = new Pharmacy.BLL.TQG();
        //Pharmacy.BLL.TKho tKho = new Pharmacy.BLL.TKho();
        public DataTable GetKho_tonkho()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectKHO_Tonkho");
            return data;
        }
        public int InsertTonKho(Pharmacy.QuanLy.Info.TonkhoInfo info)
        {
            int id = 0;
            try
            {
                id = cn.ExecuteInsert("sp_InsertTONKHO",
                    new string[] { "@MAKHO", "@NGAY", "@TINHTRANG"},
                   new object[] { info.MAKHO, info.NGAY, info.TINHTRANG});
                return id;
            }
            catch (Exception ex)
            {
                //ghi log
                return id;
            }

        }

        public int InsertCTTonKho(Pharmacy.QuanLy.Info.CTTonkhoInfo info)
        {
            int id = 0;
            try
            {
                id = cn.ExecuteInsert("sp_InsertCT_TonKho",
                    new string[] { "@MAHH", "@MATONKHO", "@SOLUONGTON", "@TINHTRANG" },
                   new object[] { info.Mahh, info.Matonkho, info.Soluongton,1 });
                return id;
            }
            catch (Exception ex)
            {
                //ghi log
                return id;
            }
        }


    }

}
