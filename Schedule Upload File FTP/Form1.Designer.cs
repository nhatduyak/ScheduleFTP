namespace Schedule_Upload_File_FTP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerreset = new System.Windows.Forms.Timer(this.components);
            this.tabSetKey = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkgenerateUpload = new System.Windows.Forms.CheckBox();
            this.bttestupload = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtdefault = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpathFTP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btbrowse = new System.Windows.Forms.Button();
            this.txtfileLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numtimertick = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpathfileconfig = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listEditorfile = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labthongbao = new System.Windows.Forms.Label();
            this.txtfromfile = new System.Windows.Forms.TextBox();
            this.checksetfromfile = new System.Windows.Forms.CheckBox();
            this.checkSetparentKey = new System.Windows.Forms.CheckBox();
            this.txtValukey = new System.Windows.Forms.TextBox();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.txtKeySet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpathfileSetkey = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsplit = new System.Windows.Forms.TextBox();
            this.txtfileloadama = new System.Windows.Forms.TextBox();
            this.btloadkey = new System.Windows.Forms.Button();
            this.btcreateOnAds = new System.Windows.Forms.Button();
            this.tabSetKey.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtimertick)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerreset
            // 
            this.timerreset.Enabled = true;
            this.timerreset.Interval = 600000;
            this.timerreset.Tick += new System.EventHandler(this.timerreset_Tick);
            // 
            // tabSetKey
            // 
            this.tabSetKey.Controls.Add(this.tabPage1);
            this.tabSetKey.Controls.Add(this.tabPage2);
            this.tabSetKey.Controls.Add(this.tabPage3);
            this.tabSetKey.Controls.Add(this.tabPage4);
            this.tabSetKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSetKey.Location = new System.Drawing.Point(0, 0);
            this.tabSetKey.Name = "tabSetKey";
            this.tabSetKey.SelectedIndex = 0;
            this.tabSetKey.Size = new System.Drawing.Size(743, 475);
            this.tabSetKey.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btcreateOnAds);
            this.tabPage1.Controls.Add(this.checkgenerateUpload);
            this.tabPage1.Controls.Add(this.bttestupload);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.txtdefault);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtpathFTP);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btSave);
            this.tabPage1.Controls.Add(this.btbrowse);
            this.tabPage1.Controls.Add(this.txtfileLocal);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numtimertick);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schedule Upload FTP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkgenerateUpload
            // 
            this.checkgenerateUpload.AutoSize = true;
            this.checkgenerateUpload.Location = new System.Drawing.Point(11, 424);
            this.checkgenerateUpload.Name = "checkgenerateUpload";
            this.checkgenerateUpload.Size = new System.Drawing.Size(126, 17);
            this.checkgenerateUpload.TabIndex = 24;
            this.checkgenerateUpload.Text = "Generate and upload";
            this.checkgenerateUpload.UseVisualStyleBackColor = true;
            // 
            // bttestupload
            // 
            this.bttestupload.Location = new System.Drawing.Point(389, 341);
            this.bttestupload.Name = "bttestupload";
            this.bttestupload.Size = new System.Drawing.Size(100, 40);
            this.bttestupload.TabIndex = 23;
            this.bttestupload.Text = "Test Upload";
            this.bttestupload.UseVisualStyleBackColor = true;
            this.bttestupload.Click += new System.EventHandler(this.bttestupload_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(90, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(477, 212);
            this.listBox1.TabIndex = 22;
            // 
            // txtdefault
            // 
            this.txtdefault.Location = new System.Drawing.Point(212, 46);
            this.txtdefault.Name = "txtdefault";
            this.txtdefault.Size = new System.Drawing.Size(355, 20);
            this.txtdefault.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Default";
            // 
            // txtpathFTP
            // 
            this.txtpathFTP.Location = new System.Drawing.Point(90, 98);
            this.txtpathFTP.Name = "txtpathFTP";
            this.txtpathFTP.Size = new System.Drawing.Size(477, 20);
            this.txtpathFTP.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Path File FTP";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(164, 341);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 40);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btbrowse
            // 
            this.btbrowse.Location = new System.Drawing.Point(576, 71);
            this.btbrowse.Name = "btbrowse";
            this.btbrowse.Size = new System.Drawing.Size(34, 23);
            this.btbrowse.TabIndex = 16;
            this.btbrowse.Text = "...";
            this.btbrowse.UseVisualStyleBackColor = true;
            this.btbrowse.Click += new System.EventHandler(this.btbrowse_Click);
            // 
            // txtfileLocal
            // 
            this.txtfileLocal.Location = new System.Drawing.Point(90, 73);
            this.txtfileLocal.Name = "txtfileLocal";
            this.txtfileLocal.Size = new System.Drawing.Size(477, 20);
            this.txtfileLocal.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Path File Local";
            // 
            // numtimertick
            // 
            this.numtimertick.Location = new System.Drawing.Point(90, 47);
            this.numtimertick.Name = "numtimertick";
            this.numtimertick.Size = new System.Drawing.Size(69, 20);
            this.numtimertick.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(285, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Upload FTP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Timer Tick";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtpathfileconfig);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.listEditorfile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editor File Default";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpathfileconfig
            // 
            this.txtpathfileconfig.Location = new System.Drawing.Point(47, 6);
            this.txtpathfileconfig.Name = "txtpathfileconfig";
            this.txtpathfileconfig.Size = new System.Drawing.Size(525, 20);
            this.txtpathfileconfig.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(384, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 417);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // listEditorfile
            // 
            this.listEditorfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listEditorfile.FormattingEnabled = true;
            this.listEditorfile.Location = new System.Drawing.Point(3, 32);
            this.listEditorfile.Name = "listEditorfile";
            this.listEditorfile.Size = new System.Drawing.Size(374, 407);
            this.listEditorfile.TabIndex = 0;
            this.listEditorfile.SelectedIndexChanged += new System.EventHandler(this.listEditorfile_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labthongbao);
            this.tabPage3.Controls.Add(this.txtfromfile);
            this.tabPage3.Controls.Add(this.checksetfromfile);
            this.tabPage3.Controls.Add(this.checkSetparentKey);
            this.tabPage3.Controls.Add(this.txtValukey);
            this.tabPage3.Controls.Add(this.txtfilename);
            this.tabPage3.Controls.Add(this.txtKeySet);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtpathfileSetkey);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(735, 449);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SetKey";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labthongbao
            // 
            this.labthongbao.AutoSize = true;
            this.labthongbao.BackColor = System.Drawing.Color.Yellow;
            this.labthongbao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labthongbao.ForeColor = System.Drawing.Color.Red;
            this.labthongbao.Location = new System.Drawing.Point(7, 425);
            this.labthongbao.Name = "labthongbao";
            this.labthongbao.Size = new System.Drawing.Size(45, 19);
            this.labthongbao.TabIndex = 8;
            this.labthongbao.Text = "label1";
            // 
            // txtfromfile
            // 
            this.txtfromfile.Enabled = false;
            this.txtfromfile.Location = new System.Drawing.Point(399, 105);
            this.txtfromfile.Name = "txtfromfile";
            this.txtfromfile.Size = new System.Drawing.Size(297, 20);
            this.txtfromfile.TabIndex = 7;
            // 
            // checksetfromfile
            // 
            this.checksetfromfile.AutoSize = true;
            this.checksetfromfile.Location = new System.Drawing.Point(285, 105);
            this.checksetfromfile.Name = "checksetfromfile";
            this.checksetfromfile.Size = new System.Drawing.Size(108, 17);
            this.checksetfromfile.TabIndex = 6;
            this.checksetfromfile.Text = "SetValue Fromfile";
            this.checksetfromfile.UseVisualStyleBackColor = true;
            this.checksetfromfile.CheckedChanged += new System.EventHandler(this.checksetfromfile_CheckedChanged);
            // 
            // checkSetparentKey
            // 
            this.checkSetparentKey.AutoSize = true;
            this.checkSetparentKey.Location = new System.Drawing.Point(62, 186);
            this.checkSetparentKey.Name = "checkSetparentKey";
            this.checkSetparentKey.Size = new System.Drawing.Size(137, 17);
            this.checkSetparentKey.TabIndex = 5;
            this.checkSetparentKey.Text = "Setkey for File in parent";
            this.checkSetparentKey.UseVisualStyleBackColor = true;
            // 
            // txtValukey
            // 
            this.txtValukey.Location = new System.Drawing.Point(62, 154);
            this.txtValukey.Name = "txtValukey";
            this.txtValukey.Size = new System.Drawing.Size(205, 20);
            this.txtValukey.TabIndex = 4;
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(62, 102);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(205, 20);
            this.txtfilename.TabIndex = 4;
            this.txtfilename.Text = "DuckJumperGame.txt";
            // 
            // txtKeySet
            // 
            this.txtKeySet.Location = new System.Drawing.Point(62, 128);
            this.txtKeySet.Name = "txtKeySet";
            this.txtKeySet.Size = new System.Drawing.Size(205, 20);
            this.txtKeySet.TabIndex = 4;
            this.txtKeySet.Text = "amazon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Value Key";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "FileName";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(702, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "....";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(434, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "....";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "KeySet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Path File";
            // 
            // txtpathfileSetkey
            // 
            this.txtpathfileSetkey.Location = new System.Drawing.Point(62, 52);
            this.txtpathfileSetkey.Name = "txtpathfileSetkey";
            this.txtpathfileSetkey.Size = new System.Drawing.Size(366, 20);
            this.txtpathfileSetkey.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 0;
            this.button2.Text = "Set Key";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gridControl1);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txtsplit);
            this.tabPage4.Controls.Add(this.txtfileloadama);
            this.tabPage4.Controls.Add(this.btloadkey);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(735, 449);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "LoadKey";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(8, 66);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(724, 331);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 151;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 552;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Split";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "File Name";
            // 
            // txtsplit
            // 
            this.txtsplit.Location = new System.Drawing.Point(78, 40);
            this.txtsplit.Name = "txtsplit";
            this.txtsplit.Size = new System.Drawing.Size(36, 20);
            this.txtsplit.TabIndex = 1;
            this.txtsplit.Text = "iOS";
            // 
            // txtfileloadama
            // 
            this.txtfileloadama.Location = new System.Drawing.Point(78, 13);
            this.txtfileloadama.Name = "txtfileloadama";
            this.txtfileloadama.Size = new System.Drawing.Size(410, 20);
            this.txtfileloadama.TabIndex = 1;
            // 
            // btloadkey
            // 
            this.btloadkey.Location = new System.Drawing.Point(505, 13);
            this.btloadkey.Name = "btloadkey";
            this.btloadkey.Size = new System.Drawing.Size(32, 23);
            this.btloadkey.TabIndex = 0;
            this.btloadkey.Text = "...";
            this.btloadkey.UseVisualStyleBackColor = true;
            this.btloadkey.Click += new System.EventHandler(this.btloadkey_Click);
            // 
            // btcreateOnAds
            // 
            this.btcreateOnAds.Location = new System.Drawing.Point(605, 124);
            this.btcreateOnAds.Name = "btcreateOnAds";
            this.btcreateOnAds.Size = new System.Drawing.Size(112, 23);
            this.btcreateOnAds.TabIndex = 25;
            this.btcreateOnAds.Text = "Create On ads";
            this.btcreateOnAds.UseVisualStyleBackColor = true;
            this.btcreateOnAds.Click += new System.EventHandler(this.btcreateOnAds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 475);
            this.Controls.Add(this.tabSetKey);
            this.Name = "Form1";
            this.Text = "Schedule Upload File FTP";
            this.tabSetKey.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtimertick)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerreset;
        private System.Windows.Forms.TabControl tabSetKey;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bttestupload;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtdefault;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpathFTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btbrowse;
        private System.Windows.Forms.TextBox txtfileLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numtimertick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox listEditorfile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpathfileconfig;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpathfileSetkey;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtValukey;
        private System.Windows.Forms.TextBox txtKeySet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkSetparentKey;
        private System.Windows.Forms.TextBox txtfromfile;
        private System.Windows.Forms.CheckBox checksetfromfile;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labthongbao;
        private System.Windows.Forms.CheckBox checkgenerateUpload;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsplit;
        private System.Windows.Forms.TextBox txtfileloadama;
        private System.Windows.Forms.Button btloadkey;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Button btcreateOnAds;
    }
}

