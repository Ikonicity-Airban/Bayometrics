namespace Bayometric
{
    partial class SettingsForm
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.settingsTab = new Guna.UI2.WinForms.Guna2TabControl();
            this.scannerTab = new System.Windows.Forms.TabPage();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.database = new System.Windows.Forms.TabPage();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // settingsTab
            // 
            this.settingsTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.settingsTab.Controls.Add(this.scannerTab);
            this.settingsTab.Controls.Add(this.aboutTab);
            this.settingsTab.Controls.Add(this.database);
            this.settingsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTab.ItemSize = new System.Drawing.Size(180, 40);
            this.settingsTab.Location = new System.Drawing.Point(0, 0);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.SelectedIndex = 0;
            this.settingsTab.Size = new System.Drawing.Size(800, 450);
            this.settingsTab.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.settingsTab.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.settingsTab.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.settingsTab.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.settingsTab.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.settingsTab.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.settingsTab.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.settingsTab.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.settingsTab.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.settingsTab.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.settingsTab.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.settingsTab.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.settingsTab.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.settingsTab.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.settingsTab.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.settingsTab.TabButtonSize = new System.Drawing.Size(180, 40);
            this.settingsTab.TabIndex = 0;
            this.settingsTab.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // scannerTab
            // 
            this.scannerTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.scannerTab.Location = new System.Drawing.Point(184, 4);
            this.scannerTab.Name = "scannerTab";
            this.scannerTab.Padding = new System.Windows.Forms.Padding(3);
            this.scannerTab.Size = new System.Drawing.Size(612, 442);
            this.scannerTab.TabIndex = 0;
            this.scannerTab.Text = "Scanners";
            // 
            // aboutTab
            // 
            this.aboutTab.Location = new System.Drawing.Point(184, 4);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTab.Size = new System.Drawing.Size(612, 442);
            this.aboutTab.TabIndex = 1;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(184, 4);
            this.database.Name = "database";
            this.database.Padding = new System.Windows.Forms.Padding(3);
            this.database.Size = new System.Drawing.Size(612, 442);
            this.database.TabIndex = 2;
            this.database.Text = "Database";
            this.database.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.settingsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2TabControl settingsTab;
        private System.Windows.Forms.TabPage scannerTab;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.TabPage database;
    }
}