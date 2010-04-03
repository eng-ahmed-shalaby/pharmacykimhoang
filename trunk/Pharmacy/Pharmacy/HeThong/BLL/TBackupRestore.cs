using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;
namespace Pharmacy.HeThong.BLL
{
    class TBackupRestore
    {
        private string ServerName;
        private string DBName;
        private string User;
        private string Pass;
        private string path;
        /// <summary>
        /// ////////////
        /// </summary>
        private static Server srvSql;
        public TBackupRestore(string ser, string db, string user, string pass ) {

            ServerName = ser;
            DBName = db;
            User = user;
            Pass = pass;
        }
        public bool Connect() {
            if (ServerName != null && ServerName!= "")
            {
                // Create a new connection to the selected server name
                ServerConnection srvConn = new ServerConnection(ServerName);
                // Log in using SQL authentication instead of Windows authentication
                srvConn.LoginSecure = false;
                // Give the login username
                srvConn.Login = User;
                // Give the login password
                srvConn.Password = Pass;
                // Create a new SQL Server object using the connection we created
                srvSql = new Server(srvConn);
            }
            else
            {
                TLog.WriteErr("TBackup.cs_NameServer Null", "");
                return false;
            }
            return true;
        }

        public bool BackUp(string path) {
            Connect();
            // If there was a SQL connection created
            if (srvSql != null)
            {
                try
                {
                    // Create a new backup operation
                    Backup bkpDatabase = new Backup();
                    // Set the backup type to a database backup
                    bkpDatabase.Action = BackupActionType.Database;
                    // Set the database that we want to perform a backup on
                    bkpDatabase.Database = DBName;
                    // Set the backup device to a file
                    if (File.Exists(path))
                    {
                        int i = path.LastIndexOf('\\');
                        path = NameFile(path.Substring(0, i));
                    }
                    //làm gì thì tùy
                    BackupDeviceItem bkpDevice = new BackupDeviceItem(path+".bak", DeviceType.File);
                    // Add the backup device to the backup
                    bkpDatabase.Devices.Add(bkpDevice);
                    // Perform the backup
                    bkpDatabase.SqlBackup(srvSql);
                }
                catch (Exception ex)
                {
                    TLog.WriteErr("TBackup.cs_bak ", ex.Message);
                    return false;
                }
                }
            else
            {
                TLog.WriteErr("TBackup.cs_Backup ", "Not Connected to Server");
                return false;
                
            }
            return true;
        }
        private string NameFile(string path) {
            string date = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year +"_" +DateTime.Now.Millisecond;

            string File = path+"/"+ DBName +date;
            return File;
        }
        public bool Restore(string path)
        {
            Connect();
            if (srvSql != null)
            {
                try
                // If the user has chosen the file from which he wants the database to be restored
                {
                    // Create a new database restore operation
                    Restore rstDatabase = new Restore();
                    // Set the restore type to a database restore
                    rstDatabase.Action = RestoreActionType.Database;
                    // Set the database that we want to perform the restore on
                    rstDatabase.Database = DBName;
                    BackupDeviceItem bkpDevice = new BackupDeviceItem(path, DeviceType.File);
                    // Add the backup device to the restore type
                    rstDatabase.Devices.Add(bkpDevice);
                    // If the database already exists, replace it
                    rstDatabase.ReplaceDatabase = true;
                    // Perform the restore
                    rstDatabase.SqlRestore(srvSql);
                }
                catch(Exception ex) {
                    TLog.WriteErr("TBackup.cs_retore ",ex.Message);
                    return false;
                }
            }
            else
            {
                TLog.WriteErr("TBackup.cs_retore ", "Not Connected to Server");
                return false;
                
            }
            return true;
        }
    }

}
