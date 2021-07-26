namespace _152113025_Dernek_Takip_Programi
{
    partial class Odeme_Yap_Formu
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
            this.TC_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Yil_ComboBox = new System.Windows.Forms.ComboBox();
            this.Ay_ComboBox = new System.Windows.Forms.ComboBox();
            this.Odeme_ComboBox = new System.Windows.Forms.ComboBox();
            this.Odeme_Tarihi_ComboBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ara_Btn = new System.Windows.Forms.Button();
            this.Kaydet_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Giriniz:";
            // 
            // TC_TextBox
            // 
            this.TC_TextBox.Location = new System.Drawing.Point(124, 53);
            this.TC_TextBox.Name = "TC_TextBox";
            this.TC_TextBox.Size = new System.Drawing.Size(121, 20);
            this.TC_TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yıl Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ay Seçiniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Borç Durumu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ödeme Tarihi:";
            // 
            // Yil_ComboBox
            // 
            this.Yil_ComboBox.FormattingEnabled = true;
            this.Yil_ComboBox.Items.AddRange(new object[] {
            "2017",
            "2018"});
            this.Yil_ComboBox.Location = new System.Drawing.Point(124, 106);
            this.Yil_ComboBox.Name = "Yil_ComboBox";
            this.Yil_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Yil_ComboBox.TabIndex = 6;
            this.Yil_ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Ay_ComboBox
            // 
            this.Ay_ComboBox.FormattingEnabled = true;
            this.Ay_ComboBox.Location = new System.Drawing.Point(124, 154);
            this.Ay_ComboBox.Name = "Ay_ComboBox";
            this.Ay_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Ay_ComboBox.TabIndex = 7;
            this.Ay_ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Odeme_ComboBox
            // 
            this.Odeme_ComboBox.FormattingEnabled = true;
            this.Odeme_ComboBox.Items.AddRange(new object[] {
            "Ödendi",
            "Ödenmedi"});
            this.Odeme_ComboBox.Location = new System.Drawing.Point(124, 189);
            this.Odeme_ComboBox.Name = "Odeme_ComboBox";
            this.Odeme_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Odeme_ComboBox.TabIndex = 8;
            this.Odeme_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Odeme_ComboBox_SelectedIndexChanged);
            // 
            // Odeme_Tarihi_ComboBox
            // 
            this.Odeme_Tarihi_ComboBox.Location = new System.Drawing.Point(124, 229);
            this.Odeme_Tarihi_ComboBox.Name = "Odeme_Tarihi_ComboBox";
            this.Odeme_Tarihi_ComboBox.Size = new System.Drawing.Size(121, 20);
            this.Odeme_Tarihi_ComboBox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 196);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ara_Btn
            // 
            this.Ara_Btn.Location = new System.Drawing.Point(308, 50);
            this.Ara_Btn.Name = "Ara_Btn";
            this.Ara_Btn.Size = new System.Drawing.Size(75, 23);
            this.Ara_Btn.TabIndex = 11;
            this.Ara_Btn.Text = "Ara";
            this.Ara_Btn.UseVisualStyleBackColor = true;
            this.Ara_Btn.Click += new System.EventHandler(this.Ara_Btn_Click);
            // 
            // Kaydet_Btn
            // 
            this.Kaydet_Btn.Location = new System.Drawing.Point(142, 279);
            this.Kaydet_Btn.Name = "Kaydet_Btn";
            this.Kaydet_Btn.Size = new System.Drawing.Size(75, 23);
            this.Kaydet_Btn.TabIndex = 12;
            this.Kaydet_Btn.Text = "Kaydet";
            this.Kaydet_Btn.UseVisualStyleBackColor = true;
            this.Kaydet_Btn.Click += new System.EventHandler(this.Kaydet_Btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // Odeme_Yap_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 411);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Kaydet_Btn);
            this.Controls.Add(this.Ara_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Odeme_Tarihi_ComboBox);
            this.Controls.Add(this.Odeme_ComboBox);
            this.Controls.Add(this.Ay_ComboBox);
            this.Controls.Add(this.Yil_ComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TC_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Odeme_Yap_Formu";
            this.Text = "Odeme_Yap_Formu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Odeme_Yap_Formu_FormClosed);
            this.Load += new System.EventHandler(this.Odeme_Yap_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TC_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Yil_ComboBox;
        private System.Windows.Forms.ComboBox Ay_ComboBox;
        private System.Windows.Forms.ComboBox Odeme_ComboBox;
        private System.Windows.Forms.TextBox Odeme_Tarihi_ComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Ara_Btn;
        private System.Windows.Forms.Button Kaydet_Btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}