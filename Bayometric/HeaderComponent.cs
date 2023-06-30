using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayometric
{
    public partial class HeaderComponent : Component
    {
        public HeaderComponent()
        {
            InitializeComponent();
        }

        public HeaderComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
