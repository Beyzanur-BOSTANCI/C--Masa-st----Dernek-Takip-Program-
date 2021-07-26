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

    public partial class Borc_Detay_Formu : Form
    {
        public Borc_Detay_Formu()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();
        //TC ve IlAdini çekeceğimiz için kullanılır.
        public string TC { get; set; }
        public string IlAdi { get; set; }
        private void Borc_Detay_Formu_Load(object sender, EventArgs e)
        {
            TC2_TextBox.Text = TC;
            
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
            //borcDurumuTablosunun Tc2_TextBox'taki kişinin detayını getirmek için kulllanır.
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from BorcDurumuTablosu where TC Like'" + TC2_TextBox.Text + "'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds,"BorcDurumuTablosu");
            dataGridView1.DataSource = ds.Tables["BorcDurumuTablosu"];
            adtr.Dispose();
            baglanti.Close();

          
            //IllerTablosundan IlAdi çekilir ve ComBobox'a aktarılır.
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select IlAdi from UyeEklemeTablosu where TC='" + TC2_TextBox.Text + "'", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Sehir_TextBox.Text = dr["IlAdi"].ToString();

            }
            con.Close();
            //Tc sini girilen kişinin aidatBelirlemeTablosundan Yaşadığı şehir ve il datagridView'de Görüntülenir.
            baglanti.Open();
            OleDbDataAdapter adtr2 = new OleDbDataAdapter("select * from AidatBelirlemeTablosu where IlAdi Like'" + Sehir_TextBox.Text + "'", baglanti);
            adtr2.Fill(ds, "BorcDurumuTablosu");
            dataGridView1.DataSource = ds.Tables["BorcDurumuTablosu"];
            adtr2.Dispose();
            baglanti.Close();

        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ad_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
