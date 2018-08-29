using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Xml;
using System.Windows.Forms;


namespace ConfigCOMPortBank
{
    class CTLConfig
    {
        public static string _timer;
        public static string _user;
        public static string _pass;
        public static string _pathftp;
        public static string _pathfilelocal;
        public static string _pathdefault;
        public static string _HourUpDefault;
        public static string _HourUpRan;

        public static void GetConfiguration()
        {
            XmlDocument document = new XmlDocument();
            try
            {
                
                document.Load(Application.StartupPath + @"\Config.xml");
                _timer = document.SelectSingleNode("//timer").Attributes["Value"].Value;
                _user = document.SelectSingleNode("//user").Attributes["Value"].Value;
                _pass = document.SelectSingleNode("//pass").Attributes["Value"].Value;
                _pathftp = document.SelectSingleNode("//pathftp").Attributes["Value"].Value;
                _pathfilelocal = document.SelectSingleNode("//pathfilelocal").Attributes["Value"].Value;
                _pathdefault = document.SelectSingleNode("//default").Attributes["Value"].Value;
                _HourUpDefault = document.SelectSingleNode("//hourupdefault").Attributes["Value"].Value;
                _HourUpRan = document.SelectSingleNode("//hourupran").Attributes["Value"].Value;
                
            }
            catch (Exception exception)
            {
                CTLError.WriteError("CTLConfig getconfig ", exception.Message);
                return ;
                throw new Exception(exception.Message);
            }
        }
        public static bool SetCOMConfig(string timer,string pathftp, string pathlocal,string pathdefault)
        {
            bool flag = true;
            try
            {
                setconfig("timer", timer);
                _timer = timer;
                setconfig("pathftp", pathftp);
                _pathftp = pathftp;
                setconfig("pathfilelocal", pathlocal);
                _pathfilelocal = pathlocal;
                setconfig("default", pathdefault);
                _pathdefault = pathdefault;
                
                return true;
            }
            catch (Exception exception)
            {
                CTLError.WriteError("SetCOMConfig ", exception.Message);
                return false;
                throw;
            }
            return flag;
        }
        public static bool setconfig(string keyName,string value)
        {
            bool flag = true;
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(Application.StartupPath + @"\Config.xml");

                document.SelectSingleNode("//" + keyName).Attributes["Value"].Value = value;
                              
                document.Save(Application.StartupPath + @"\Config.xml");

               return true;
            }
            catch (Exception exception)
            {
                CTLError.WriteError("set config value "+keyName, exception.Message);
                return false;
                throw;
            }
            return flag;
        }
        
    }
}
