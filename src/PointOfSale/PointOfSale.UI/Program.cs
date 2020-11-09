using PointOfSale.UI.Reports.Sales.All;
using PointOfSale.UI.Views;
using System;
using System.Windows.Forms;

namespace PointOfSale.UI
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
            Application.Run(new LoginForm());
        }
    }
}
