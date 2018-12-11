namespace Encryption_Machine.Windows.UserPanel.CodeSettings
{
    partial class after
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
            this.codeView = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.changeChar = new System.Windows.Forms.Button();
            this.changeName = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.changeAdminPassword = new System.Windows.Forms.Button();
            this.charListShow = new System.Windows.Forms.ComboBox();
            this.newCode = new System.Windows.Forms.TextBox();
            this.newName = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.newAdminPassword = new System.Windows.Forms.TextBox();
            this.charListChange = new System.Windows.Forms.ComboBox();
            this.logCreate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.codeView)).BeginInit();
            this.SuspendLayout();
            // 
            // codeView
            // 
            this.codeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeView.Location = new System.Drawing.Point(3, 259);
            this.codeView.Name = "codeView";
            this.codeView.ReadOnly = true;
            this.codeView.Size = new System.Drawing.Size(878, 150);
            this.codeView.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refresh.ForeColor = System.Drawing.Color.Aqua;
            this.refresh.Location = new System.Drawing.Point(3, 223);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(141, 30);
            this.refresh.TabIndex = 70;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete.ForeColor = System.Drawing.Color.Aqua;
            this.delete.Location = new System.Drawing.Point(740, 223);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(141, 30);
            this.delete.TabIndex = 71;
            this.delete.Text = "Delete code";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // show
            // 
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.show.ForeColor = System.Drawing.Color.Aqua;
            this.show.Location = new System.Drawing.Point(197, 20);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(202, 30);
            this.show.TabIndex = 72;
            this.show.Text = "Show char";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // changeChar
            // 
            this.changeChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeChar.ForeColor = System.Drawing.Color.Aqua;
            this.changeChar.Location = new System.Drawing.Point(197, 56);
            this.changeChar.Name = "changeChar";
            this.changeChar.Size = new System.Drawing.Size(202, 30);
            this.changeChar.TabIndex = 73;
            this.changeChar.Text = "Change char";
            this.changeChar.UseVisualStyleBackColor = true;
            this.changeChar.Click += new System.EventHandler(this.changeChar_Click);
            // 
            // changeName
            // 
            this.changeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeName.ForeColor = System.Drawing.Color.Aqua;
            this.changeName.Location = new System.Drawing.Point(197, 92);
            this.changeName.Name = "changeName";
            this.changeName.Size = new System.Drawing.Size(202, 30);
            this.changeName.TabIndex = 74;
            this.changeName.Text = "Change name";
            this.changeName.UseVisualStyleBackColor = true;
            this.changeName.Click += new System.EventHandler(this.changeName_Click);
            // 
            // changePassword
            // 
            this.changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changePassword.ForeColor = System.Drawing.Color.Aqua;
            this.changePassword.Location = new System.Drawing.Point(197, 128);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(202, 30);
            this.changePassword.TabIndex = 75;
            this.changePassword.Text = "Change password";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // changeAdminPassword
            // 
            this.changeAdminPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeAdminPassword.ForeColor = System.Drawing.Color.Aqua;
            this.changeAdminPassword.Location = new System.Drawing.Point(197, 164);
            this.changeAdminPassword.Name = "changeAdminPassword";
            this.changeAdminPassword.Size = new System.Drawing.Size(202, 30);
            this.changeAdminPassword.TabIndex = 76;
            this.changeAdminPassword.Text = "Change admin password";
            this.changeAdminPassword.UseVisualStyleBackColor = true;
            this.changeAdminPassword.Click += new System.EventHandler(this.changeAdminPassword_Click);
            // 
            // charListShow
            // 
            this.charListShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charListShow.FormattingEnabled = true;
            this.charListShow.Items.AddRange(new object[] {
            "charA",
            "charB",
            "charC",
            "charD",
            "charC",
            "charE",
            "charF",
            "charG",
            "charH",
            "charI",
            "charJ",
            "charK",
            "charL",
            "charM",
            "charN",
            "charO",
            "charP",
            "charQ",
            "charR",
            "charS",
            "charT",
            "charU",
            "charV",
            "charW",
            "charX",
            "charY",
            "charZ",
            "char1",
            "char2",
            "char3",
            "char4",
            "char5",
            "char6",
            "char7",
            "char8",
            "char9",
            "char0",
            "charDOT",
            "charSPACE"});
            this.charListShow.Location = new System.Drawing.Point(405, 20);
            this.charListShow.Name = "charListShow";
            this.charListShow.Size = new System.Drawing.Size(135, 28);
            this.charListShow.TabIndex = 77;
            // 
            // newCode
            // 
            this.newCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newCode.Location = new System.Drawing.Point(405, 56);
            this.newCode.Name = "newCode";
            this.newCode.Size = new System.Drawing.Size(135, 28);
            this.newCode.TabIndex = 78;
            this.newCode.Tag = "char";
            // 
            // newName
            // 
            this.newName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newName.Location = new System.Drawing.Point(405, 92);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(135, 28);
            this.newName.TabIndex = 80;
            this.newName.Tag = "char";
            // 
            // newPassword
            // 
            this.newPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newPassword.Location = new System.Drawing.Point(405, 128);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(135, 28);
            this.newPassword.TabIndex = 81;
            this.newPassword.Tag = "char";
            // 
            // newAdminPassword
            // 
            this.newAdminPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newAdminPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newAdminPassword.Location = new System.Drawing.Point(405, 164);
            this.newAdminPassword.Name = "newAdminPassword";
            this.newAdminPassword.Size = new System.Drawing.Size(135, 28);
            this.newAdminPassword.TabIndex = 82;
            this.newAdminPassword.Tag = "char";
            // 
            // charListChange
            // 
            this.charListChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charListChange.FormattingEnabled = true;
            this.charListChange.Items.AddRange(new object[] {
            "charA",
            "charB",
            "charC",
            "charD",
            "charC",
            "charE",
            "charF",
            "charG",
            "charH",
            "charI",
            "charJ",
            "charK",
            "charL",
            "charM",
            "charN",
            "charO",
            "charP",
            "charQ",
            "charR",
            "charS",
            "charT",
            "charU",
            "charV",
            "charW",
            "charX",
            "charY",
            "charZ",
            "char1",
            "char2",
            "char3",
            "char4",
            "char5",
            "char6",
            "char7",
            "char8",
            "char9",
            "char0",
            "charDOT",
            "charSPACE"});
            this.charListChange.Location = new System.Drawing.Point(546, 56);
            this.charListChange.Name = "charListChange";
            this.charListChange.Size = new System.Drawing.Size(135, 28);
            this.charListChange.TabIndex = 83;
            // 
            // logCreate
            // 
            this.logCreate.AutoSize = true;
            this.logCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logCreate.ForeColor = System.Drawing.Color.Maroon;
            this.logCreate.Location = new System.Drawing.Point(222, 212);
            this.logCreate.Name = "logCreate";
            this.logCreate.Size = new System.Drawing.Size(459, 39);
            this.logCreate.TabIndex = 90;
            this.logCreate.Text = "PRESS REFRESH BUTTON";
            // 
            // after
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.logCreate);
            this.Controls.Add(this.charListChange);
            this.Controls.Add(this.newAdminPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.newName);
            this.Controls.Add(this.newCode);
            this.Controls.Add(this.charListShow);
            this.Controls.Add(this.changeAdminPassword);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.changeName);
            this.Controls.Add(this.changeChar);
            this.Controls.Add(this.show);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.codeView);
            this.Name = "after";
            this.Size = new System.Drawing.Size(884, 412);
            ((System.ComponentModel.ISupportInitialize)(this.codeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView codeView;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button changeChar;
        private System.Windows.Forms.Button changeName;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Button changeAdminPassword;
        private System.Windows.Forms.ComboBox charListShow;
        private System.Windows.Forms.TextBox newCode;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox newAdminPassword;
        private System.Windows.Forms.ComboBox charListChange;
        private System.Windows.Forms.Label logCreate;
    }
}
