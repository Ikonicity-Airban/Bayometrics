using Neurotec.Biometrics;
using System.Windows.Forms;

namespace Bayometric
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(Nffv engine)
        {
            InitializeComponent();
            Engine = engine;
        }
        public Nffv Engine { get; }
    }
}
