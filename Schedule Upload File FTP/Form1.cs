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
using Schedule_Upload_File_FTP.usctr;

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

            //test
           // GenAndUpload();


            //GetTime - UTC Time  
            /*
            DateTime test = DateTime.Now;
            DateTime utcTime = test.ToUniversalTime(); // convert it to Utc using timezone setting of server computer


            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi); // convert from utc to local

             * END
             */
            //Restart app
            /*
            System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
            this.Close(); //to turn off current app

            */


            //string x = DateTime.Now.ToString("HH");
            _NgayHienHanh = DateTime.Now.ToString("ddMMyyyy");
            loadControl();
            //Random ran = new Random();
            //int x = ran.Next(listBox1.Items.Count);
            checkgenerateUpload.Checked = CTLConfig._CheckGen;
        }
        public void loadControl()
        {
            try
            {
                //load timer
                numtimertick.Value = Convert.ToDecimal(CTLConfig._timer);
                timer1.Enabled = true;
                timer1.Interval =(int) 1 * 1000 * 60;
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
                if (checkgenerateUpload.Checked)
                {
                    GenAndUpload();
                    return;
                }

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
            flowLayoutPanel1.Controls.Clear();
            FileInfo fselect = new FileInfo(listEditorfile.Items[listEditorfile.SelectedIndex].ToString());
            entyconfigfile enty= new entyconfigfile(fselect.FullName);
            enty.loadValuFromFile();
            UsrFileConfig user = new UsrFileConfig(enty);
            flowLayoutPanel1.Controls.Add(user);
            user.loadcontrol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK )
                {
                    txtpathfileSetkey.Text = fbd.SelectedPath;

                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SetValue();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtfromfile.Text = fbd.FileName;

                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void checksetfromfile_CheckedChanged(object sender, EventArgs e)
        {
            if (checksetfromfile.AutoCheck)
            {
                txtfromfile.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                txtfromfile.Enabled = false;
                button4.Enabled = false;
            }
        }

        public void SetValue()
        {
            try
            {
                if (txtpathfileSetkey.Text == string.Empty)
                {
                    MessageBox.Show("vui long chon Path File");
                    return;
                }
                DirectoryInfo dparent = new DirectoryInfo(txtpathfileSetkey.Text);

                if (checkSetparentKey.Checked)
                {
                    foreach (FileInfo f in dparent.GetFiles(txtfilename.Text))
                    {
                        if (f.Exists)
                        {
                            entyconfigfile enty = new entyconfigfile(f.FullName);
                            enty.loadValuFromFile();
                            enty.SetvalueKey(txtKeySet.Text, txtValukey.Text);
                        }
                    }
                }

                int CountKey = 0;
                List<string> listkey = new List<string>();
                if (checksetfromfile.Checked)
                {
                    StreamReader read = new StreamReader(txtfromfile.Text);
                    while (!read.EndOfStream)
                    {
                        string readline = read.ReadLine();
                        if(readline.Trim()!=string.Empty)
                            listkey.Add(readline);
                    }
                }

                foreach (DirectoryInfo dsource in dparent.GetDirectories())
                {
                    foreach (FileInfo f in dsource.GetFiles(txtfilename.Text))
                    {
                        if (f.Exists)
                        {
                            string valuekey = txtValukey.Text;
                            if (checksetfromfile.Checked)
                            {
                                if(listkey.Count>CountKey)
                                    valuekey = listkey[CountKey++];
                                else
                                    valuekey = listkey[CountKey-1];
                            }
                            entyconfigfile enty = new entyconfigfile(f.FullName);
                            enty.loadValuFromFile();
                            enty.SetvalueKey(txtKeySet.Text, valuekey);
                        }
                    }
                }
                labthongbao.Text = "Set Value Thanh Cong";
            }
            catch (Exception ex)
            {
                CTLError.WriteError("loi SetValue tab3 ", ex.Message);
                labthongbao.Text = "Loi " + ex.Message;
                return;
            }
        }

        

        public void GenAndUpload()
        {
            try
            {
                DirectoryInfo dsource = new DirectoryInfo(CTLConfig._pathfilelocal);
                foreach(FileInfo f in dsource.GetFiles("*.txt"))
                {
                    SetValueFile(f.FullName);
                    SetTrueFalseAD(f.FullName);
                    FTPHelper ftphelper = new FTPHelper(CTLConfig._user, CTLConfig._pass, CTLConfig._pathftp);
                    ftphelper.UploadFile(f.FullName);
                }
            }
            catch (Exception ex)
            {
                CTLError.WriteError("loi GenAndUpload ", ex.Message);
                MessageBox.Show("Loi " + ex.Message);
            }
        }
        public void SetValueFile(string pathFile)
        {
            try
            {
                FileInfo FileSource=new FileInfo(pathFile);
                foreach(string s in CTLConfig._Gentypead)
                {
                    FileInfo f = new FileInfo(Path.Combine(CTLConfig._pathfilelocal, s.Trim() + FileSource.Name.Split('.')[0]));
                    if (f.Exists)
                    {
                        StreamReader read=new StreamReader(f.FullName);
                        List<string> temp = new List<string>();
                        while (!read.EndOfStream)
                        {
                            string str = read.ReadLine();
                            if (str != string.Empty)
                                temp.Add(str);
                            
                        }
                        Random ran = new Random();
                        int index = ran.Next(0, temp.Count);
                        entyconfigfile enty = new entyconfigfile(pathFile);
                        enty.loadValuFromFile();
                        enty.SetvalueKey(s, temp[index]);
                    }
                }
            }
            catch (Exception ex)
            {
                CTLError.WriteError("loi SetValueFile "+pathFile, ex.Message);
                MessageBox.Show("Loi "+pathFile + ex.Message);
            }
        }
        public void SetTrueFalseAD(string pathFile)
        {
            try
            {
                foreach (string s in CTLConfig._GenAd)
                {
                    entyconfigfile enty = new entyconfigfile(pathFile);
                    enty.loadValuFromFile();
                    enty.SetvalueKey(s, "false");
                }
                //setamazon
                entyconfigfile entyama = new entyconfigfile(pathFile);
                entyama.loadValuFromFile();
                entyama.SetvalueKey("ad3", "true");

                Random ran = new Random();
                int CountTrue = ran.Next(1,CTLConfig._GenAd.Count);
                for (int i = 0; i < CountTrue; i++)
                {
                    Random ran1 = new Random();
                    int index = ran1.Next(0, CTLConfig._GenAd.Count);
                    entyconfigfile enty = new entyconfigfile(pathFile);
                    enty.loadValuFromFile();
                    enty.SetvalueKey(CTLConfig._GenAd[index], "true");
                }
            }            
            catch (Exception ex)
            {
                CTLError.WriteError("loi SetTrueFalseAD " + pathFile, ex.Message);
                MessageBox.Show("Loi "+pathFile + ex.Message);
            }
        }

        private void btloadkey_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtfileloadama.Text = open.FileName;
                DataTable dt = LoadTableKey(open.FileName);
                gridControl1.DataSource = dt;
            }
        }
        public DataTable LoadTableKey(string filename)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Key");
                StreamReader read = new StreamReader(filename);
                while (!read.EndOfStream)
                {
                    string s = read.ReadLine();
                    string[] str = s.Split(new string[] { txtsplit.Text }, StringSplitOptions.None);
                    if (str.Length > 1)
                    {
                        DataRow r = dt.NewRow();
                        r["Name"] = str[0].Trim();
                        r["Key"] = str[1].Trim();
                        dt.Rows.Add(r);
                    }
                }

                return dt;
            }
            catch (Exception ex) { CTLError.WriteError("loi LoadTableKey ", ex.Message); return null; }
        }
        private void DeleteSelectedRows(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            if (view == null || view.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[view.SelectedRowsCount];
            for (int i = 0; i < view.SelectedRowsCount; i++)
                rows[i] = view.GetDataRow(view.GetSelectedRows()[i]);
            view.BeginSort();
            try
            {
                foreach (DataRow row in rows)
                    row.Delete();
            }
            finally
            {
                view.EndSort();
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedRows(gridView1);
            }
        }
        //public void ChangeOpenVpnConfig()
        //{
        //    try
        //    {
        //        DateTime test = DateTime.Now;
        //        DateTime utcTime = test.ToUniversalTime(); // convert it to Utc using timezone setting of server computer
        //        if (utcTime.Hour != Convert.ToInt32("0" + CTLConfig._HourChange)&&(utcTime.Hour==12||utcTime.Hour==0))
        //        {
        //            if (utcTime.Hour == 12)
        //            {
        //                DirectoryInfo d = new DirectoryInfo(Path.Combine(Application.StartupPath, "a1"));
        //                if (d.Exists)
        //                {
        //                    DirectoryInfo doconfig = new DirectoryInfo(@"C:\Program Files\OpenVPN\config");
        //                    if (doconfig.Exists)
        //                    {
        //                        foreach (FileInfo f in doconfig.GetFiles())
        //                            f.Delete();
        //                        foreach (FileInfo f in d.GetFiles())
        //                        {
        //                            f.CopyTo(Path.Combine(doconfig.FullName, f.Name),true);
        //                        }
        //                    }
        //                }
        //            }
        //            else if (utcTime.Hour == 0)
        //            {
        //                DirectoryInfo d = new DirectoryInfo(Path.Combine(Application.StartupPath, "a2"));
        //                if (d.Exists)
        //                {
        //                    DirectoryInfo doconfig = new DirectoryInfo(@"C:\Program Files\OpenVPN\config");
        //                    if (doconfig.Exists)
        //                    {
        //                        foreach (FileInfo f in doconfig.GetFiles())
        //                            f.Delete();
        //                        foreach (FileInfo f in d.GetFiles())
        //                        {
        //                            f.CopyTo(Path.Combine(doconfig.FullName, f.Name), true);
        //                        }
        //                    }
        //                }
        //            }
        //            CTLConfig._HourChange = utcTime.Hour.ToString();
        //            CTLConfig.setconfig("HourChange", utcTime.Hour.ToString());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CTLError.WriteError("Loi ChangeOpenVpnConfig ", ex.Message);
        //    }
        //}
    }
}
