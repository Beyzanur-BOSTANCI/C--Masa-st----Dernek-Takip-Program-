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
    public partial class BireyBazliAidatTakip : Form
    {
        public BireyBazliAidatTakip()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbConnection con;
        OleDbCommand cmd;
        
        private void BireyBazliAidatTakip_Load(object sender, EventArgs e)
        {
           
            GridDoldur();
            
        }
        //Borc Durumutablosunun datagridviewde görüntülenmesi sağlanır.
        public void GridDoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
            cmd = new OleDbCommand();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From BorcDurumuTablosu", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "BorcDurumuTablosu");
            dataGridView1.DataSource = ds.Tables["BorcDurumuTablosu"];
            adtr.Dispose();
            baglanti.Close();
        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }
     
      

       //Seçili olan tc'nin TC2_Text'e aktarılması ve seçilen tc'nin ödeme durumlarının detayı göstermek için aradaki bağlamdır.
        private void button1_Click(object sender, EventArgs e)
        {
            Borc_Detay_Formu detay = new Borc_Detay_Formu();
            detay.TC = TC2_TextBox.Text;
            detay.ShowDialog();
            

        }

        private void Odeme_Bilgileri_Btn_Click(object sender, EventArgs e)
        {
            Odeme_Yap_Formu Odeme_Yap = new Odeme_Yap_Formu();
            Odeme_Yap.ShowDialog();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           //Ara_TextBox.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        internal static void BireyBazliAidatTakip_Load()
        {
            throw new NotImplementedException();
        }
        //Tc'si Ara_textBox'a girilen Tc'nin ödeme durumlarını getirir.
        private void Ara_Button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from BorcDurumuTablosu where TC='" + Ara_TextBox.Text + "'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "BorcDurumuTablosu");
            dataGridView1.DataSource = ds.Tables["BorcDurumuTablosu"];
            adtr.Dispose();
            baglanti.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TC2_TextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }
    }
}
