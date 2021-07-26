using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//Access Baglantısı için ekledi.

namespace _152113025_Dernek_Takip_Programi
{
    public partial class Kan_Grubu_Sorgulama_Formu : Form
    {
        public Kan_Grubu_Sorgulama_Formu()
        {
            InitializeComponent();
        }
        //Access ile bağlanmak için yerini belli ediyoruz.
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();//Veri tabanına bağlantı kurulduktan sonra, kurulan bu bağlantı üzerinden klasik veri tabanı işlemlerinin(veri alma,ekleme,güncelleme,silme…) yapılabilmesi amacıyla veri tabanı üzerinde çeşitli komutların çalıştırılması gerekir.OledbCommand Sınıfı bu amaçla kullanılır.
        OleDbConnection con;//Bir veri kaynağına açık bağlantıyı temsil eder.
        OleDbCommand cmd;//Veri tabanına bağlantı kurulduktan sonra, kurulan bu bağlantı üzerinden klasik veri tabanı işlemlerinin(veri alma,ekleme,güncelleme,silme…) yapılabilmesi amacıyla veri tabanı üzerinde çeşitli komutların çalıştırılması gerekir.OledbCommand Sınıfı bu amaçla kullanılır.
        OleDbDataReader dr;


        //Kan_Grubu_ComboBox'da seçilen kan grubuna göre üyeler listelenir.
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from UyeEklemeTablosu where KanGrubu='" + KanGrubuSorgula_ComboBox.SelectedItem + "'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "UyeEklemeTablosu");
            dataGridView1.DataSource = ds.Tables["UyeEklemeTablosu"];
            adtr.Dispose();
            baglanti.Close();
        }
        //İlk Access'e bağlantı sağlanır.
        private void Kan_Grubu_Sorgulama_Formu_Load(object sender, EventArgs e)
        {
            //Access Baglantısı
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
            cmd = new OleDbCommand();
            //OleDbDataAdapter adtr = new OleDbDataAdapter();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM KanGrubuTablosu ORDER BY KanGrubu ASC";//Veritabanından kan grupları çekilir.
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KanGrubuSorgula_ComboBox.Items.Add(dr["KanGrubu"]);
            }

            con.Close();

        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}
