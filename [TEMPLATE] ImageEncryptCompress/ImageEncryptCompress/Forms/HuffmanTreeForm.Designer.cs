namespace ImageEncryptCompress.Forms
{
    partial class HuffmanTreeForm
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPageRed = new System.Windows.Forms.TabPage();
            this.richTextBoxRed = new System.Windows.Forms.RichTextBox();
            this.tabPageGreen = new System.Windows.Forms.TabPage();
            this.richTextBoxGreen = new System.Windows.Forms.RichTextBox();
            this.tabPageBlue = new System.Windows.Forms.TabPage();
            this.richTextBoxBlue = new System.Windows.Forms.RichTextBox();
            this.metroTabControl1.SuspendLayout();
            this.tabPageRed.SuspendLayout();
            this.tabPageGreen.SuspendLayout();
            this.tabPageBlue.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPageRed);
            this.metroTabControl1.Controls.Add(this.tabPageGreen);
            this.metroTabControl1.Controls.Add(this.tabPageBlue);
            this.metroTabControl1.Location = new System.Drawing.Point(13, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(431, 372);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPageRed
            // 
            this.tabPageRed.BackColor = System.Drawing.Color.Red;
            this.tabPageRed.Controls.Add(this.richTextBoxRed);
            this.tabPageRed.Location = new System.Drawing.Point(4, 38);
            this.tabPageRed.Name = "tabPageRed";
            this.tabPageRed.Size = new System.Drawing.Size(423, 330);
            this.tabPageRed.TabIndex = 0;
            this.tabPageRed.Text = "Red Tree";
            // 
            // richTextBoxRed
            // 
            this.richTextBoxRed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxRed.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxRed.Name = "richTextBoxRed";
            this.richTextBoxRed.ReadOnly = true;
            this.richTextBoxRed.Size = new System.Drawing.Size(417, 324);
            this.richTextBoxRed.TabIndex = 0;
            this.richTextBoxRed.Text = "";
            // 
            // tabPageGreen
            // 
            this.tabPageGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabPageGreen.Controls.Add(this.richTextBoxGreen);
            this.tabPageGreen.Location = new System.Drawing.Point(4, 38);
            this.tabPageGreen.Name = "tabPageGreen";
            this.tabPageGreen.Size = new System.Drawing.Size(423, 330);
            this.tabPageGreen.TabIndex = 1;
            this.tabPageGreen.Text = "Green Tree";
            // 
            // richTextBoxGreen
            // 
            this.richTextBoxGreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxGreen.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxGreen.Name = "richTextBoxGreen";
            this.richTextBoxGreen.ReadOnly = true;
            this.richTextBoxGreen.Size = new System.Drawing.Size(417, 324);
            this.richTextBoxGreen.TabIndex = 1;
            this.richTextBoxGreen.Text = "";
            // 
            // tabPageBlue
            // 
            this.tabPageBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabPageBlue.Controls.Add(this.richTextBoxBlue);
            this.tabPageBlue.Location = new System.Drawing.Point(4, 38);
            this.tabPageBlue.Name = "tabPageBlue";
            this.tabPageBlue.Size = new System.Drawing.Size(423, 330);
            this.tabPageBlue.TabIndex = 2;
            this.tabPageBlue.Text = "Blue Tree";
            // 
            // richTextBoxBlue
            // 
            this.richTextBoxBlue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxBlue.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxBlue.Name = "richTextBoxBlue";
            this.richTextBoxBlue.ReadOnly = true;
            this.richTextBoxBlue.Size = new System.Drawing.Size(417, 324);
            this.richTextBoxBlue.TabIndex = 2;
            this.richTextBoxBlue.Text = "";
            // 
            // HuffmanTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 455);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "HuffmanTreeForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Huffman Tree";
            this.Load += new System.EventHandler(this.HuffmanTreeForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPageRed.ResumeLayout(false);
            this.tabPageGreen.ResumeLayout(false);
            this.tabPageBlue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPageRed;
        private System.Windows.Forms.RichTextBox richTextBoxRed;
        private System.Windows.Forms.TabPage tabPageGreen;
        private System.Windows.Forms.RichTextBox richTextBoxGreen;
        private System.Windows.Forms.TabPage tabPageBlue;
        private System.Windows.Forms.RichTextBox richTextBoxBlue;
    }
}