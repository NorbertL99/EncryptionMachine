namespace Encryption_Machine
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.codesettingsButton = new System.Windows.Forms.Button();
            this.createcodeButton = new System.Windows.Forms.Button();
            this.encryptdecryptButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.dashboard = new Encryption_Machine.Windows.UserPanels.dashboard();
            this.encryptdecrypt = new Encryption_Machine.Windows.UserPanels.encryptdecrypt();
            this.createcode = new Encryption_Machine.Windows.UserPanel.createcode();
            this.codesettings = new Encryption_Machine.Windows.UserPanel.codesettings();
            this.menuPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.menuPanel.Controls.Add(this.codesettingsButton);
            this.menuPanel.Controls.Add(this.createcodeButton);
            this.menuPanel.Controls.Add(this.encryptdecryptButton);
            this.menuPanel.Controls.Add(this.dashboardButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(884, 80);
            this.menuPanel.TabIndex = 0;
            // 
            // codesettingsButton
            // 
            this.codesettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codesettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.codesettingsButton.ForeColor = System.Drawing.Color.Aqua;
            this.codesettingsButton.Location = new System.Drawing.Point(609, 12);
            this.codesettingsButton.Name = "codesettingsButton";
            this.codesettingsButton.Size = new System.Drawing.Size(160, 55);
            this.codesettingsButton.TabIndex = 4;
            this.codesettingsButton.Text = "Code settings";
            this.codesettingsButton.UseVisualStyleBackColor = true;
            this.codesettingsButton.Click += new System.EventHandler(this.codesettingsButton_Click);
            // 
            // createcodeButton
            // 
            this.createcodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createcodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createcodeButton.ForeColor = System.Drawing.Color.Aqua;
            this.createcodeButton.Location = new System.Drawing.Point(443, 12);
            this.createcodeButton.Name = "createcodeButton";
            this.createcodeButton.Size = new System.Drawing.Size(160, 55);
            this.createcodeButton.TabIndex = 2;
            this.createcodeButton.Text = "Create code";
            this.createcodeButton.UseVisualStyleBackColor = true;
            this.createcodeButton.Click += new System.EventHandler(this.createcodeButton_Click);
            // 
            // encryptdecryptButton
            // 
            this.encryptdecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptdecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encryptdecryptButton.ForeColor = System.Drawing.Color.Aqua;
            this.encryptdecryptButton.Location = new System.Drawing.Point(277, 12);
            this.encryptdecryptButton.Name = "encryptdecryptButton";
            this.encryptdecryptButton.Size = new System.Drawing.Size(160, 55);
            this.encryptdecryptButton.TabIndex = 1;
            this.encryptdecryptButton.Text = "Encrypt / Decrypt";
            this.encryptdecryptButton.UseVisualStyleBackColor = true;
            this.encryptdecryptButton.Click += new System.EventHandler(this.encryptdecryptButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dashboardButton.ForeColor = System.Drawing.Color.Aqua;
            this.dashboardButton.Location = new System.Drawing.Point(111, 12);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(160, 55);
            this.dashboardButton.TabIndex = 0;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.contentPanel.Controls.Add(this.dashboard);
            this.contentPanel.Controls.Add(this.encryptdecrypt);
            this.contentPanel.Controls.Add(this.createcode);
            this.contentPanel.Controls.Add(this.codesettings);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(884, 482);
            this.contentPanel.TabIndex = 1;
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.dashboard.Location = new System.Drawing.Point(0, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(884, 482);
            this.dashboard.TabIndex = 3;
            // 
            // encryptdecrypt
            // 
            this.encryptdecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.encryptdecrypt.Location = new System.Drawing.Point(0, 0);
            this.encryptdecrypt.Name = "encryptdecrypt";
            this.encryptdecrypt.Size = new System.Drawing.Size(884, 482);
            this.encryptdecrypt.TabIndex = 2;
            // 
            // createcode
            // 
            this.createcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.createcode.Location = new System.Drawing.Point(0, 0);
            this.createcode.Name = "createcode";
            this.createcode.Size = new System.Drawing.Size(884, 482);
            this.createcode.TabIndex = 1;
            // 
            // codesettings
            // 
            this.codesettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.codesettings.Location = new System.Drawing.Point(0, 0);
            this.codesettings.Name = "codesettings";
            this.codesettings.Size = new System.Drawing.Size(884, 482);
            this.codesettings.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption Machine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button codesettingsButton;
        private System.Windows.Forms.Button createcodeButton;
        private System.Windows.Forms.Button encryptdecryptButton;
        private System.Windows.Forms.Button dashboardButton;
        private Windows.UserPanels.encryptdecrypt encryptdecrypt;
        private Windows.UserPanel.createcode createcode;
        private Windows.UserPanel.codesettings codesettings;
        private Windows.UserPanels.dashboard dashboard;
    }
}

