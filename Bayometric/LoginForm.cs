﻿using Neurotec.Biometrics;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(Nffv engine)
        {
            Engine = engine;
        }

        public Nffv Engine { get; }
    }
}
