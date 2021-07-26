namespace _152113025_Dernek_Takip_Programi
{
    partial class Borc_Detay_Formu
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
            this.Sehir_TextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TC2_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sehir_TextBox
            // 
            this.Sehir_TextBox.Location = new System.Drawing.Point(171, 27);
            this.Sehir_TextBox.Name = "Sehir_TextBox";
            this.Sehir_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Sehir_TextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 195);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TC2_TextBox
            // 
            this.TC2_TextBox.Location = new System.Drawing.Point(32, 27);
            this.TC2_TextBox.Name = "TC2_TextBox";
            this.TC2_TextBox.Size = new System.Drawing.Size(100, 20);
            this.TC2_TextBox.TabIndex = 4;
            this.TC2_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Borc_Detay_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 381);
            this.Controls.Add(this.TC2_TextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sehir_TextBox);
            this.Name = "Borc_Detay_Formu";
            this.Text = "Borc_Detay_Formu";
            this.Load += new System.EventHandler(this.Borc_Detay_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Sehir_TextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TC2_TextBox;
    }
}