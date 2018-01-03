namespace ImageEncryptCompress.Forms
{
    partial class EncryptForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtInitialSeed = new MetroFramework.Controls.MetroTextBox();
            this.checkBoxAlphaNumeric = new MetroFramework.Controls.MetroCheckBox();
            this.txtTapPosition = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Initial Seed :";
            // 
            // txtInitialSeed
            // 
            // 
            // 
            // 
            this.txtInitialSeed.CustomButton.Image = null;
            this.txtInitialSeed.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtInitialSeed.CustomButton.Name = "";
            this.txtInitialSeed.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInitialSeed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInitialSeed.CustomButton.TabIndex = 1;
            this.txtInitialSeed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInitialSeed.CustomButton.UseSelectable = true;
            this.txtInitialSeed.CustomButton.Visible = false;
            this.txtInitialSeed.Lines = new string[0];
            this.txtInitialSeed.Location = new System.Drawing.Point(109, 81);
            this.txtInitialSeed.MaxLength = 32767;
            this.txtInitialSeed.Name = "txtInitialSeed";
            this.txtInitialSeed.PasswordChar = '\0';
            this.txtInitialSeed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInitialSeed.SelectedText = "";
            this.txtInitialSeed.SelectionLength = 0;
            this.txtInitialSeed.SelectionStart = 0;
            this.txtInitialSeed.ShortcutsEnabled = true;
            this.txtInitialSeed.Size = new System.Drawing.Size(201, 23);
            this.txtInitialSeed.TabIndex = 1;
            this.txtInitialSeed.UseSelectable = true;
            this.txtInitialSeed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInitialSeed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkBoxAlphaNumeric
            // 
            this.checkBoxAlphaNumeric.AutoSize = true;
            this.checkBoxAlphaNumeric.Location = new System.Drawing.Point(316, 85);
            this.checkBoxAlphaNumeric.Name = "checkBoxAlphaNumeric";
            this.checkBoxAlphaNumeric.Size = new System.Drawing.Size(98, 15);
            this.checkBoxAlphaNumeric.TabIndex = 2;
            this.checkBoxAlphaNumeric.Text = "Alphanumeric";
            this.checkBoxAlphaNumeric.UseSelectable = true;
            // 
            // txtTapPosition
            // 
            // 
            // 
            // 
            this.txtTapPosition.CustomButton.Image = null;
            this.txtTapPosition.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtTapPosition.CustomButton.Name = "";
            this.txtTapPosition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTapPosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTapPosition.CustomButton.TabIndex = 1;
            this.txtTapPosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTapPosition.CustomButton.UseSelectable = true;
            this.txtTapPosition.CustomButton.Visible = false;
            this.txtTapPosition.Lines = new string[0];
            this.txtTapPosition.Location = new System.Drawing.Point(109, 119);
            this.txtTapPosition.MaxLength = 32767;
            this.txtTapPosition.Name = "txtTapPosition";
            this.txtTapPosition.PasswordChar = '\0';
            this.txtTapPosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTapPosition.SelectedText = "";
            this.txtTapPosition.SelectionLength = 0;
            this.txtTapPosition.SelectionStart = 0;
            this.txtTapPosition.ShortcutsEnabled = true;
            this.txtTapPosition.Size = new System.Drawing.Size(201, 23);
            this.txtTapPosition.TabIndex = 4;
            this.txtTapPosition.UseSelectable = true;
            this.txtTapPosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTapPosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Tap Position :";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(15, 154);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(388, 30);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Encrypt / Decrypt";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 200);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtTapPosition);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.checkBoxAlphaNumeric);
            this.Controls.Add(this.txtInitialSeed);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "EncryptForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Encrypt / Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtInitialSeed;
        private MetroFramework.Controls.MetroCheckBox checkBoxAlphaNumeric;
        private MetroFramework.Controls.MetroTextBox txtTapPosition;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}