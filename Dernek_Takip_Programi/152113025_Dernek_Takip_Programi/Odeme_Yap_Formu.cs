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
    public partial class Odeme_Yap_Formu : Form
    {
        public Odeme_Yap_Formu()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void Odeme_Yap_Formu_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;

            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
            cmd = new OleDbCommand();
            //OleDbDataAdapter adtr = new OleDbDataAdapter();
            con.Open();
            
            //AylarTablosundan AyAdi çekilir ve ComboBox'a Aktatılır.
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM AylarTablosu ORDER BY AyAdi ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ay_ComboBox.Items.Add(dr["AyAdi"]);
            }
            con.Close();
            Listele();


            //OleDbDataAdapter adtr = new OleDbDataAdapter();




        }
        //borcdurumutablosundaki veriler listelenir.
        void Listele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From BorcDurumuTablosu", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "BorcDurumuTablosu");
            dataGridView1.DataSource = ds.Tables["BorcDurumuTablosu"];
            adtr.Dispose();
            baglanti.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //TC'ye göre arama yapılır ve datagridview görüntülenir.
        private void Ara_Btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from BorcDurumuTablosu where TC='" + TC_TextBox.Text + "'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "BorcDurumuTablosu");
            dataGridView1.DataSource = ds.Tables["BorcDurumuTablosu"];
            adtr.Dispose();
            baglanti.Close();
        }

        private void Odeme_Yap_Formu_FormClosed(object sender, FormClosedEventArgs e)
        {
            BireyBazliAidatTakip Birey = (BireyBazliAidatTakip)Application.OpenForms["BireyBazliAidatTakip"];
            Birey.GridDoldur();
        }
        
        private void Kaydet_Btn_Click(object sender, EventArgs e)

        {
            //Tc'si Yilbilgisi ve Ayadi Ayni ise kayıt vardır.
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM BorcDurumuTablosu where TC Like '" + TC_TextBox.Text + "' and YilBilgisi=" + Convert.ToInt32(Yil_ComboBox.SelectedItem) + " and AyAdi Like'" + Ay_ComboBox.SelectedItem + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label6.Text = "kayitvar";
                }
                con.Close();
                if (label6.Text == "kayitvar")
                { MessageBox.Show("Kayıt var."); }
                else//Eger yoksa YEni odeme bilgileri güncellenir.
                {
                    string sorgu = "Insert Into BorcDurumuTablosu(TC,YilBilgisi,AyAdi,BorcDurumu,OdemeTarihi) Values (@TC,@YilBilgisi,@AyAdi,@BorcDurumu,@OdemeTarihi)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@TC", TC_TextBox.Text);
                    komut.Parameters.AddWithValue("@YilBilgisi", Yil_ComboBox.SelectedItem);
                    komut.Parameters.AddWithValue("@AyAdi", Ay_ComboBox.SelectedItem);
                    komut.Parameters.AddWithValue("@BorcDurumu", Odeme_ComboBox.SelectedItem);
                    komut.Parameters.AddWithValue("@OdemeTarihi", Odeme_Tarihi_ComboBox.Text);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Güncellendi");
                    baglanti.Close();
                }



            Listele();
        }
    
        private void Odeme_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
