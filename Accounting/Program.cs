using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using Accounting.Models;

namespace Accounting
{
    static class Program
    {
        /// <summary>
        /// The main entry poINTEGER for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var sql = new SqLiteHelper();

            //var test4 = sql.FindinTable<Organization>();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accounting());
        }

 
    }
}
