﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ICDIBasic
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
            Application.Run(MainForm.GetInstance());
        }
    }
}

//test lw push
//test lw push 2
//test lw push 3