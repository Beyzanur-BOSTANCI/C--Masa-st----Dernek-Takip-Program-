namespace _152113025_Dernek_Takip_Programi
{
    partial class Borclular_Formu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Ay_ComboBox = new System.Windows.Forms.ComboBox();
            this.Ara_Btn = new System.Windows.Forms.Button();
            this.Pdf_Aktar_Btn = new System.Windows.Forms.Button();
            this.E_Posta_Btn = new System.Windows.Forms.Button();
            this.Posta_TextBox = new System.Windows.Forms.TextBox();
            this.Posta_ListBox = new System.Windows.Forms.ListBox();
            this.IcerikDegistir_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borçluların Götüntülenmesi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 259);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ay Seçiniz:";
            // 
            // Ay_ComboBox
            // 
            this.Ay_ComboBox.FormattingEnabled = true;
            this.Ay_ComboBox.Location = new System.Drawing.Point(126, 74);
            this.Ay_ComboBox.Name = "Ay_ComboBox";
            this.Ay_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Ay_ComboBox.TabIndex = 7;
            // 
            // Ara_Btn
            // 
            this.Ara_Btn.Location = new System.Drawing.Point(290, 72);
            this.Ara_Btn.Name = "Ara_Btn";
            this.Ara_Btn.Size = new System.Drawing.Size(75, 23);
            this.Ara_Btn.TabIndex = 8;
            this.Ara_Btn.Text = "Ara";
            this.Ara_Btn.UseVisualStyleBackColor = true;
            this.Ara_Btn.Click += new System.EventHandler(this.Ara_Btn_Click);
            // 
            // Pdf_Aktar_Btn
            // 
            this.Pdf_Aktar_Btn.Location = new System.Drawing.Point(516, 195);
            this.Pdf_Aktar_Btn.Name = "Pdf_Aktar_Btn";
            this.Pdf_Aktar_Btn.Size = new System.Drawing.Size(120, 50);
            this.Pdf_Aktar_Btn.TabIndex = 9;
            this.Pdf_Aktar_Btn.Text = "PDF\'e Aktar";
            this.Pdf_Aktar_Btn.UseVisualStyleBackColor = true;
            this.Pdf_Aktar_Btn.Click += new System.EventHandler(this.Pdf_Aktar_Btn_Click);
            // 
            // E_Posta_Btn
            // 
            this.E_Posta_Btn.Location = new System.Drawing.Point(516, 269);
            this.E_Posta_Btn.Name = "E_Posta_Btn";
            this.E_Posta_Btn.Size = new System.Drawing.Size(120, 55);
            this.E_Posta_Btn.TabIndex = 3;
            this.E_Posta_Btn.Text = "Herkese E Posta Gönder";
            this.E_Posta_Btn.UseVisualStyleBackColor = true;
            this.E_Posta_Btn.Click += new System.EventHandler(this.E_Posta_Btn_Click);
            // 
            // Posta_TextBox
            // 
            this.Posta_TextBox.Location = new System.Drawing.Point(489, 12);
            this.Posta_TextBox.Multiline = true;
            this.Posta_TextBox.Name = "Posta_TextBox";
            this.Posta_TextBox.Size = new System.Drawing.Size(169, 78);
            this.Posta_TextBox.TabIndex = 10;
            // 
            // Posta_ListBox
            // 
            this.Posta_ListBox.FormattingEnabled = true;
            this.Posta_ListBox.Location = new System.Drawing.Point(489, 96);
            this.Posta_ListBox.Name = "Posta_ListBox";
            this.Posta_ListBox.Size = new System.Drawing.Size(169, 82);
            this.Posta_ListBox.TabIndex = 11;
            // 
            // IcerikDegistir_Btn
            // 
            this.IcerikDegistir_Btn.Location = new System.Drawing.Point(516, 341);
            this.IcerikDegistir_Btn.Name = "IcerikDegistir_Btn";
            this.IcerikDegistir_Btn.Size = new System.Drawing.Size(120, 54);
            this.IcerikDegistir_Btn.TabIndex = 12;
            this.IcerikDegistir_Btn.Text = "İstenildiği Durumda E Posta İçeriğinin Değiştir";
            this.IcerikDegistir_Btn.UseVisualStyleBackColor = true;
            this.IcerikDegistir_Btn.Click += new System.EventHandler(this.IcerikDegistir_Btn_Click);
            // 
            // Borclular_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 469);
            this.Controls.Add(this.IcerikDegistir_Btn);
            this.Controls.Add(this.Posta_ListBox);
            this.Controls.Add(this.Posta_TextBox);
            this.Controls.Add(this.Pdf_Aktar_Btn);
            this.Controls.Add(this.Ara_Btn);
            this.Controls.Add(this.Ay_ComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.E_Posta_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Borclular_Formu";
            this.Load += new System.EventHandler(this.Borclular_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Ay_ComboBox;
        private System.Windows.Forms.Button Ara_Btn;
        private System.Windows.Forms.Button Pdf_Aktar_Btn;
        private System.Windows.Forms.Button E_Posta_Btn;
        private System.Windows.Forms.TextBox Posta_TextBox;
        private System.Windows.Forms.ListBox Posta_ListBox;
        private System.Windows.Forms.Button IcerikDegistir_Btn;
    }
}