namespace szyfr_plotowy
{
    partial class frm_RailFenceCyfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbPlaintext = new System.Windows.Forms.RichTextBox();
            this.rtbCiphertext = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txbRail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tekst";
            // 
            // rtbPlaintext
            // 
            this.rtbPlaintext.Location = new System.Drawing.Point(33, 58);
            this.rtbPlaintext.Name = "rtbPlaintext";
            this.rtbPlaintext.Size = new System.Drawing.Size(249, 129);
            this.rtbPlaintext.TabIndex = 2;
            this.rtbPlaintext.Text = "";
            // 
            // rtbCiphertext
            // 
            this.rtbCiphertext.Location = new System.Drawing.Point(393, 58);
            this.rtbCiphertext.Name = "rtbCiphertext";
            this.rtbCiphertext.Size = new System.Drawing.Size(236, 129);
            this.rtbCiphertext.TabIndex = 3;
            this.rtbCiphertext.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "szyfr";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(299, 109);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 27);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "szyfruj";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(299, 157);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 28);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "odszyfruj";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txbRail
            // 
            this.txbRail.Location = new System.Drawing.Point(299, 58);
            this.txbRail.Name = "txbRail";
            this.txbRail.Size = new System.Drawing.Size(75, 22);
            this.txbRail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "klucz";
            // 
            // frm_RailFenceCyfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 222);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbRail);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbCiphertext);
            this.Controls.Add(this.rtbPlaintext);
            this.Controls.Add(this.label1);
            this.Name = "frm_RailFenceCyfer";
            this.Text = "Szyfr plotkowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbPlaintext;
        private System.Windows.Forms.RichTextBox rtbCiphertext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txbRail;
        private System.Windows.Forms.Label label3;
    }
}

