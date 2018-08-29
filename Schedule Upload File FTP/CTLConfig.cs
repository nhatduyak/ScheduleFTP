using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;


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

        public static List<string> _GenFilenameUpload;
        public static List<string> _Gentypead;
        public static List<string> _GenAd;
        public static bool _CheckGen;
        //public static string _HourChange = "00";

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
                string genfilename = document.SelectSingleNode("//GenFileName").Attributes["Value"].Value;
                string gentypead = document.SelectSingleNode("//GenTypeAd").Attributes["Value"].Value;
                string genad = document.SelectSingleNode("//GenAd").Attributes["Value"].Value;
                _GenFilenameUpload = new List<string>();
                _Gentypead = new List<string>();
                _GenAd = new List<string>();
                foreach (string s in genfilename.Split(';'))
                {
                    if (s != string.Empty)
                        _GenFilenameUpload.Add(s);
                }
                foreach (string s in gentypead.Split(';'))
                {
                    if (s != string.Empty)
                        _Gentypead.Add(s);
                }
                foreach (string s in genad.Split(';'))
                {
                    if (s != string.Empty)
                        _GenAd.Add(s);
                }
                _CheckGen = Convert.ToBoolean(document.SelectSingleNode("//CheckGen").Attributes["Value"].Value);
                //_HourChange = document.SelectSingleNode("//HourChange").Attributes["Value"].Value;
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
