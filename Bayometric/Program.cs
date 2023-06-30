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
        private static Nffv Engine { get; } = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                RunApplication.Run(Engine);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Engine?.Dispose();
            }
        }
    }
}
