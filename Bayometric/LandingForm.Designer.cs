namespace Bayometric
{
    partial class LandingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            this.exitBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.LoginPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CreateAcctPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SettingsPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.submitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.headerComponent1 = new Bayometric.HeaderComponent(this.components);
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPB)).BeginInit();
            this.CreateAcctPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BorderRadius = 2;
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.exitBtn.IconColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(537, 14);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 28);
            this.exitBtn.TabIndex = 0;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.LoginPanel.BorderRadius = 2;
            this.LoginPanel.BorderThickness = 1;
            this.LoginPanel.Controls.Add(this.panelPB);
            this.LoginPanel.Controls.Add(this.guna2HtmlLabel1);
            this.LoginPanel.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.LoginPanel.FillColor = System.Drawing.Color.Transparent;
            this.LoginPanel.FillColor2 = System.Drawing.Color.Transparent;
            this.LoginPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.LoginPanel.Location = new System.Drawing.Point(54, 165);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(5);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(481, 69);
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.Click += new System.EventHandler(this.Tile_Click);
            this.LoginPanel.MouseEnter += new System.EventHandler(this.MouseIn);
            this.LoginPanel.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // panelPB
            // 
            this.panelPB.BackColor = System.Drawing.Color.Transparent;
            this.panelPB.BackgroundImage = global::Bayometric.Properties.Resources.icons8_arrow_right_32__1_;
            this.panelPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPB.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPB.FillColor = System.Drawing.Color.Transparent;
            this.panelPB.ImageRotate = 0F;
            this.panelPB.Location = new System.Drawing.Point(403, 0);
            this.panelPB.Name = "panelPB";
            this.panelPB.Size = new System.Drawing.Size(78, 69);
            this.panelPB.TabIndex = 1;
            this.panelPB.TabStop = false;
            this.panelPB.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(51, 20);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(57, 27);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Login";
            // 
            // CreateAcctPanel
            // 
            this.CreateAcctPanel.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.CreateAcctPanel.BorderRadius = 2;
            this.CreateAcctPanel.BorderThickness = 1;
            this.CreateAcctPanel.Controls.Add(this.guna2HtmlLabel5);
            this.CreateAcctPanel.Controls.Add(this.guna2HtmlLabel2);
            this.CreateAcctPanel.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.CreateAcctPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CreateAcctPanel.Location = new System.Drawing.Point(54, 257);
            this.CreateAcctPanel.Margin = new System.Windows.Forms.Padding(5);
            this.CreateAcctPanel.Name = "CreateAcctPanel";
            this.CreateAcctPanel.Size = new System.Drawing.Size(481, 70);
            this.CreateAcctPanel.TabIndex = 1;
            this.CreateAcctPanel.Click += new System.EventHandler(this.Tile_Click);
            this.CreateAcctPanel.MouseEnter += new System.EventHandler(this.MouseIn);
            this.CreateAcctPanel.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(51, 42);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(100, 18);
            this.guna2HtmlLabel5.TabIndex = 0;
            this.guna2HtmlLabel5.Text = "* For first time users";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(51, 15);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(165, 27);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Create Account";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.SettingsPanel.BorderRadius = 2;
            this.SettingsPanel.BorderThickness = 1;
            this.SettingsPanel.Controls.Add(this.guna2HtmlLabel4);
            this.SettingsPanel.Controls.Add(this.guna2HtmlLabel3);
            this.SettingsPanel.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.SettingsPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.SettingsPanel.Location = new System.Drawing.Point(54, 349);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(481, 75);
            this.SettingsPanel.TabIndex = 1;
            this.SettingsPanel.Click += new System.EventHandler(this.Tile_Click);
            this.SettingsPanel.MouseEnter += new System.EventHandler(this.MouseIn);
            this.SettingsPanel.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(51, 44);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(77, 18);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "(Admins Only)";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(51, 18);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(80, 27);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Settings";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.MediumPurple;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(201, 62);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(170, 46);
            this.guna2HtmlLabel6.TabIndex = 0;
            this.guna2HtmlLabel6.Text = "Bayometrix";
            // 
            // submitBtn
            // 
            this.submitBtn.BorderRadius = 2;
            this.submitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.submitBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(432, 451);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(103, 35);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Ok";
            this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(589, 557);
            this.Controls.Add(this.CreateAcctPanel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.exitBtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LandingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerificationForm";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPB)).EndInit();
            this.CreateAcctPanel.ResumeLayout(false);
            this.CreateAcctPanel.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox exitBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel LoginPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2GradientPanel SettingsPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2GradientPanel CreateAcctPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public HeaderComponent headerComponent1;
        private Guna.UI2.WinForms.Guna2Button submitBtn;
        private Guna.UI2.WinForms.Guna2PictureBox panelPB;
    }
}