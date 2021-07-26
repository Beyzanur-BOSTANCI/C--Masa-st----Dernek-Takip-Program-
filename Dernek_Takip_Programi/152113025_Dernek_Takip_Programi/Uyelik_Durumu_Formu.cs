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
    public partial class Uyelik_Durumu_Formu : Form
    {
        public Uyelik_Durumu_Formu()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        //Uyenin aktiflik pasiflik durumuna göre sorgu yapılır ve Comboboxda seçilen durum dataGridview'de görüntülenir.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from UyeEklemeTablosu where UyelikDurum='" + UyelikDurumu_ComboBox.SelectedItem + "'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "UyeEklemeTablosu");
            dataGridView1.DataSource = ds.Tables["UyeEklemeTablosu"];
            adtr.Dispose();
            baglanti.Close();

        }

        //Veribanınından uyedurum çekilir vecomboboz'a aktarılır.

        private void Uyelik_Durumu_Formu_Load(object sender, EventArgs e)
        {
            //Access Baglantısı
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
            cmd = new OleDbCommand();
            //OleDbDataAdapter adtr = new OleDbDataAdapter();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM UyelikDurumuTablosu ORDER BY UyelikDurum ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                UyelikDurumu_ComboBox.Items.Add(dr["UyelikDurum"]);
            }

            con.Close();
        }
    }
}
