namespace _152113025_Dernek_Takip_Programi
{
    partial class BireyBazliAidatTakip
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Detay_Btn = new System.Windows.Forms.Button();
            this.Odeme_Bilgileri_Btn = new System.Windows.Forms.Button();
            this.Ara_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ara_Button = new System.Windows.Forms.Button();
            this.TC2_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Detay_Btn
            // 
            this.Detay_Btn.Location = new System.Drawing.Point(572, 25);
            this.Detay_Btn.Name = "Detay_Btn";
            this.Detay_Btn.Size = new System.Drawing.Size(156, 40);
            this.Detay_Btn.TabIndex = 1;
            this.Detay_Btn.Text = "Kişi Bazlı Ödeme Bilgileri Detay\r\n";
            this.Detay_Btn.UseVisualStyleBackColor = true;
            this.Detay_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Odeme_Bilgileri_Btn
            // 
            this.Odeme_Bilgileri_Btn.Location = new System.Drawing.Point(572, 282);
            this.Odeme_Bilgileri_Btn.Name = "Odeme_Bilgileri_Btn";
            this.Odeme_Bilgileri_Btn.Size = new System.Drawing.Size(156, 45);
            this.Odeme_Bilgileri_Btn.TabIndex = 2;
            this.Odeme_Bilgileri_Btn.Text = "Yeni Ödeme Bilgileri";
            this.Odeme_Bilgileri_Btn.UseVisualStyleBackColor = true;
            this.Odeme_Bilgileri_Btn.Click += new System.EventHandler(this.Odeme_Bilgileri_Btn_Click);
            // 
            // Ara_TextBox
            // 
            this.Ara_TextBox.Location = new System.Drawing.Point(120, 32);
            this.Ara_TextBox.Name = "Ara_TextBox";
            this.Ara_TextBox.Size = new System.Drawing.Size(128, 20);
            this.Ara_TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "T.C Giriniz:";
            // 
            // Ara_Button
            // 
            this.Ara_Button.Location = new System.Drawing.Point(275, 29);
            this.Ara_Button.Name = "Ara_Button";
            this.Ara_Button.Size = new System.Drawing.Size(75, 23);
            this.Ara_Button.TabIndex = 5;
            this.Ara_Button.Text = "Ara";
            this.Ara_Button.UseVisualStyleBackColor = true;
            this.Ara_Button.Click += new System.EventHandler(this.Ara_Button_Click);
            // 
            // TC2_TextBox
            // 
            this.TC2_TextBox.Location = new System.Drawing.Point(464, 32);
            this.TC2_TextBox.Name = "TC2_TextBox";
            this.TC2_TextBox.Size = new System.Drawing.Size(57, 20);
            this.TC2_TextBox.TabIndex = 6;
            // 
            // BireyBazliAidatTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 459);
            this.Controls.Add(this.TC2_TextBox);
            this.Controls.Add(this.Ara_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ara_TextBox);
            this.Controls.Add(this.Odeme_Bilgileri_Btn);
            this.Controls.Add(this.Detay_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BireyBazliAidatTakip";
            this.Text = "BireyBazliAidatTakip";
            this.Load += new System.EventHandler(this.BireyBazliAidatTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Detay_Btn;
        private System.Windows.Forms.Button Odeme_Bilgileri_Btn;
        private System.Windows.Forms.TextBox Ara_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ara_Button;
        private System.Windows.Forms.TextBox TC2_TextBox;
    }
}