using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy.DLL
{
    class DataAccess
    {
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        private SqlDataAdapter _sqlDataAdapter;
        private string _strConnectionString = "";
        private UTLXML _xml;
        private string path = string.Empty;

        public DataAccess()
        {
            path = Application.StartupPath + "\\App.config";
            _xml = new UTLXML(path);
            _strConnectionString = _xml.ReadTagInfor("LocalConnection");
            _sqlCommand = new SqlCommand();
            _sqlDataAdapter = new SqlDataAdapter();
            _sqlConnection = new SqlConnection();

        }

        public string ConnectionString
        {
            get
            {
                if (_xml.ReadTagInfor("OptionConnection").Equals("2"))
                {
                    _strConnectionString = "Server = ";
                    _strConnectionString += _xml.ReadTagInfor("Server");
                    _strConnectionString += ";Database = ";
                    _strConnectionString += _xml.ReadTagInfor("DataBase");
                    _strConnectionString += ";User ID = ";
                    _strConnectionString += _xml.ReadTagInfor("UserID");
                    _strConnectionString += ";Password = ";
                    _strConnectionString += _xml.ReadTagInfor("Password");
                    _strConnectionString += ";Trusted_Connection = ";
                    _strConnectionString += _xml.ReadTagInfor("Trusted_Connection");
                    _strConnectionString += ";";
                    return _strConnectionString;
                }
                else
                {
                    return _xml.ReadTagInfor("LocalConnection");
                }
            }
            set { _strConnectionString = value; }
        }
        /// <summary>
        /// Lay noi dung trong datatablePara ra, de truyen vo sqlCommand
        /// </summary>
        /// <param param name="datatablePara">DataTablePara chua tap gia tri cho cau lenh SQL</param>

        private void GetParamenter(DataTable datatablePara)
        {
            if (datatablePara != null)
            {
                _sqlCommand.Parameters.Clear();
                for (int i = 0; i < datatablePara.Rows.Count; i++)
                {
                    _sqlCommand.Parameters.AddWithValue(datatablePara.Rows[i]["ParaName"].ToString(), datatablePara.Rows[i]["ParaDataType"]).Value = datatablePara.Rows[i]["ParaValue"];

                }
            }
        }

        /// <summary>
        /// Thiet lap ket noi
        /// </summary>
        /// 
        public void Connect()
        {
            try
            {
                if (_sqlConnection.State == ConnectionState.Open)
                    _sqlConnection.Close();
                _sqlConnection = new SqlConnection(ConnectionString);
                _sqlConnection.Open();
            }
            catch
            {
                _sqlConnection.Dispose();
            }
        }

        /// <summary>
        /// Kiem tra trang thai cua doi tuong Connection co ket noi hay khong?
        /// </summary>

        public bool CheckConnect()
        {
            bool rs = false;
            try
            {
                if (_sqlConnection.State != ConnectionState.Closed)
                    _sqlConnection.Close();
                _sqlConnection = new SqlConnection(ConnectionString);
                _sqlConnection.Open();
                rs = true;
            }
            catch
            {
                rs = false;
            }
            return rs;
        }

        public bool CheckConnect(string strConnection)
        {
            bool rs = false;
            try
            {
                if (_sqlConnection.State != ConnectionState.Closed)
                    _sqlConnection.Close();
                _sqlConnection = new SqlConnection(strConnection);
                _sqlConnection.Open();
                rs = true;
            }
            catch
            {
                rs = false;
            }
            return rs;
        }

        /// <summary>
        /// Ngat ket noi
        /// </summary>
        /// 
        public void Disconnect()
        {
            if (_sqlConnection.State != ConnectionState.Closed)
                _sqlConnection.Close();
        }

        /// <summary>
        /// Execute a procedure (Select) with specifying procedure name
        /// </summary>
        /// <param name="sProcedureName">Tên store</param>
        /// <returns></returns>
        /// 
        public DataTable GetDataByStoredProcedure(string sProcedureName)
        {
            DataTable dt = new DataTable();
            Connect();
            try
            {
                _sqlCommand = new SqlCommand(sProcedureName, _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = _sqlCommand;
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                //throw ex;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }
        /// <summary>
        /// Execute a procedure (Select) with param
        /// </summary>
        /// <param name="sProcedureName">Name of stored procedure</param>
        /// <param name="arrNames">Array of parameter's name</param>
        /// <param name="arrValues">Array of parameter's value</param>
        public DataTable GetDataByStoredProcedure(string sProcedureName, string[] arrNames, object[] arrValues)
        {
            DataTable dt = new DataTable();
            Connect();
            try
            {
                _sqlCommand = new SqlCommand(sProcedureName, _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter par = null;
                for (int i = 0; i < arrNames.Length; i++)
                {
                    par = new SqlParameter(arrNames[i], arrValues[i]);
                    _sqlCommand.Parameters.Add(par);
                }

                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = _sqlCommand;
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

        public DataSet GetDataSetByStoredProcedure(string sProcedureName, string[] arrNames, object[] arrValues)
        {
            DataSet dt = new DataSet();
            Connect();
            try
            {
                _sqlCommand = new SqlCommand(sProcedureName, _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter par = null;
                for (int i = 0; i < arrNames.Length; i++)
                {
                    par = new SqlParameter(arrNames[i], arrValues[i]);
                    _sqlCommand.Parameters.Add(par);
                }

                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = _sqlCommand;
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

        /// <summary>
        /// Execute a procedure to select database with dataTableParam
        /// </summary>
        /// <param name="sProcedureName">Name of stored procedure</param>
        /// <param name="dataParam">Datatable of parameters</param>
        public DataTable GetDataByStoredProcedure(string sProcedureName, DataTable dataParam)
        {
            DataTable dt = new DataTable();
            Connect();
            try
            {
                _sqlCommand = new SqlCommand(sProcedureName, _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                GetParamenter(dataParam);
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = _sqlCommand;
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

        /// <summary>
        /// Get scalar data with procedure name
        /// </summary>
        /// <param name="sProcedureName">Name of stored procedure</param>
        /// <param name="arrNames">Array of parameter's name</param>
        /// <param name="arrValues">Array of parameter's value</param>
        public object GetScalarDataByStoredProcedure(string sProcedureName, string[] arrNames, object[] arrValues)
        {
            object objResult = null;
            Connect();
            try
            {
                _sqlCommand = new SqlCommand(sProcedureName, _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter par = null;
                for (int i = 0; i < arrNames.Length; i++)
                {
                    par = new SqlParameter(arrNames[i], arrValues[i]);
                    _sqlCommand.Parameters.Add(par);
                }

                objResult = _sqlCommand.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {

            }
            return objResult;
        }

        /// <summary>
        /// Execute a procedure to update, delete, insert database( no param output)
        /// </summary>
        /// <param name="sProcedureName">Name of stored procedure</param>
        /// <param name="arrNames">Array of parameter's name</param>
        /// <param name="arrValues">Array of parameter's value</param>
        public int ExecuteNonQuery(string sProcedureName, string[] arrNames, object[] arrValues)
        {
            Connect();
            try
            {
                _sqlCommand = new SqlCommand(sProcedureName, _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter par = null;
                for (int i = 0; i < arrNames.Length; i++)
                {
                    par = new SqlParameter(arrNames[i], arrValues[i]);
                    _sqlCommand.Parameters.Add(par);
                }

                return _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
        /// <summary>
        /// Execute a procedure to update, delete, insert database( no param output)
        /// </summary>
        /// <param name="sProcedureName">Name of stored procedure</param>
        /// <param name="dataParam">DataTable of parameter</param>
        public int ExecuteNonQuery(string sProcedureName, DataTable dataParam)
        {
            Connect();
            try
            {
                _sqlCommand = new SqlCommand(sProcedureName, _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                GetParamenter(dataParam);

                return _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
        /// <summary>
        /// Execute a procedure to insert database , have id value output
        /// </summary>
        /// <param name="sProcedureName">Name of stored procedure</param>
        /// <param name="arrNames">Array of parameter's name</param>
        /// <param name="arrValues">Array of parameter's value</param>
        public int ExecuteInsert(string sProcedureName, string[] arrNames, object[] arrValues)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
           try
            {
                SqlCommand cm = new SqlCommand(sProcedureName, cn);
                cm.CommandType = CommandType.StoredProcedure;
                // If connection is not connected then connect
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                SqlParameter par = null;
                for (int i = 0; i < arrNames.Length; i++)
                {
                    par = new SqlParameter(arrNames[i], arrValues[i]);
                    cm.Parameters.Add(par);
                }
                SqlParameter Id = new SqlParameter("@MA", SqlDbType.Int, 4);
                Id.Direction = ParameterDirection.Output;
                cm.Parameters.Add(Id);
                cm.ExecuteNonQuery();
                return (int)Id.Value;
            }
           catch (SqlException ex)
            {
               throw ex;
           }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
        }

        /// <summary>
        /// Execute SQL
        /// </summary>
        /// <param name="sql">Query SQL</param>
        public DataTable GetDataBySQL(string sql)
        {
            DataTable dt = new DataTable();
            Connect();
            try
            {
                _sqlCommand = new SqlCommand(sql, _sqlConnection);
                _sqlCommand.CommandType = CommandType.Text;

                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = _sqlCommand;
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }
    }
}
