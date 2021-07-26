namespace _152113025_Dernek_Takip_Programi
{
    partial class EPosta_İceriginin_Degistirilmesi
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
            this.Gönder_Mail_ListBox = new System.Windows.Forms.ListBox();
            this.Icerik_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Baslık_Lbl = new System.Windows.Forms.Label();
            this.Gönder_Btn = new System.Windows.Forms.Button();
            this.AyComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ara_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gönder_Mail_ListBox
            // 
            this.Gönder_Mail_ListBox.FormattingEnabled = true;
            this.Gönder_Mail_ListBox.Location = new System.Drawing.Point(221, 60);
            this.Gönder_Mail_ListBox.Name = "Gönder_Mail_ListBox";
            this.Gönder_Mail_ListBox.Size = new System.Drawing.Size(327, 108);
            this.Gönder_Mail_ListBox.TabIndex = 0;
            // 
            // Icerik_TextBox
            // 
            this.Icerik_TextBox.Location = new System.Drawing.Point(221, 226);
            this.Icerik_TextBox.Multiline = true;
            this.Icerik_TextBox.Name = "Icerik_TextBox";
            this.Icerik_TextBox.Size = new System.Drawing.Size(327, 146);
            this.Icerik_TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kimlere Gönderilecekse Mail Adresleri:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlık:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İçerik:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Baslık_Lbl
            // 
            this.Baslık_Lbl.AutoSize = true;
            this.Baslık_Lbl.Location = new System.Drawing.Point(218, 185);
            this.Baslık_Lbl.Name = "Baslık_Lbl";
            this.Baslık_Lbl.Size = new System.Drawing.Size(116, 13);
            this.Baslık_Lbl.TabIndex = 5;
            this.Baslık_Lbl.Text = "Dernek Takip Programı";
            this.Baslık_Lbl.Click += new System.EventHandler(this.Baslık_Lbl_Click);
            // 
            // Gönder_Btn
            // 
            this.Gönder_Btn.Location = new System.Drawing.Point(473, 391);
            this.Gönder_Btn.Name = "Gönder_Btn";
            this.Gönder_Btn.Size = new System.Drawing.Size(75, 23);
            this.Gönder_Btn.TabIndex = 6;
            this.Gönder_Btn.Text = "Gönder";
            this.Gönder_Btn.UseVisualStyleBackColor = true;
            this.Gönder_Btn.Click += new System.EventHandler(this.Gönder_Btn_Click);
            // 
            // AyComboBox
            // 
            this.AyComboBox.FormattingEnabled = true;
            this.AyComboBox.Location = new System.Drawing.Point(221, 27);
            this.AyComboBox.Name = "AyComboBox";
            this.AyComboBox.Size = new System.Drawing.Size(121, 21);
            this.AyComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ay Seçiniz:";
            // 
            // Ara_Btn
            // 
            this.Ara_Btn.Location = new System.Drawing.Point(473, 25);
            this.Ara_Btn.Name = "Ara_Btn";
            this.Ara_Btn.Size = new System.Drawing.Size(75, 23);
            this.Ara_Btn.TabIndex = 9;
            this.Ara_Btn.Text = "Ara";
            this.Ara_Btn.UseVisualStyleBackColor = true;
            this.Ara_Btn.Click += new System.EventHandler(this.Ara_Btn_Click);
            // 
            // EPosta_İceriginin_Degistirilmesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 426);
            this.Controls.Add(this.Ara_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AyComboBox);
            this.Controls.Add(this.Gönder_Btn);
            this.Controls.Add(this.Baslık_Lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Icerik_TextBox);
            this.Controls.Add(this.Gönder_Mail_ListBox);
            this.Name = "EPosta_İceriginin_Degistirilmesi";
            this.Text = "EPosta_İceriginin_Degistirilmesi";
            this.Load += new System.EventHandler(this.EPosta_İceriginin_Degistirilmesi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Gönder_Mail_ListBox;
        private System.Windows.Forms.TextBox Icerik_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Baslık_Lbl;
        private System.Windows.Forms.Button Gönder_Btn;
        private System.Windows.Forms.ComboBox AyComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Ara_Btn;
    }
}