using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using System.Xml;
public class TLog
{
    public static bool AllowLog = true;
    //public static string LogDir = @"D:\Inetpub\wwwTrilac\VGB\_Log\";
    public static string LogDir = AppDomain.CurrentDomain.BaseDirectory +"Log\\";

    public static void  WriteLog(String pLogInfo, String pLogDetail)
    {
        string today = System.DateTime.Now.ToString("yyyyMMdd");
        Log("Info", LogDir + "\\" + today + "_Bug.xml", pLogInfo, pLogDetail, "LOG");
    }

    public static void WriteDebug(String pLogInfo, String pLogDetail)
    {
        string today = System.DateTime.Now.ToString("yyyyMMdd");
        Log("Bug", LogDir + "\\" + today + "_Bug.xml", pLogInfo, pLogDetail, "DEBUG");
    }

    public static void WriteErr(String pLogInfo, String pLogDetail)
    {
        string today = System.DateTime.Now.ToString("yyyyMMdd");
        Log("Err", LogDir + "\\" + today + "_Err.xml", pLogInfo, pLogDetail, "ERROR");
    }

    public static void WriteInfo(String pLogInfo, String pLogDetail)
    {
        string today = System.DateTime.Now.ToString("yyyyMMdd");
        Log("Info", LogDir + "\\" + today + "_Info.xml", pLogInfo, pLogDetail, "INFOMATION");
    }
    public static void WriteLogService(String pLogInfo, String pLogDetail)
    {
        string today = System.DateTime.Now.ToString("yyyyMMdd");
        Log("Info", LogDir + "\\" + today + "_LogService.xml", pLogInfo, pLogDetail, "INFOMATION");
    }
    private static void Log(string pInfoType, string pFilepath, string pContent, string pDetail, string pRootName)
    {
        if (!AllowLog) return;

        try
        {
            XmlDocument docXml = new XmlDocument();
            try{
                docXml.Load(pFilepath);
            }
            catch (Exception ex){
                docXml = new XmlDocument();
            }

            XmlElement Goc = docXml.DocumentElement;
            if ((Goc == null))
            {
                Goc = docXml.CreateElement(pRootName);
                docXml.AppendChild(Goc);
            }

            XmlElement The = docXml.CreateElement(pInfoType);
            The.SetAttribute("At", DateTime.Now.ToString("dd\\/MM\\/yyyy HH:mm:ss"));
            The.SetAttribute("Message", pContent);
            The.SetAttribute("Detail", pDetail);            

            Goc.AppendChild(The);
            docXml.Save(pFilepath);
        }
        catch (Exception ex)
        {
        }
    }
}