using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _152113025_Dernek_Takip_Programi
{
    public partial class Sehre_Göre_Aidat_Belirleme_Formu : Form
    {
        public Sehre_Göre_Aidat_Belirleme_Formu()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        //IllerTablosundan ve AylarTAblosundan Çekilen veriler comboboz'a aktarılır.
        private void Sehre_Göre_Aidat_Belirleme_Formu_Load(object sender, EventArgs e)
        {
            Listele();
            //Access Baglantısı
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
            cmd = new OleDbCommand();
            //OleDbDataAdapter adtr = new OleDbDataAdapter();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM IllerTablosu ORDER BY IlAdi ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SehirCombobox.Items.Add(dr["IlAdi"]);
            }
            con.Close();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM AylarTablosu ORDER BY AyAdi ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ay_ComboBox.Items.Add(dr["AyAdi"]);
            }

            con.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    //AidatBelirlemeTAblosuna göre kayıtlar listelenir.
        void Listele()
        {
            
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From AidatBelirlemeTablosu", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "AidatBelirlemeTablosu");
            dataGridView1.DataSource = ds.Tables["AidatBelirlemeTablosu"];
            adtr.Dispose();
            baglanti.Close();

        }
        private void Son_Odeme_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        //datagridviewde görüntülenmesi için
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SehirCombobox.SelectedItem = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Ay_ComboBox.SelectedItem = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            SehirTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ay_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SehirTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //Sehir ve Ay seçilen verilerde arama yapılır.
        private void Ara_Btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from AidatBelirlemeTablosu where IlAdi Like '" + SehirCombobox.SelectedItem+"' and AyAdi Like '"+Ay_ComboBox.SelectedItem+"'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "AidatBelirlemeTablosu");          
            dataGridView1.DataSource = ds.Tables["AidatBelirlemeTablosu"];
            adtr.Dispose();
            baglanti.Close();




        }
        //Arama yapılan Ay ve sehih için Aidat miktari degiştirilebilir.
        private void Guncelle_TextBox_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE AidatBelirlemeTablosu Set GuncelAidatMiktari=@GuncelAidatMiktari Where IlAdi=@IlAdi and AyAdi=@AyAdi";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@GuncelAidatBelirleme", Convert.ToInt32 (SehirTextBox.Text));

            komut.Parameters.AddWithValue("@IlAdi", SehirCombobox.SelectedItem);
            komut.Parameters.AddWithValue("@AyAdi", Ay_ComboBox.SelectedItem);


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }
    }
}
