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
    public partial class Tarihler_Arasi_Sorgulama : Form
    {
        
        public Tarihler_Arasi_Sorgulama()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataTable dt;
       
        private void Tarihler_Arasi_Sorgulama_Load(object sender, EventArgs e)
        {
            //Access Baglantısı
            //BorcDurumuTablosunun Görüntülenmesi
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
            cmd = new OleDbCommand();
            da = new OleDbDataAdapter("SELECT * FROM BorcDurumuTablosu", con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        //string formatta tanımlanan 2 tarih arasında sorgulama ödendi ve ödenmediler olarak listelenir.
        private void Odendi_Btn_Click(object sender, EventArgs e)
        {
       
              DataView dv = dt.DefaultView;
              dv.RowFilter = string.Format("OdemeTarihi > '{0}' AND  OdemeTarihi<= '{1}'", dateTimePicker1.Value, dateTimePicker2.Value);
              dataGridView1.DataSource = dv;

            

        }   
    }
}