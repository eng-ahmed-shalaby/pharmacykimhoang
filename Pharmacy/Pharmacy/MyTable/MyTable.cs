using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Pharmacy.MyTable
{
   public static class MyTableConfig
    {
       public static string ConectionString = ConfigurationManager.AppSettings.Get("LocalConnection").Trim(); 
      
    }
   public class MyTable : DataTable 
   {
       #region "Local"
       private SqlDataAdapter _Adapter;
       private string _SelectSQL;
       private string _TableName;
       private static SqlConnection _Conection;
       private bool _GetAutoNumber = false;
       #endregion

       #region "Property"
       protected SqlDataAdapter Adapter
       {
           get { return _Adapter; }
           set { _Adapter = value; }
       }

       /// <summary>
       /// Câu lệnh cần truy vấn trên bảng
       /// Ex: Select * From Production
       /// </summary>
       public string SelectSQL
       {
           get { return _SelectSQL; }
           set { _SelectSQL = value; }
       }
       /// <summary>
       /// Tên bảng trong cơ sở dữ liệu
       /// >>> Chú ý: Phải đặt đúng tên bảng trong CSDL
       /// Ex: Production
       /// </summary>
       public string TableName
       {
           get { return _TableName; }
           set { _TableName = value; }
       }

       public bool GetAutoNumber
       {
           get { return _GetAutoNumber; }
           set { _GetAutoNumber = value; }
       }

       /// <summary>
       /// Kết nối dùng để truy xuất cơ sở dữ liệu
       /// >>>Tự động mở khi cần
       /// </summary>
       public static SqlConnection Conection
       {
           get
           {
               if (_Conection == null)
               {
                   _Conection = new SqlConnection();
                   _Conection.ConnectionString = MyTableConfig.ConectionString;
               }
               if (_Conection.State == ConnectionState.Closed)
               {
                   _Conection.Open();
               }
               return _Conection;
           }
           set { _Conection = value; }
       }

       /// <summary>
       /// Số mẫu tin có trong bảng
       /// </summary>
       public int RowCount
       {
           get
           {
               int ret = 0;
               try
               {
                   ret = this.DefaultView.Count;
               }
               catch (Exception ex)
               {
                   TLog.WriteErr("MyTable:ReadData()", ex.Message);
               }
               return ret;
           }
       }
       #endregion
       #region "Contructor"
       public MyTable()
           : base()
       {
       }
       public MyTable(string pTableName)
           : base(pTableName)
       {
           TableName = pTableName;
           ReadData();
       }
       public MyTable(string pTableName, string pSelectSQL)
           : base(pTableName)
       {
           TableName = pTableName;
           SelectSQL = pSelectSQL;
           ReadData();
       }
       #endregion
       #region "Input Group"
       /// <summary>
       /// Đọc dữ liệu từ Database
       /// </summary>
       /// <returns></returns>
       private DataTable ReadData()
       {
           if (string.IsNullOrEmpty(SelectSQL)) SelectSQL = "Select * From " + TableName;
           try
           {
               Adapter = new SqlDataAdapter(SelectSQL, Conection);
               Adapter.Fill(this);
               Adapter.FillSchema(this, SchemaType.Mapped);
               Adapter.RowUpdated += RowUpdated;

               Adapter.SelectCommand.CommandText = "Select * From " + TableName;
               SqlCommandBuilder myBuilder = new SqlCommandBuilder(Adapter);
               return this;
           }
           catch (SqlException ex)
           {
               TLog.WriteErr("MyTable:ReadData()", ex.Message);
               return null;
           }
       }
       #endregion
       #region "Update Group"
       /// <summary>
       /// Ghi dữ liệu từ Datatable xuống Database
       /// </summary>
       /// <returns></returns>
       public bool Update()
       {
           bool ret = true;
           try
           {
               Adapter.Update(this);
               this.AcceptChanges();
           }
           catch (Exception ex)
           {
               TLog.WriteErr("MyTable:Update()", ex.Message);
               this.RejectChanges();
               ret = false;
           }
           return ret;
       }
       public bool Update(bool pGetAutoNumber)
       {
           GetAutoNumber = pGetAutoNumber;
           return Update();
       }
       public bool UpdateAdd()
       {
           bool ret = true;
           try
           {
               Adapter.Update(this);
               this.AcceptChanges();

               //Lay gia tri AutoNumber mới vừa thêm >>> cập nhật vào DataTable
               if (this.PrimaryKey[0].AutoIncrement)
               {
                   SqlCommand cmd = new SqlCommand("Select @@IDENTITY", Conection);
                   this.Rows[RowCount - 1][0] = cmd.ExecuteScalar();
                   this.AcceptChanges();
               }
           }

           catch (Exception ex)
           {
               TLog.WriteErr("", ex.Message);
               this.RejectChanges();
               ret = false;
           }
           return ret;
       }
       public void Filter(string pCondition)
       {
           try
           {
               this.DefaultView.RowFilter = pCondition;
           }
           catch (Exception ex)
           {
               TLog.WriteErr("MyTable:Filter()", ex.Message);
           }
       }
       #endregion
       #region "Action Group"
       public static int ExecuteNonQuery(string pNonQuery)
       {
           int ret = -1;
           try
           {
               SqlCommand myCommand = new SqlCommand(pNonQuery, Conection);
               if (Conection.State == ConnectionState.Closed)
                   Conection.Open();

               ret = myCommand.ExecuteNonQuery();
               Conection.Close();
               return ret;
           }

           catch (SqlException ex)
           {
               TLog.WriteErr("MyTable:ExecuteNonQuery()", ex.Message);
               if (Conection.State == ConnectionState.Open)
                   Conection.Close();
           }
           return ret;
       }
       public static object ExecuteScalar(string pScalarQuery)
       {
           object ret = null;
           try
           {
               SqlCommand myCommand = new SqlCommand(pScalarQuery, Conection);
               if (Conection.State == ConnectionState.Closed)
                   Conection.Open();
               ret = myCommand.ExecuteScalar();
               Conection.Close();
               return ret;
           }

           catch (SqlException ex)
           {
               TLog.WriteErr("MyTable:ExecuteScalar()", ex.Message);
               if (Conection.State == ConnectionState.Open)
                   Conection.Close();
           }
           return ret;
       }
       #endregion
       #region "Xử lý sự kiện"
       private void RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
       {
           if (GetAutoNumber)
           {
               if (e.Status == UpdateStatus.Continue & e.StatementType == StatementType.Insert)
               {
                   try
                   {
                       //Lay gia tri AutoNumber ID
                       if (this.PrimaryKey[0].AutoIncrement)
                       {
                           SqlCommand cmd = new SqlCommand("Select @@IDENTITY", Conection);
                           e.Row.Table.Columns[0].ReadOnly = false;

                           Object retID = cmd.ExecuteScalar();
                           if (retID != null)
                           {
                               e.Row[0] = Convert.ToInt16(retID);
                               e.Row.AcceptChanges();
                           }
                       }
                   }
                   catch (Exception ex)
                   {
                       TLog.WriteErr("MyTable:RowUpdated()", ex.Message);
                   }
               }
           }
       }
       #endregion
   }
}
