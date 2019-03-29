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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accounting());
        }

 
    }
}
