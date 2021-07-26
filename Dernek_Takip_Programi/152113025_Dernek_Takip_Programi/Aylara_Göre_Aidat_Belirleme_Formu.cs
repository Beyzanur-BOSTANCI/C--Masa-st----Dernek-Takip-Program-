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
    public partial class Aylara_Göre_Aidat_Belirleme_Formu : Form
    {
        public Aylara_Göre_Aidat_Belirleme_Formu()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        //AylarTAbosundan Aylar çekilir ve combobox'a aktarılır.
        private void Aylara_Göre_Aidat_Belirleme_Formu_Load(object sender, EventArgs e)
        {

            Listele();
            Ay_Aidat_TextBox.Clear();
            //Access Baglantısı
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
            cmd = new OleDbCommand();
            //OleDbDataAdapter adtr = new OleDbDataAdapter();
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
        //Aylarda belirlenen aidat miktarını degiştirmek için güncelleme yapılması gerekir.
        private void Ay_Aidat_Btn_Click(object sender, EventArgs e)
        {
            
            string sorgu = "UPDATE AidatBelirlemeTablosu Set GuncelAidatMiktari=@GuncelAidatMiktari Where AyAdi=@AyAdi";
            
            komut = new OleDbCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@GuncelAidatBelirleme", Convert.ToInt64(Ay_Aidat_TextBox.Text));
            komut.Parameters.AddWithValue("@AyAdi", Ay_ComboBox.SelectedItem);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Ay_Aidat_TextBox.Clear();

            Listele();
        }
        //AidatBelirlemetablosunun listelenmesi
        void Listele()
        {
           
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From AidatBelirlemeTablosu", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "AidatBelirlemeTablosu");
            dataGridView1.DataSource = ds.Tables["AidatBelirlemeTablosu"];
            adtr.Dispose();
            baglanti.Close();
            Ay_Aidat_TextBox.Clear();

        }
        private void Ay_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ay_Aidat_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //datagridviewde gösterilmesi
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            Ay_ComboBox.SelectedItem = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Ay_Aidat_TextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void Ay_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Comboboxda seşilen aya göre arama yapar.
        private void Ara_Btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from AidatBelirlemeTablosu where AyAdi = '" +Ay_ComboBox.SelectedItem+"'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "AidatBelirlemeTablosu");
            dataGridView1.DataSource = ds.Tables["AidatBelirlemeTablosu"];
            adtr.Dispose();
            baglanti.Close();
        }
    }
}
