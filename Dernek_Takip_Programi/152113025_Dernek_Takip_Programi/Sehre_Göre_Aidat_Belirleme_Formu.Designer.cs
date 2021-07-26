namespace _152113025_Dernek_Takip_Programi
{
    partial class Sehre_Göre_Aidat_Belirleme_Formu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ay_ComboBox = new System.Windows.Forms.ComboBox();
            this.SehirCombobox = new System.Windows.Forms.ComboBox();
            this.SehirTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Ara_Btn = new System.Windows.Forms.Button();
            this.Guncelle_TextBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şehir Seçiniz:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ay Seçiniz:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Ay_ComboBox
            // 
            this.Ay_ComboBox.FormattingEnabled = true;
            this.Ay_ComboBox.Location = new System.Drawing.Point(374, 23);
            this.Ay_ComboBox.Name = "Ay_ComboBox";
            this.Ay_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Ay_ComboBox.TabIndex = 4;
            this.Ay_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Ay_ComboBox_SelectedIndexChanged);
            // 
            // SehirCombobox
            // 
            this.SehirCombobox.FormattingEnabled = true;
            this.SehirCombobox.Location = new System.Drawing.Point(117, 23);
            this.SehirCombobox.Name = "SehirCombobox";
            this.SehirCombobox.Size = new System.Drawing.Size(121, 21);
            this.SehirCombobox.TabIndex = 5;
            // 
            // SehirTextBox
            // 
            this.SehirTextBox.Location = new System.Drawing.Point(117, 323);
            this.SehirTextBox.Name = "SehirTextBox";
            this.SehirTextBox.Size = new System.Drawing.Size(128, 20);
            this.SehirTextBox.TabIndex = 6;
            this.SehirTextBox.TextChanged += new System.EventHandler(this.SehirTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 227);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Yeni Aidat Miktarı";
            // 
            // Ara_Btn
            // 
            this.Ara_Btn.Location = new System.Drawing.Point(533, 23);
            this.Ara_Btn.Name = "Ara_Btn";
            this.Ara_Btn.Size = new System.Drawing.Size(75, 23);
            this.Ara_Btn.TabIndex = 14;
            this.Ara_Btn.Text = "Ara";
            this.Ara_Btn.UseVisualStyleBackColor = true;
            this.Ara_Btn.Click += new System.EventHandler(this.Ara_Btn_Click);
            // 
            // Guncelle_TextBox
            // 
            this.Guncelle_TextBox.Location = new System.Drawing.Point(284, 320);
            this.Guncelle_TextBox.Name = "Guncelle_TextBox";
            this.Guncelle_TextBox.Size = new System.Drawing.Size(75, 23);
            this.Guncelle_TextBox.TabIndex = 15;
            this.Guncelle_TextBox.Text = "Güncelle";
            this.Guncelle_TextBox.UseVisualStyleBackColor = true;
            this.Guncelle_TextBox.Click += new System.EventHandler(this.Guncelle_TextBox_Click);
            // 
            // Sehre_Göre_Aidat_Belirleme_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 425);
            this.Controls.Add(this.Guncelle_TextBox);
            this.Controls.Add(this.Ara_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SehirTextBox);
            this.Controls.Add(this.SehirCombobox);
            this.Controls.Add(this.Ay_ComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Sehre_Göre_Aidat_Belirleme_Formu";
            this.Text = "Sehre_Göre_Aidat_Belirleme_Formu";
            this.Load += new System.EventHandler(this.Sehre_Göre_Aidat_Belirleme_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Ay_ComboBox;
        private System.Windows.Forms.ComboBox SehirCombobox;
        private System.Windows.Forms.TextBox SehirTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ara_Btn;
        private System.Windows.Forms.Button Guncelle_TextBox;
    }
}