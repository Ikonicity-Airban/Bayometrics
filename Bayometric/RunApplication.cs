﻿using Neurotec.Biometrics;
using System.Windows.Forms;

namespace Bayometric
{
    internal class RunApplication
    {

        public static void Run(Nffv _engine)
        {
            LandingForm landingForm = new LandingForm();

            if (landingForm.ShowDialog() is DialogResult.OK)
            {
                Form nextForm = null;
                switch (landingForm.NextForm)
                {
                    case "LoginPanel":
                        nextForm = new LoginForm(_engine);
                        break;
                    case "CreateAcctPanel" :
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
}
