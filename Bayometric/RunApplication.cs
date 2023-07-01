using Neurotec.Biometrics;
using System;
using System.Windows.Forms;

namespace Bayometric
{
    public class RunApplication
    {
        Nffv _engine = null;

        public RunApplication()
        {
            _engine = null;
        }

        public RunApplication(Nffv engine) { 
            _engine = engine;
       }
        public void Run()
        {
            try
            {
                ChooseScannerForm cSForm = new ChooseScannerForm();
                if (cSForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MessageBox.Show($"{cSForm.FingerprintDatabase}  \n " +
                            $"{cSForm.FingerprintDatabasePassword} \n" +
                            $"{cSForm.ScannerString}");


                        _engine = new Nffv(cSForm.FingerprintDatabase, 
                            cSForm.FingerprintDatabasePassword, 
                            cSForm.ScannerString);
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("Failed to initialize Nffv or create/load database.\r\n" +
                        "Please check if:\r\n - Provided password is correct;\r\n - Database filename is correct;\r\n" +
                        " - Scanners are used properly.\r\n " + ex.Message, 
                        "Nffv C# Sample", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    LandingForm landingForm = new LandingForm();

                    if (landingForm.ShowDialog() is DialogResult.OK)
                    {
                        Form nextForm = null;
                        switch (landingForm.NextForm)
                        {
                            case "LoginPanel":
                                nextForm = new LoginForm(_engine);
                                break;
                            case "CreateAcctPanel":
                                nextForm = new CreateAccountForm(_engine);
                                break;
                            case "SettingsPanel":
                                nextForm = new SettingsForm(_engine);
                                break;
                            default:
                                break;
                        }
                        if (nextForm.ShowDialog() == DialogResult.OK)
                        {
                            nextForm.Dispose();
                            Application.Run(new ExamsForm());
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format("An error has occured: {0}", ex.Message), "Nffv C# Sample",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _engine?.Dispose();
            }
        }

    }
}
