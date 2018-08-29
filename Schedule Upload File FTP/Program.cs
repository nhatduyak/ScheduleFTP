using System;
using System.Collections.Generic;

using System.Windows.Forms;
using ConfigCOMPortBank;

namespace Schedule_Upload_File_FTP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CTLConfig.GetConfiguration();
            Application.Run(new Form1());
        }
    }
}
