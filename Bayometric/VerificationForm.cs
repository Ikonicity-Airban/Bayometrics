using Neurotec.Biometrics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bayometric
{
    public partial class VerificationForm : Form
    {
        private Nffv engine;

        public VerificationForm(string _username, string _fullname, string _regno, string option)
        {
            InitializeComponent();
            Option = option;
            usernameLB.Text = _username;
            fullnameLB.Text = _fullname;
            regNO.Text = _regno;
            actionBtn.Text = option;
        }

        public VerificationForm(string _username, string _fullname, string _regno, string option, Nffv engine) : this(_username, _fullname, _regno, option)
        {
            this.engine = engine;
        }

        public string Option { get; private set; }

        private void ActionBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
