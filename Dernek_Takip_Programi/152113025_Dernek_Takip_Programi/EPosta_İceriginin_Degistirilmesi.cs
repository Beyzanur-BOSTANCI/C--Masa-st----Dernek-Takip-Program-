using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;


namespace _152113025_Dernek_Takip_Programi
{
    public partial class EPosta_İceriginin_Degistirilmesi : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

       
        public EPosta_İceriginin_Degistirilmesi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EPosta_İceriginin_Degistirilmesi_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            //AylarTablosundan AyAdi bilgisi çekilir ve ComboBox'a aktarılır.
            cmd.CommandText = "SELECT * FROM AylarTablosu ORDER BY AyAdi ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AyComboBox.Items.Add(dr["AyAdi"]);
            }
            con.Close();
            //Dosyadanda İçerik Çagrılabilir.
            /* StreamReader oku;
             oku = File.OpenText(@"C:\\Users\\asus\\Desktop\\152113025_Dernek_Takip_Programi\\152113025_Dernek_Takip_Programi\\bin\\Debug\\Dernek_Takip_EPosta.txt");
             string yazi;
             while ((yazi = oku.ReadLine()) != null)
             {
                 Icerik_TextBox.Text = yazi.ToString();
             }
             oku.Close();*/
             //Veri tabanından Icerik Çekilir ve Icerik_TextBox'a Aktarilir.
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM EPostaIcerik where Icerik ";
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Icerik_TextBox.Text = dr["Icerik"].ToString();
            }
            con.Close();


        }

        private void Gönder_Btn_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();//Mail mesajimi olusturabilmek için MailMessage sinifi türünden bir degisken olusturmamiz gerekmektedir
            mesaj.From = new MailAddress("DernekTakipExample@hotmail.com");//E-Posta'nin kimden gönderilecegi bilgisini tutar. MailAddress türünden bir degisken istemektedir.
            for (int i=0;i<Gönder_Mail_ListBox.Items.Count;i++)//ListBox'taki ne akadar adres varsa o kadar dögü devam edecek.
            {
                mesaj.To.Add(Gönder_Mail_ListBox.Items[i].ToString());


            }
            mesaj.Subject = Baslık_Lbl.Text;//E-Posta'nin konusu bilgisini tutar.
            mesaj.Body = Icerik_TextBox.Text;//E-Posta'nin içerik bilgisini tutar.
            SmtpClient smtp = new SmtpClient();// E-Posta'nin gönderilecegi SMTP sunucu ve gönderen kullanicinin bilgilerinin yazilip, MailMessage türünde olusturulan mailin gönderildigi siniftir.
            smtp.Credentials = new System.Net.NetworkCredential("DernekTakipExample@hotmail.com","DuzceUniversitesi2017");//E-Posta'yi gönderen kullanicinin kimlik bilgilerini tutar.
            smtp.Port = 587;//SMTP sunucusunun port bilgisini tutar.
            smtp.Host = "smtp.live.com";//SMTP sunucusunun isim bilgisini tutar.
            smtp.EnableSsl = true;//Sunucu SSL istiyorsa bu degeri true yapacagiz.
            try
            {
                smtp.Send(mesaj);//E-Posta'yi gönderme islemini yapar. Sunucuya göre Send ya da SendAsync metodlarindan birisi kullanilir.

            }
            catch
            {
                MessageBox.Show("Mail Gönderilemedi!");
            }
            MessageBox.Show("Mail Gönderildi.");

            
        }

        private void Ara_Btn_Click(object sender, EventArgs e)
        {
            ///UyeEklemeTablosu ve BorcDurumuTablosundan ortak arama yapılır ve istenilen veriler datagridview'de görüntülenir.
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select UET.TC,UET.Ad,UET.Soyad,UET.EPosta,BDT.YilBilgisi,'" + AyComboBox.SelectedItem + "',BDT.BorcDurumu from  UyeEklemeTablosu as UET inner join BorcDurumuTablosu as BDT on UET.TC=BDT.TC where BDT.BorcDurumu Like 'Ödenmedi' and AyAdi Like'" + AyComboBox.SelectedItem + "'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "UyeEklemeTablosu");
            adtr.Dispose();
            baglanti.Close();
            //UyeEklemetablosundan Eposya Adresleri çekilir ve istediğimiz verileri görüntülemek için inner join sorgusu yapılır.
            //Ara_btn'ye tıklandıgında Eposta adresleri ListBox'a aktarılır.
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select EPosta from  UyeEklemeTablosu as UET inner join BorcDurumuTablosu as BDT on UET.TC=BDT.TC where BDT.BorcDurumu Like 'Ödenmedi' and AyAdi Like'" + AyComboBox.SelectedItem + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gönder_Mail_ListBox.Items.Add(dr["EPosta"]);
            }
            con.Close();
        }

        private void Baslık_Lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
