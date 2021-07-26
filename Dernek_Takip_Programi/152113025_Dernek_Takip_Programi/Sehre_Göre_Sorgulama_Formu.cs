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
    public partial class Sehre_Göre_Sorgulama_Formu : Form
    {
        public Sehre_Göre_Sorgulama_Formu()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        
        //veritabanında olan verilerin yasagıdığı ile göre sorgulama yapılır.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from UyeEklemeTablosu where IlAdi='" + SehreGoreSorgula_ComboBox.SelectedItem + "'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "UyeEklemeTablosu");
            dataGridView1.DataSource = ds.Tables["UyeEklemeTablosu"];
            adtr.Dispose();
            baglanti.Close();
        }
        //IllerTablosundan İller çekilir, SehreGöreSorula_ComboBox yazdırılır.
        private void Sehre_Göre_Sorgulama_Formu_Load(object sender, EventArgs e)
        {
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
                SehreGoreSorgula_ComboBox.Items.Add(dr["IlAdi"]);
            }

            con.Close();
        }
    }
}
