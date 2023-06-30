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
        private static Nffv Engine { get;  } 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RunApplication.Run(Engine);
        }
    }
}
