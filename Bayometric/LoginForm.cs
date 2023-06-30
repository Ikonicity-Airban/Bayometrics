using Neurotec.Biometrics;
using System;
using System.Windows.Forms;

namespace Bayometric
{
    public partial class LoginForm : Form
    {
        public LoginForm(Nffv engine)
        {
            InitializeComponent();
            Engine = engine;
        }

        public Nffv Engine { get; }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dispose();
            RunApplication.Run(Engine);
        }

        public string UserName
        {
            get
            {
                return usernameTB.Text.Trim();
            }
            set { usernameTB.Text = value; }
        }

        public string Password
        {
            get { return passwordTB.Text.Trim(); }
            set { passwordTB.Text = value; }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (Password.Length < 1 || UserName.Length < 1)
            {
                MessageBox.Show("Password and Username Fields cannot be empty",
                    "Invalid Username or Password", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            MinimizeBox = true;
            VerificationForm verificationForm = new VerificationForm(UserName, "", "", "Verify", Engine);

            if (verificationForm.ShowDialog() == DialogResult.OK)
            {
                Dispose();
                DialogResult = DialogResult.OK;
                Engine.Dispose();
            }
        }
    }
}
