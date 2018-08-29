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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.listEditorfile = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtpathfileconfig = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtimertick)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(734, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schedule Upload FTP";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Size = new System.Drawing.Size(734, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editor File Default";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // listEditorfile
            // 
            this.listEditorfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listEditorfile.FormattingEnabled = true;
            this.listEditorfile.Location = new System.Drawing.Point(3, 32);
            this.listEditorfile.Name = "listEditorfile";
            this.listEditorfile.Size = new System.Drawing.Size(454, 407);
            this.listEditorfile.TabIndex = 0;
            this.listEditorfile.SelectedIndexChanged += new System.EventHandler(this.listEditorfile_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(463, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(275, 417);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // txtpathfileconfig
            // 
            this.txtpathfileconfig.Location = new System.Drawing.Point(47, 6);
            this.txtpathfileconfig.Name = "txtpathfileconfig";
            this.txtpathfileconfig.Size = new System.Drawing.Size(525, 20);
            this.txtpathfileconfig.TabIndex = 2;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Schedule Upload File FTP";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtimertick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerreset;
        private System.Windows.Forms.TabControl tabControl1;
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
    }
}

