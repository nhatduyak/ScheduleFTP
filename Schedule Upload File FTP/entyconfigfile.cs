using System;
using System.Collections.Generic;

using System.Text;
using ConfigCOMPortBank;
using System.Xml;

namespace Schedule_Upload_File_FTP
{
    public class entyconfigfile
    {
        public string ad1_ggban;
        public string ad2_ggfull;
        public string ad3_amaz;
        public string ad4_adcolony;
        public string ad5_unity;
        public string ad6_revmob;
        public string ad7_vungle;
        public string ad8_suppersonic;

        public string gbanner;
        public string gful;
        public string amazon;
        public string adcolonyAppID;
        public string adcolonyZoneID;
        public string unityid;
        public string revmobid;
        public string vungleid;
        public string sonicid;
        public string cappid;
        public string csign;
        public string leadboot;

        public string pathfile;
       
        public entyconfigfile(string path)
        {
            pathfile = path;
            
        }
        public bool SaveFile()
        {
            try
            {
                try
                {
                    //entyconfigfile enty = new entyconfigfile(pathfile);

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(pathfile);

                 
                    XmlElement node1 = xmlDoc.SelectSingleNode("/app/ad1") as XmlElement;
                    node1.InnerText = ad1_ggban;

                    XmlElement node2 = xmlDoc.SelectSingleNode("/app/ad2") as XmlElement;
                    node2.InnerText = ad2_ggfull;
                    

                    XmlElement node3 = xmlDoc.SelectSingleNode("/app/ad3") as XmlElement;
                    node3.InnerText=ad3_amaz;

                    XmlElement node4= xmlDoc.SelectSingleNode("/app/ad4") as XmlElement;
                    node4.InnerText=ad4_adcolony;

                    XmlElement node5 = xmlDoc.SelectSingleNode("/app/ad5") as XmlElement;
                    node5.InnerText=ad5_unity;

                    XmlElement node6 = xmlDoc.SelectSingleNode("/app/ad6") as XmlElement;
                    node6.InnerText=ad6_revmob;

                    XmlElement node7 = xmlDoc.SelectSingleNode("/app/ad7") as XmlElement;
                    node7.InnerText=ad7_vungle;

                    XmlElement node8 = xmlDoc.SelectSingleNode("/app/ad8") as XmlElement;
                    node8.InnerText=ad8_suppersonic;

                    XmlElement node9 = xmlDoc.SelectSingleNode("/app/gbanner") as XmlElement;
                    node9.InnerText=gbanner;

                    XmlElement node10 = xmlDoc.SelectSingleNode("/app/gfull") as XmlElement;
                    node10.InnerText=gful;

                    XmlElement node11 = xmlDoc.SelectSingleNode("/app/amazon") as XmlElement;
                    node11.InnerText=amazon;

                    XmlElement node12 = xmlDoc.SelectSingleNode("/app/adcolonyAppID") as XmlElement;
                    node12.InnerText=adcolonyAppID;

                    XmlElement node13 = xmlDoc.SelectSingleNode("/app/adcolonyZoneID") as XmlElement;
                    node13.InnerText=adcolonyZoneID;

                    XmlElement node14 = xmlDoc.SelectSingleNode("/app/unityid") as XmlElement;
                    node14.InnerText=unityid;


                    XmlElement node15 = xmlDoc.SelectSingleNode("/app/revmobid") as XmlElement;
                    node15.InnerText=revmobid;

                    XmlElement node16 = xmlDoc.SelectSingleNode("/app/vungleid") as XmlElement;
                    node16.InnerText=vungleid;

                    XmlElement node17 = xmlDoc.SelectSingleNode("/app/sonicid") as XmlElement;
                    node17.InnerText=sonicid;

                    XmlElement node18 = xmlDoc.SelectSingleNode("/app/cappid") as XmlElement;
                    node18.InnerText = cappid;

                    XmlElement node19 = xmlDoc.SelectSingleNode("/app/csign") as XmlElement;
                    node19.InnerText = csign;

                    XmlElement node20 = xmlDoc.SelectSingleNode("/app/leadboot") as XmlElement;
                    node20.InnerText = leadboot;

                    xmlDoc.Save(pathfile);

                    return true;
                }
                catch (Exception exception)
                {
                    CTLError.WriteError("loadValuFromFile ", exception.Message);
                    return false;

                }
                return true;
            }
            catch (Exception ex)
            {
                CTLError.WriteError("Loi LoadControl ", ex.Message);
                return false;
            }

        }
        public void loadValuFromFile()
        {
            try
            {
                //entyconfigfile enty = new entyconfigfile(pathfile);

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathfile);

                XmlElement node1 = xmlDoc.SelectSingleNode("/app/ad1") as XmlElement;
                ad1_ggban = node1.InnerText;

                
                node1 = xmlDoc.SelectSingleNode("/app/ad2") as XmlElement;
                ad2_ggfull = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad3") as XmlElement;
                ad3_amaz = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad4") as XmlElement;
                ad4_adcolony = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad5") as XmlElement;
                ad5_unity = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad6") as XmlElement;
                ad6_revmob = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad7") as XmlElement;
                ad7_vungle = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad8") as XmlElement;
                ad8_suppersonic = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/gbanner") as XmlElement;
                gbanner = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/gfull") as XmlElement;
                gful = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/amazon") as XmlElement;
                amazon = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/adcolonyAppID") as XmlElement;
                adcolonyAppID = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/adcolonyZoneID") as XmlElement;
                adcolonyZoneID = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/unityid") as XmlElement;
                unityid = node1.InnerText;


                node1 = xmlDoc.SelectSingleNode("/app/revmobid") as XmlElement;
                revmobid = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/vungleid") as XmlElement;
                vungleid = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/sonicid") as XmlElement;
                sonicid = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/cappid") as XmlElement;
               cappid= node1.InnerText;

               node1 = xmlDoc.SelectSingleNode("/app/csign") as XmlElement;
               csign=node1.InnerText;

               node1 = xmlDoc.SelectSingleNode("/app/leadboot") as XmlElement;
               leadboot=node1.InnerText;
                
            }
            catch (Exception exception)
            {
                CTLError.WriteError("loadValuFromFile ", exception.Message);
                return;

            }
        }
        public void SetvalueKey(string key, string value)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathfile);


                XmlElement node1 = xmlDoc.SelectSingleNode("/app/"+key) as XmlElement;
                node1.InnerText = value;
                xmlDoc.Save(pathfile);

            }
            catch (Exception exception)
            {
                CTLError.WriteError("entyconfigfile SetvalueKey ", exception.Message);
                return;

            }
        }
    }
}
