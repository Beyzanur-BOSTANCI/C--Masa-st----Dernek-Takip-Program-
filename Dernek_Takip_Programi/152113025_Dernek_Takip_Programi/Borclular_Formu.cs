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
using iTextSharp.text;//pdf işlemleri için eklenir.
using iTextSharp.text.pdf;//pdf işlemleri için eklenir.
using System.IO;//Dosya işlemlemleri için eklenir

using System.Net.Mail;//mail işlemleri için eklenir.



namespace _152113025_Dernek_Takip_Programi
{
    public partial class Borclular_Formu : Form
    {
        public Borclular_Formu()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        private void Borclular_Formu_Load(object sender, EventArgs e)
        {
           // Posta_ListBox.Visible = false;
            Posta_TextBox.Visible = false;

            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
            cmd = new OleDbCommand();
            con.Open();
            //AylarTablosundan AyAdi Çekilir ve combobox'a aktarılır.
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM AylarTablosu ORDER BY AyAdi ASC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ay_ComboBox.Items.Add(dr["AyAdi"]);
            }
            con.Close();
            //UyeEklemeTAblosu ve BorcBurumu TAblosundan ortak sorgu yapılır ve datagridview'de görüntülenmesi sağlanır.
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select UET.TC,UET.Ad,UET.Soyad,UET.EPosta,BDT.YilBilgisi,'" + Ay_ComboBox.SelectedItem + "',BDT.BorcDurumu from  UyeEklemeTablosu as UET inner join BorcDurumuTablosu as BDT on UET.TC=BDT.TC where BDT.BorcDurumu Like'Ödenmedi'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "UyeEklemeTablosu");
            dataGridView1.DataSource = ds.Tables["UyeEklemeTablosu"];
            adtr.Dispose();
            baglanti.Close();
            //Txt Dosyasından da içerik okunabilir.
            /*  StreamReader oku;
              oku = File.OpenText(@"C:\\Users\\asus\\Desktop\\152113025_Dernek_Takip_Programi\\152113025_Dernek_Takip_Programi\\bin\\Debug\\Dernek_Takip_EPosta.txt");
              string yazi;
              while ((yazi = oku.ReadLine()) != null)
              {
                  Posta_TextBox.Text = yazi.ToString();
              }
              oku.Close();*/
              //veritabanında içerik çekilir ve Post_TextBox'a aktarılır.
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM EPostaIcerik where Icerik ";
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Posta_TextBox.Text = dr["Icerik"].ToString();
            }
            con.Close();


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private static Document GetDoc()
        {
            return new Document(PageSize.LETTER, 10, 10, 42, 35);
        }

        private void Ara_Btn_Click(object sender, EventArgs e)
        {
            //UyeEklemeTablosu ve BorcDurumuTablosundan ortak arama yapılır ve istenilen veriler datagridview'de görüntülenir.
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select UET.TC,UET.Ad,UET.Soyad,UET.EPosta,BDT.YilBilgisi,'" + Ay_ComboBox.SelectedItem + "',BDT.BorcDurumu from  UyeEklemeTablosu as UET inner join BorcDurumuTablosu as BDT on UET.TC=BDT.TC where BDT.BorcDurumu Like 'Ödenmedi' and AyAdi Like'" + Ay_ComboBox.SelectedItem + "'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "UyeEklemeTablosu");
            dataGridView1.DataSource = ds.Tables["UyeEklemeTablosu"];
            adtr.Dispose();
            baglanti.Close();
            //UyeEklemetablosundan Eposya Adresleri çekilir ve istediğimiz verileri görüntülemek için inner join sorgusu yapılır.
            //Ara_btn'ye tıklandıgında Eposta adresleri ListBox'a aktarılır.
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select EPosta from  UyeEklemeTablosu as UET inner join BorcDurumuTablosu as BDT on UET.TC=BDT.TC where BDT.BorcDurumu Like 'Ödenmedi' and AyAdi Like'" + Ay_ComboBox.SelectedItem + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Posta_ListBox.Items.Add(dr["EPosta"]);
            }
            con.Close();
           
        }
        //Borcluları Pdf'e aktarılır.
        private void Pdf_Aktar_Btn_Click(object sender, EventArgs e)
        {
            Document doc = GetDoc();
            PdfWriter yazdir = PdfWriter.GetInstance(doc, new FileStream("Borclular.pdf", FileMode.Create));
            doc.Open();
            PdfPTable Tablo = new PdfPTable(dataGridView1.Columns.Count);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Tablo.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText));
            }
            Tablo.HeaderRows = 1;
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if (dataGridView1[k, j].Value != null)
                    {
                        Tablo.AddCell(new Phrase(dataGridView1[k, j].Value.ToString()));

                    }
                }
            }
            doc.Add(Tablo);
            doc.Close();
            MessageBox.Show("Pdf oluşturuldu. Debug Dosyasının içine kaydedilmiştir.");

        }

        private void E_Posta_Btn_Click(object sender, EventArgs e)
        {

            MailMessage mesaj = new MailMessage();//Mail mesajimi olusturabilmek için MailMessage sinifi türünden bir degisken olusturmamiz gerekmektedir
            mesaj.From = new MailAddress("DernekTakipExample@hotmail.com");//E-Posta'nin kimden gönderilecegi bilgisini tutar. MailAddress türünden bir degisken istemektedir.
            for (int i = 0; i < Posta_ListBox.Items.Count; i++)//ListBox'taki ne akadar adres varsa o kadar dögü devam edecek.
            {
                mesaj.To.Add(Posta_ListBox.Items[i].ToString());


            }
            mesaj.Subject = "Dernek Takip Programı";//E-Posta'nin konusu bilgisini tutar.
            mesaj.Body = Posta_TextBox.Text;//E-Posta'nin içerik bilgisini tutar.
            SmtpClient smtp = new SmtpClient();// E-Posta'nin gönderilecegi SMTP sunucu ve gönderen kullanicinin bilgilerinin yazilip, MailMessage türünde olusturulan mailin gönderildigi siniftir.
            smtp.Credentials = new System.Net.NetworkCredential("DernekTakipExample@hotmail.com", "DuzceUniversitesi2017");//E-Posta'yi gönderen kullanicinin kimlik bilgilerini tutar.
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

        private void IcerikDegistir_Btn_Click(object sender, EventArgs e)
        {
            EPosta_İceriginin_Degistirilmesi Icerik_Degistir = new EPosta_İceriginin_Degistirilmesi();
            Icerik_Degistir.ShowDialog();
  
        }
    }
    }
