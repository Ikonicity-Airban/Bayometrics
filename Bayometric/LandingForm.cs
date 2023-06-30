using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Bayometric
{
    public partial class LandingForm : Form
    {

        private readonly Color defaultBackColor = Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));

        public string NextForm { get; set; } = string.Empty;

        public LandingForm()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            Guna2GradientPanel panel = (Guna2GradientPanel)sender;
            SetSelected(panel);
            NextForm = panel.Name.ToString();
        }

        private void SetSelected(Guna2GradientPanel panel)
        {
            LoginPanel.FillColor = defaultBackColor;
            LoginPanel.FillColor2 = defaultBackColor;
            CreateAcctPanel.FillColor = defaultBackColor;
            CreateAcctPanel.FillColor2 = defaultBackColor;
            SettingsPanel.FillColor = defaultBackColor;
            SettingsPanel.FillColor2 = defaultBackColor;
            panel.FillColor = Color.DarkSlateBlue;
            panel.FillColor2 = Color.SlateBlue;
                    }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }
    }
}
