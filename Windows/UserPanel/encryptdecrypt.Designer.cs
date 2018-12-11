namespace Encryption_Machine.Windows.UserPanels
{
    partial class encryptdecrypt
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
            this.textRTB = new System.Windows.Forms.RichTextBox();
            this.effectRTB = new System.Windows.Forms.RichTextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codeName = new System.Windows.Forms.TextBox();
            this.codePassword = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.clereCodeInfo = new System.Windows.Forms.Button();
            this.loadFromText = new System.Windows.Forms.Button();
            this.saveFileText = new System.Windows.Forms.Button();
            this.saveFileEffect = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.clearText = new System.Windows.Forms.Button();
            this.clearEffect = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.readDialog = new System.Windows.Forms.OpenFileDialog();
            this.logCreate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textRTB
            // 
            this.textRTB.Location = new System.Drawing.Point(31, 46);
            this.textRTB.Name = "textRTB";
            this.textRTB.Size = new System.Drawing.Size(300, 300);
            this.textRTB.TabIndex = 0;
            this.textRTB.Text = "";
            // 
            // effectRTB
            // 
            this.effectRTB.Location = new System.Drawing.Point(359, 46);
            this.effectRTB.Name = "effectRTB";
            this.effectRTB.ReadOnly = true;
            this.effectRTB.Size = new System.Drawing.Size(300, 300);
            this.effectRTB.TabIndex = 1;
            this.effectRTB.Text = "";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label38.ForeColor = System.Drawing.Color.Aqua;
            this.label38.Location = new System.Drawing.Point(145, 12);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(67, 31);
            this.label38.TabIndex = 52;
            this.label38.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(473, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 53;
            this.label1.Text = "Effect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(708, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 54;
            this.label2.Text = "Code info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(712, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Code name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(695, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Code password";
            // 
            // codeName
            // 
            this.codeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.codeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.codeName.Location = new System.Drawing.Point(714, 108);
            this.codeName.Name = "codeName";
            this.codeName.Size = new System.Drawing.Size(117, 22);
            this.codeName.TabIndex = 65;
            this.codeName.Tag = "char";
            // 
            // codePassword
            // 
            this.codePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.codePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.codePassword.Location = new System.Drawing.Point(714, 171);
            this.codePassword.Name = "codePassword";
            this.codePassword.PasswordChar = '*';
            this.codePassword.Size = new System.Drawing.Size(117, 22);
            this.codePassword.TabIndex = 66;
            this.codePassword.Tag = "char";
            // 
            // encrypt
            // 
            this.encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encrypt.ForeColor = System.Drawing.Color.Aqua;
            this.encrypt.Location = new System.Drawing.Point(31, 352);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(141, 30);
            this.encrypt.TabIndex = 67;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decrypt.ForeColor = System.Drawing.Color.Aqua;
            this.decrypt.Location = new System.Drawing.Point(190, 352);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(141, 30);
            this.decrypt.TabIndex = 68;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // clereCodeInfo
            // 
            this.clereCodeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clereCodeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clereCodeInfo.ForeColor = System.Drawing.Color.Aqua;
            this.clereCodeInfo.Location = new System.Drawing.Point(703, 211);
            this.clereCodeInfo.Name = "clereCodeInfo";
            this.clereCodeInfo.Size = new System.Drawing.Size(141, 30);
            this.clereCodeInfo.TabIndex = 69;
            this.clereCodeInfo.Text = "Clear code info";
            this.clereCodeInfo.UseVisualStyleBackColor = true;
            this.clereCodeInfo.Click += new System.EventHandler(this.clereCodeInfo_Click);
            // 
            // loadFromText
            // 
            this.loadFromText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFromText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadFromText.ForeColor = System.Drawing.Color.Aqua;
            this.loadFromText.Location = new System.Drawing.Point(31, 388);
            this.loadFromText.Name = "loadFromText";
            this.loadFromText.Size = new System.Drawing.Size(141, 30);
            this.loadFromText.TabIndex = 70;
            this.loadFromText.Text = "Load from file";
            this.loadFromText.UseVisualStyleBackColor = true;
            this.loadFromText.Click += new System.EventHandler(this.loadFromText_Click);
            // 
            // saveFileText
            // 
            this.saveFileText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveFileText.ForeColor = System.Drawing.Color.Aqua;
            this.saveFileText.Location = new System.Drawing.Point(190, 388);
            this.saveFileText.Name = "saveFileText";
            this.saveFileText.Size = new System.Drawing.Size(141, 30);
            this.saveFileText.TabIndex = 71;
            this.saveFileText.Text = "Save in file";
            this.saveFileText.UseVisualStyleBackColor = true;
            this.saveFileText.Click += new System.EventHandler(this.saveFileText_Click);
            // 
            // saveFileEffect
            // 
            this.saveFileEffect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFileEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveFileEffect.ForeColor = System.Drawing.Color.Aqua;
            this.saveFileEffect.Location = new System.Drawing.Point(359, 352);
            this.saveFileEffect.Name = "saveFileEffect";
            this.saveFileEffect.Size = new System.Drawing.Size(141, 30);
            this.saveFileEffect.TabIndex = 73;
            this.saveFileEffect.Text = "Save in file";
            this.saveFileEffect.UseVisualStyleBackColor = true;
            this.saveFileEffect.Click += new System.EventHandler(this.saveFileEffect_Click);
            // 
            // clearAll
            // 
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearAll.ForeColor = System.Drawing.Color.Aqua;
            this.clearAll.Location = new System.Drawing.Point(703, 316);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(141, 30);
            this.clearAll.TabIndex = 74;
            this.clearAll.Text = "Clear all";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // clearText
            // 
            this.clearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearText.ForeColor = System.Drawing.Color.Aqua;
            this.clearText.Location = new System.Drawing.Point(703, 247);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(141, 30);
            this.clearText.TabIndex = 75;
            this.clearText.Text = "Clear text";
            this.clearText.UseVisualStyleBackColor = true;
            this.clearText.Click += new System.EventHandler(this.clearText_Click);
            // 
            // clearEffect
            // 
            this.clearEffect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearEffect.ForeColor = System.Drawing.Color.Aqua;
            this.clearEffect.Location = new System.Drawing.Point(703, 280);
            this.clearEffect.Name = "clearEffect";
            this.clearEffect.Size = new System.Drawing.Size(141, 30);
            this.clearEffect.TabIndex = 76;
            this.clearEffect.Text = "Clear effect";
            this.clearEffect.UseVisualStyleBackColor = true;
            this.clearEffect.Click += new System.EventHandler(this.clearEffect_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // readDialog
            // 
            this.readDialog.FileName = "openFileDialog1";
            this.readDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // logCreate
            // 
            this.logCreate.AutoSize = true;
            this.logCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logCreate.ForeColor = System.Drawing.Color.Maroon;
            this.logCreate.Location = new System.Drawing.Point(578, 362);
            this.logCreate.Name = "logCreate";
            this.logCreate.Size = new System.Drawing.Size(266, 20);
            this.logCreate.TabIndex = 89;
            this.logCreate.Text = "LOG INFO UNVISIABLE AT START";
            this.logCreate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(276, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "DONT USE ENTER";
            // 
            // encryptdecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logCreate);
            this.Controls.Add(this.clearEffect);
            this.Controls.Add(this.clearText);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.saveFileEffect);
            this.Controls.Add(this.saveFileText);
            this.Controls.Add(this.loadFromText);
            this.Controls.Add(this.clereCodeInfo);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.codePassword);
            this.Controls.Add(this.codeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.effectRTB);
            this.Controls.Add(this.textRTB);
            this.Name = "encryptdecrypt";
            this.Size = new System.Drawing.Size(884, 482);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textRTB;
        private System.Windows.Forms.RichTextBox effectRTB;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codeName;
        private System.Windows.Forms.TextBox codePassword;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button clereCodeInfo;
        private System.Windows.Forms.Button loadFromText;
        private System.Windows.Forms.Button saveFileText;
        private System.Windows.Forms.Button saveFileEffect;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button clearText;
        private System.Windows.Forms.Button clearEffect;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog readDialog;
        private System.Windows.Forms.Label logCreate;
        private System.Windows.Forms.Label label5;
    }
}
