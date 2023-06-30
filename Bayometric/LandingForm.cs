using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Bayometric
{
    public partial class LandingForm : Form
    {

        public Color defaultBackColor { get; set; }
        public int DefaultWidth { get; set; }
        public int DefaultHeight { get; set; }
        public string NextForm { get; set; } = string.Empty;

        public LandingForm()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            Guna2GradientPanel panel = (Guna2GradientPanel)sender;
            NextForm = panel.Name.ToString();
            defaultBackColor = panel.BackColor;
            DefaultWidth = panel.Width;
            DefaultHeight = panel.Height;
            FocusOut(LoginPanel);
            FocusOut(CreateAcctPanel);
            FocusOut(SettingsPanel);
            FocusIn(panel);
        }
        private void FocusIn(Guna2GradientPanel panel)
        {
            panel.FillColor = Color.DarkSlateBlue;
            panel.FillColor2 = Color.DarkSlateBlue;
            panel.Width += 10;
            panel.Height += 10;
        }

        private void FocusOut(Guna2GradientPanel panel)
        {
            panel.FillColor = defaultBackColor;
            panel.FillColor2 = defaultBackColor;
            panel.Width = DefaultWidth;
            panel.Height = DefaultHeight;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }
        
        private void MouseIn(object sender, EventArgs e)
        {
            Guna2GradientPanel panel = (Guna2GradientPanel)sender;
            if (panel.Controls.Contains(panelPB))
            {
                panel.Controls.Remove(panelPB);
            }
            panel.Controls.Add(panelPB);
        }

        private void MouseOut(object sender, EventArgs e)
        {
            Guna2GradientPanel panel = (Guna2GradientPanel)sender;

            if (panel.Controls.Contains(panelPB))
            {
                panel.Controls.Remove(panelPB);
            }
        }
    }
}
