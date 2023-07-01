using Neurotec.Biometrics;
using System;
using System.Windows.Forms;

namespace Bayometric
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm(Nffv engine)
        {
            InitializeComponent();
            Engine = engine;
        }

        public Nffv Engine { get; }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dispose();
            RunApplication runApplication = new RunApplication(Engine);
            runApplication.Run();
        }


        #region Fields

        public string Fullname
        {
            get
            {
                return nameTB.Text;
            }
            set
            {
                nameTB.Text = value;
            }
        }
        public string Username
        {
            get
            {
                return usernameTB.Text;
            }
            set
            {
                usernameTB.Text = value;
            }
        }
        public string RegNo
        {
            get
            {
                return regnoTB.Text;
            }
            set
            {
                regnoTB.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return passwordTB.Text;
            }
            set
            {
                passwordTB.Text = value;
            }
        }
        public string ConfirmPassword
        {
            get
            {
                return ConfirmPassTB.Text;
            }
            set
            {
                ConfirmPassTB.Text = value;
            }
        }
        #endregion

        private void SubmitBtn_Click(object sender, System.EventArgs e)
        {
            if (!ValidateFields()) return;

            VerificationForm verificationForm = new VerificationForm(Username, Fullname, RegNo, "Enroll", Engine);

            if (verificationForm.ShowDialog() == DialogResult.OK)
            {
                Dispose();
                DialogResult = DialogResult.OK;
                Engine.Dispose();
            }
        }

        private bool ValidateFields()
        {
            if (Username.Length < 1 ||
                Fullname.Length < 1 ||
                Password.Length < 1 ||
                ConfirmPassword.Length < 1 ||
                RegNo.Length < 1)
            {
                MessageBox.Show("Please fill all the fields",
                    "Error - Incomplete fields entries",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
    }
}
