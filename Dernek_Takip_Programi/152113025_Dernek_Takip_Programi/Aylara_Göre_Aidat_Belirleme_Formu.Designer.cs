namespace _152113025_Dernek_Takip_Programi
{
    partial class Aylara_Göre_Aidat_Belirleme_Formu
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
            this.Ay_ComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ay_Aidat_TextBox = new System.Windows.Forms.TextBox();
            this.Ay_Aidat_Btn = new System.Windows.Forms.Button();
            this.Ara_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ay Seçiniz:";
            // 
            // Ay_ComboBox
            // 
            this.Ay_ComboBox.FormattingEnabled = true;
            this.Ay_ComboBox.Location = new System.Drawing.Point(168, 20);
            this.Ay_ComboBox.Name = "Ay_ComboBox";
            this.Ay_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Ay_ComboBox.TabIndex = 3;
            this.Ay_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Ay_ComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 226);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Ay_Aidat_TextBox
            // 
            this.Ay_Aidat_TextBox.Location = new System.Drawing.Point(168, 76);
            this.Ay_Aidat_TextBox.Name = "Ay_Aidat_TextBox";
            this.Ay_Aidat_TextBox.Size = new System.Drawing.Size(131, 20);
            this.Ay_Aidat_TextBox.TabIndex = 7;
            this.Ay_Aidat_TextBox.TextChanged += new System.EventHandler(this.Ay_Aidat_TextBox_TextChanged);
            // 
            // Ay_Aidat_Btn
            // 
            this.Ay_Aidat_Btn.Location = new System.Drawing.Point(321, 76);
            this.Ay_Aidat_Btn.Name = "Ay_Aidat_Btn";
            this.Ay_Aidat_Btn.Size = new System.Drawing.Size(118, 23);
            this.Ay_Aidat_Btn.TabIndex = 8;
            this.Ay_Aidat_Btn.Text = "Kaydet";
            this.Ay_Aidat_Btn.UseVisualStyleBackColor = true;
            this.Ay_Aidat_Btn.Click += new System.EventHandler(this.Ay_Aidat_Btn_Click);
            // 
            // Ara_Btn
            // 
            this.Ara_Btn.Location = new System.Drawing.Point(321, 20);
            this.Ara_Btn.Name = "Ara_Btn";
            this.Ara_Btn.Size = new System.Drawing.Size(75, 23);
            this.Ara_Btn.TabIndex = 9;
            this.Ara_Btn.Text = "Ara";
            this.Ara_Btn.UseVisualStyleBackColor = true;
            this.Ara_Btn.Click += new System.EventHandler(this.Ara_Btn_Click);
            // 
            // Aylara_Göre_Aidat_Belirleme_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 399);
            this.Controls.Add(this.Ara_Btn);
            this.Controls.Add(this.Ay_Aidat_Btn);
            this.Controls.Add(this.Ay_Aidat_TextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ay_ComboBox);
            this.Controls.Add(this.label2);
            this.Name = "Aylara_Göre_Aidat_Belirleme_Formu";
            this.Text = "Aylara_Göre_Aidat_Belirleme_Formu";
            this.Load += new System.EventHandler(this.Aylara_Göre_Aidat_Belirleme_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Ay_ComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Ay_Aidat_TextBox;
        private System.Windows.Forms.Button Ay_Aidat_Btn;
        private System.Windows.Forms.Button Ara_Btn;
    }
}