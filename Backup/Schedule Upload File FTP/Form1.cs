using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using ConfigCOMPortBank;
using System.IO;
using System.Xml;

namespace Schedule_Upload_File_FTP
{
    public partial class Form1 : Form
    {
        string _NgayHienHanh;
        bool _isupload = false;
        bool _isupdate1folder = false;

        public Form1()
        {
            InitializeComponent();
            //string x = DateTime.Now.ToString("HH");
            _NgayHienHanh = DateTime.Now.ToString("ddMMyyyy");
            loadControl();
            //Random ran = new Random();
            //int x = ran.Next(listBox1.Items.Count);
        }
        public void loadControl()
        {
            try
            {
                //load timer
                numtimertick.Value = Convert.ToDecimal(CTLConfig._timer);
                timer1.Enabled = true;
                timer1.Interval =(int) numtimertick.Value * 1000 * 60;
                timer1.Tick += new EventHandler(timer1_Tick);

                txtfileLocal.Text = CTLConfig._pathfilelocal;
                txtpathFTP.Text = CTLConfig._pathftp;
                //load default
                txtdefault.Text = CTLConfig._pathdefault;
                //load path file config
                txtpathfileconfig.Text = CTLConfig._pathdefault;
                //load list box
                DirectoryInfo droot = new DirectoryInfo(txtfileLocal.Text);
                foreach (DirectoryInfo d in droot.GetDirectories())
                {
                    listBox1.Items.Add(d.FullName);
                }
                //load list editor file
                loadFileConfig();
            }
            catch (Exception ex)
            {
                CTLError.WriteError("Loi LoadControl ", ex.Message);
                return;
            }
        }
        public bool CheckTimeupran()
        {
            try
            {
                string[] strHourUpRan = CTLConfig._HourUpRan.Split(';');
                foreach (string s in strHourUpRan)
                {
                    string[] s1 = s.Split('-');
                    if (Convert.ToInt32(DateTime.Now.ToString("HH")) >= Convert.ToInt32(s1[0]) && Convert.ToInt32(DateTime.Now.ToString("HH")) <= Convert.ToInt32(s1[1]))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                CTLError.WriteError("Loi CheckTimeupran ", ex.Message);
                return false;
            }

        }
        public bool CheckTimeupDefault()
        {
            try
            {
                string[] strHourUpRdefault = CTLConfig._HourUpDefault.Split(';');
                foreach (string s in strHourUpRdefault)
                {
                    string[] s1 = s.Split('-');
                    if (Convert.ToInt32(DateTime.Now.ToString("HH")) > Convert.ToInt32(s1[0]) && Convert.ToInt32(DateTime.Now.ToString("HH")) < Convert.ToInt32(s1[1]))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                CTLError.WriteError("Loi CheckTimeupran ", ex.Message);
                return false;
            }

        }
        void timer1_Tick(object sender, EventArgs e)
        {
            try
            {


                if (CheckTimeupran() && !_isupdate1folder)
                {
                    //random upload
                    if (listBox1.Items.Count <= 0)
                        return;
                    if (listBox1.Items.Count == 1)
                        _isupdate1folder = true;
                    FTPHelper ftphelper = new FTPHelper(CTLConfig._user, CTLConfig._pass, CTLConfig._pathftp);
                    Random ran=new Random();
                    int x = ran.Next(listBox1.Items.Count);
                    DirectoryInfo d = new DirectoryInfo(listBox1.Items[x].ToString());
                    foreach (FileInfo f in d.GetFiles("*.txt"))
                    {
                        string str= ftphelper.UploadFile(f.FullName);
                        CTLError.WriteError("Update " + d.Name, str);
                    }
                    
                }
                else if (CheckTimeupDefault()&&!_isupload)
                {
                    FTPHelper ftphelper = new FTPHelper(CTLConfig._user, CTLConfig._pass, CTLConfig._pathftp);
                    //upload default
                    _isupload = true;
                    DirectoryInfo d = new DirectoryInfo(CTLConfig._pathdefault);
                    foreach (FileInfo f in d.GetFiles("*.txt"))
                    {
                        string str = ftphelper.UploadFile(f.FullName);
                        CTLError.WriteError("Update " + d.Name, str);
                    }
                    

                }
            }
            catch (Exception ex)
            {
                CTLError.WriteError("Loi Timer Tick ", ex.Message);
                return;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            CTLConfig.SetCOMConfig(numtimertick.Value.ToString("N0"), txtpathFTP.Text, txtfileLocal.Text,txtdefault.Text);
            MessageBox.Show("Luu Thanh cong!!", "Luu Config", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btbrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtfileLocal.Text = folder.SelectedPath;
            }
        }

        private void bttestupload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile=new OpenFileDialog();
                if(openfile.ShowDialog()==DialogResult.OK)
                {
                    FTPHelper ftphelper = new FTPHelper(CTLConfig._user,CTLConfig._pass,CTLConfig._pathftp);
                    string res= ftphelper.UploadFile(openfile.FileName);
                    if(res!=string.Empty)
                        MessageBox.Show("Upload Thanh cong!!", "Upload Config", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                CTLError.WriteError("loi test upload ", ex.Message);
                return;
            }

        }

        private void timerreset_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("HH") == "00" /*&& _NgayHienHanh != DateTime.Now.ToString("ddMMyyyy")*/)
            {
                _NgayHienHanh = DateTime.Now.ToString("ddMMyyyy");
                _isupload = false;
                _isupdate1folder = false;
            }
        }

        private void numtimertick_ValueChanged(object sender, EventArgs e)
        {
            if (numtimertick.Value > 0)
            {
                timer1.Interval = (int)numtimertick.Value * 60000;
            }
        }


        #region Editor Config file 

        public void loadFileConfig()
        {
            try
            {
                listEditorfile.Items.Clear();
                DirectoryInfo d = new DirectoryInfo(txtpathfileconfig.Text);
                foreach (FileInfo f in d.GetFiles("*.txt"))
                {
                    listEditorfile.Items.Add(f.FullName);
                }
                if (listEditorfile.Items.Count > 0)
                {
                    listEditorfile.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                CTLError.WriteError("loadFileConfig ", ex.Message);
                return;
            }
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtpathfileconfig.Text = folder.SelectedPath;
            }
        }

        private void listEditorfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo fselect = new FileInfo(listEditorfile.Items[listEditorfile.SelectedIndex].ToString());
            entyconfigfile enty= GetxmlConfigfile(fselect);
            if (enty != null)
            {

            }
        }
        public entyconfigfile GetxmlConfigfile(FileInfo f)
        {
            
            try
            {
                entyconfigfile enty = new entyconfigfile();

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(f.FullName);

                XmlElement node1 = xmlDoc.SelectSingleNode("/app/ad1") as XmlElement;
                enty.ad1_ggban = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad1") as XmlElement;
                enty.ad1_ggban = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad2") as XmlElement;
                enty.ad2_ggfull = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad3") as XmlElement;
                enty.ad3_amaz = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad4") as XmlElement;
                enty.ad4_adcolony = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad5") as XmlElement;
                enty.ad5_unity = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad6") as XmlElement;
                enty.ad6_revmob = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad7") as XmlElement;
                enty.ad7_vungle = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/ad8") as XmlElement;
                enty.ad8_suppersonic = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/gbanner") as XmlElement;
                enty.gbanner = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/gful") as XmlElement;
                enty.gful = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/amazon") as XmlElement;
                enty.amazon = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/adcolonyAppID") as XmlElement;
                enty.adcolonyAppID = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/adcolonyZoneID") as XmlElement;
                enty.adcolonyZoneID = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/unityid") as XmlElement;
                enty.unityid = node1.InnerText;


                node1 = xmlDoc.SelectSingleNode("/app/revmobid") as XmlElement;
                enty.revmobid = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/vungleid") as XmlElement;
                enty.vungleid = node1.InnerText;

                node1 = xmlDoc.SelectSingleNode("/app/sonicid") as XmlElement;
                enty.sonicid = node1.InnerText;

                return enty;
            }
            catch (Exception exception)
            {
                CTLError.WriteError("GetxmlConfigfile ", exception.Message);
                return null;
                
            }
        }
    }
}
