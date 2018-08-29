using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConfigCOMPortBank;

namespace Schedule_Upload_File_FTP.usctr
{
    public partial class UsrFileConfig : UserControl
    {
        entyconfigfile _enty;
        public UsrFileConfig()
        {
            InitializeComponent();
        }
        public UsrFileConfig(entyconfigfile enty)
        {
            InitializeComponent();
            _enty = enty;
            loadcontrol();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                setvalueEnty();
                bool res = _enty.SaveFile();
                if (res)
                {
                    labthongbao.Text = "Save file thanh cong !!!!!!!!!";
                }
                else
                {
                    labthongbao.Text = "Save file ko thanh cong ........XXXXXX";
                }
            }
            catch (Exception ex)
            {
                CTLError.WriteError("Save "+_enty.pathfile+" ", ex.Message);
                return;
            }
        }
        public void setvalueEnty()
        {
            try
            {
                _enty.ad1_ggban = gban.Checked.ToString().ToLower();
                _enty.ad2_ggfull = gfull.Checked.ToString().ToLower();
                _enty.ad3_amaz = amz.Checked.ToString().ToLower();
                _enty.ad4_adcolony = colony.Checked.ToString().ToLower();
                _enty.ad5_unity = utity.Checked.ToString().ToLower();
                _enty.ad6_revmob = rev.Checked.ToString().ToLower();
                _enty.ad7_vungle = vule.Checked.ToString().ToLower();
                _enty.ad8_suppersonic = sonic.Checked.ToString().ToLower();
                _enty.gbanner = txtgban.Text;
                _enty.gful = txtgfull.Text;
                _enty.amazon = txtamz.Text;
                _enty.adcolonyAppID = txtcolonyID.Text;
                _enty.adcolonyZoneID = txtcolonyzone.Text;
                _enty.unityid = txtutity.Text;
                _enty.revmobid = txtrev.Text;
                _enty.vungleid = txtvule.Text;
                _enty.sonicid = txtsonic.Text;
            }
            catch (Exception ex)
            {
                CTLError.WriteError("setvalueEnty ", ex.Message);
                return;
            }
        }
        public void loadcontrol()
        {

            //set value
            txtgban.Text = _enty.gbanner;
            txtgfull.Text = _enty.gful;
            txtamz.Text = _enty.amazon;
            txtcolonyID.Text = _enty.adcolonyAppID;
            txtcolonyzone.Text = _enty.adcolonyZoneID;
            txtutity.Text = _enty.unityid;
            txtrev.Text = _enty.revmobid;
            txtvule.Text = _enty.vungleid;
            txtsonic.Text = _enty.sonicid;

            //new
            txtcappid.Text = _enty.cappid;
            txtcsign.Text = _enty.csign;
            txtlead.Text = _enty.leadboot;

            //set check
            gban.Checked = Convert.ToBoolean(_enty.ad1_ggban);
            gfull.Checked = Convert.ToBoolean(_enty.ad2_ggfull);
            amz.Checked = Convert.ToBoolean(_enty.ad3_amaz);
            colony.Checked = Convert.ToBoolean(_enty.ad4_adcolony);
            utity.Checked = Convert.ToBoolean(_enty.ad5_unity);
            rev.Checked = Convert.ToBoolean(_enty.ad6_revmob);
            vule.Checked = Convert.ToBoolean(_enty.ad7_vungle);
            sonic.Checked = Convert.ToBoolean(_enty.ad8_suppersonic);
        }
    }
}
