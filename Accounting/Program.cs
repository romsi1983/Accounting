using System;
using System.Windows.Forms;


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
