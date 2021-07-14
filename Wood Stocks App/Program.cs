// namespaces being used for program.
using System;
using System.Windows.Forms;
using Wood_Stocks_App;

namespace Wood_Stocks_Application
{
    // 1 of 2 classes.
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // When appliaction is launched, program is entered through Main method.
            // WoodStocks user interface is opened through Application.Run(new WoodStocks());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WoodStocks());
        }
    }
}
