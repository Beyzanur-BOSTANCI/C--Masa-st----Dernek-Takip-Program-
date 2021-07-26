namespace _152113025_Dernek_Takip_Programi
{
    partial class Sehre_Göre_Sorgulama_Formu
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
            this.SehreGoreSorgula_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 165);
            this.dataGridView1.TabIndex = 5;
            // 
            // SehreGoreSorgula_ComboBox
            // 
            this.SehreGoreSorgula_ComboBox.FormattingEnabled = true;
            this.SehreGoreSorgula_ComboBox.Location = new System.Drawing.Point(155, 73);
            this.SehreGoreSorgula_ComboBox.Name = "SehreGoreSorgula_ComboBox";
            this.SehreGoreSorgula_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.SehreGoreSorgula_ComboBox.TabIndex = 4;
            this.SehreGoreSorgula_ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şehir Seçin:";
            // 
            // Sehre_Göre_Sorgulama_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 380);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SehreGoreSorgula_ComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Sehre_Göre_Sorgulama_Formu";
            this.Text = "Sehre_Göre_Sorgulama_Formu";
            this.Load += new System.EventHandler(this.Sehre_Göre_Sorgulama_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox SehreGoreSorgula_ComboBox;
        private System.Windows.Forms.Label label1;
    }
}