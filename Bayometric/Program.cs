using Neurotec.Biometrics;
using System;
using System.Windows.Forms;

namespace Bayometric
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                RunApplication runApplication = new RunApplication();
                runApplication.Run();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
