namespace Encryption_Machine.Windows.UserPanel
{
    partial class codesettings
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.authenticationPanel = new System.Windows.Forms.Panel();
            this.logCreate = new System.Windows.Forms.Label();
            this.logIn = new System.Windows.Forms.Button();
            this.codepassword = new System.Windows.Forms.TextBox();
            this.codename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.before = new Encryption_Machine.Windows.UserPanel.CodeSettings.before();
            this.after = new Encryption_Machine.Windows.UserPanel.CodeSettings.after();
            this.authenticationPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // authenticationPanel
            // 
            this.authenticationPanel.Controls.Add(this.logCreate);
            this.authenticationPanel.Controls.Add(this.logIn);
            this.authenticationPanel.Controls.Add(this.codepassword);
            this.authenticationPanel.Controls.Add(this.codename);
            this.authenticationPanel.Controls.Add(this.label1);
            this.authenticationPanel.Controls.Add(this.label3);
            this.authenticationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.authenticationPanel.Location = new System.Drawing.Point(0, 0);
            this.authenticationPanel.Name = "authenticationPanel";
            this.authenticationPanel.Size = new System.Drawing.Size(884, 70);
            this.authenticationPanel.TabIndex = 0;
            // 
            // logCreate
            // 
            this.logCreate.AutoSize = true;
            this.logCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logCreate.ForeColor = System.Drawing.Color.Maroon;
            this.logCreate.Location = new System.Drawing.Point(270, 47);
            this.logCreate.Name = "logCreate";
            this.logCreate.Size = new System.Drawing.Size(266, 20);
            this.logCreate.TabIndex = 89;
            this.logCreate.Text = "LOG INFO UNVISIABLE AT START";
            this.logCreate.Visible = false;
            // 
            // logIn
            // 
            this.logIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logIn.ForeColor = System.Drawing.Color.Aqua;
            this.logIn.Location = new System.Drawing.Point(677, 10);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(141, 47);
            this.logIn.TabIndex = 70;
            this.logIn.Text = "Log in";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // codepassword
            // 
            this.codepassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.codepassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.codepassword.Location = new System.Drawing.Point(535, 22);
            this.codepassword.Name = "codepassword";
            this.codepassword.PasswordChar = '*';
            this.codepassword.Size = new System.Drawing.Size(126, 22);
            this.codepassword.TabIndex = 66;
            this.codepassword.Tag = "char";
            // 
            // codename
            // 
            this.codename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.codename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.codename.Location = new System.Drawing.Point(175, 23);
            this.codename.Name = "codename";
            this.codename.Size = new System.Drawing.Size(126, 22);
            this.codename.TabIndex = 65;
            this.codename.Tag = "char";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(307, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Code admin password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(41, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Code name:";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.before);
            this.mainPanel.Controls.Add(this.after);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(884, 412);
            this.mainPanel.TabIndex = 1;
            // 
            // before
            // 
            this.before.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.before.Location = new System.Drawing.Point(0, 0);
            this.before.Name = "before";
            this.before.Size = new System.Drawing.Size(884, 412);
            this.before.TabIndex = 0;
            // 
            // after
            // 
            this.after.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.after.Location = new System.Drawing.Point(0, 0);
            this.after.Name = "after";
            this.after.Size = new System.Drawing.Size(884, 412);
            this.after.TabIndex = 1;
            // 
            // codesettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.authenticationPanel);
            this.Name = "codesettings";
            this.Size = new System.Drawing.Size(884, 482);
            this.authenticationPanel.ResumeLayout(false);
            this.authenticationPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel authenticationPanel;
        private System.Windows.Forms.Panel mainPanel;
        private CodeSettings.before before;
        private CodeSettings.after after;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codepassword;
        private System.Windows.Forms.TextBox codename;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label logCreate;
    }
}
