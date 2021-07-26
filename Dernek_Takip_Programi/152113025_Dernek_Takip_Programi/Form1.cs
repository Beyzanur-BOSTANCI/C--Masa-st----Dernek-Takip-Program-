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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Access bağlantısı yapılır.
        OleDbConnection baglanti= new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
        OleDbCommand komut = new OleDbCommand();//Veri tabanına bağlantı kurulduktan sonra, kurulan bu bağlantı üzerinden klasik veri tabanı işlemlerinin(veri alma,ekleme,güncelleme,silme…) yapılabilmesi amacıyla veri tabanı üzerinde çeşitli komutların çalıştırılması gerekir.OledbCommand Sınıfı bu amaçla kullanılır.
        OleDbConnection con;//Bir veri kaynağına açık bağlantıyı temsil eder.
        OleDbCommand cmd;//Veri tabanına bağlantı kurulduktan sonra, kurulan bu bağlantı üzerinden klasik veri tabanı işlemlerinin(veri alma,ekleme,güncelleme,silme…) yapılabilmesi amacıyla veri tabanı üzerinde çeşitli komutların çalıştırılması gerekir.OledbCommand Sınıfı bu amaçla kullanılır.
        OleDbDataReader dr;//Bu fonksiyon CommandText property’sinde belirtilen sorguyu çalıştırarak OleDbDataReader sınıfı türünde bir nesne referansı döndürür.
        //DataSet ds;

        //Formlar arası geçiş.
        private void kanGrubunaGöreSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kan_Grubu_Sorgulama_Formu kan_grubu_sorgula = new Kan_Grubu_Sorgulama_Formu();
            kan_grubu_sorgula.ShowDialog();

        }

        private void şehreGöreSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sehre_Göre_Sorgulama_Formu sehre_göre_sorgula = new Sehre_Göre_Sorgulama_Formu();
            sehre_göre_sorgula.ShowDialog();

        }

        private void üyelikDurumunaGöreSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uyelik_Durumu_Formu uyelik_sorgulama = new Uyelik_Durumu_Formu();
            uyelik_sorgulama.ShowDialog();

        }

        private void aylaraGöreAidatBelirlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aylara_Göre_Aidat_Belirleme_Formu aylara_göre_aidat_belirle = new Aylara_Göre_Aidat_Belirleme_Formu();
            aylara_göre_aidat_belirle.ShowDialog();

        }

        private void şehreGöreAidatBelirlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sehre_Göre_Aidat_Belirleme_Formu sehre_göre_aidat_belirleme = new Sehre_Göre_Aidat_Belirleme_Formu();
            sehre_göre_aidat_belirleme.ShowDialog();

        }
       //Load kısmında access bağlanılır. İlk olarak veritabanındaki verilerin görüntülenmesi için listele fonksiyonu çağrılır.
        private void Form1_Load(object sender, EventArgs e)
        {
            label18.Visible = false;
            TC2Txt.Visible = false;
            Listele();
            //Access Baglantısı
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakipProgrami2.accdb");
            cmd = new OleDbCommand();
            con.Open();//Bağlantı açılır.
            Temizle();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM IllerTablosu ORDER BY IlAdi ASC";//Veritabanındaki illerin çagrılması sağlanır.
            dr = cmd.ExecuteReader();//SqlDataReader, sadece okunabilir olarak kullanılmaktadır. Satır satır okuma işlemi yapılmaktadır. OleDbDataReader kullanımı boyunca veritabanı bağlantısı açık olacaktır. Çünkü OleDbDataReader veritabanı ile bağlantılı olarak çalışmaktadır. Okuma işlemi sona erdiğinde SqlDataReader bağlantısınında kapatılması gerekmektedir. 
            while (dr.Read())
            {
                Sehir_ComboBox.Items.Add(dr["IlAdi"]);//Illertablosundan veriler sehir_combobox'a aktarılır.
            }
            con.Close();
         
    }
        //Ekle_Btn tıklandığında veritabanına kayıt yapma işlemi sağlanır
        private void Ekle_Btn_Click(object sender, EventArgs e)
        {
            TC2Txt.Text=TC_TextBox.Text;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select TC from UyeEklemeTablosu where TC Like '" + TC_TextBox.Text + "'";//Aynı Tc'den bir başkası olamayacağı için aynı Tc girilenleri kayıt etmez.
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                label18.Text = "UyeVar";//TC'nin olup olmadığını kontrol ediyoruz ona göre Yeni Kayıt eklenir.

            }
            con.Close();
            if (label18.Text == "UyeVar")
            {
                MessageBox.Show("Üye Kayıtlı!");

            }
            else
            {//Eger Kayıt yoksa yeni kayıt işlemi gerçekleşmiş olur. Insert ınto Sorgu baslığı ile yeni kayıt eklenebilir. Veritabanındaki sıraya göre sıralama yapılır ve yine veritabanına göre kayıt kayma işlemi sağlanır.
                string sorgu = "INSERT INTO UyeEklemeTablosu(TC,Ad,Soyad,DogumTarihi,DogumYeri,Cinsiyet,AnneAdi,BabaAdi,Meslek,MedeniDurum,Telefon,KanGrubu,IlAdi,EPosta,KayitTarihi,UyelikDurum) VALUES (@TC,@Ad,@Soyad,@DogumTarihi,@DogumYeri,@Cinsiyet,@AnneAdi,@BabaAdi,@Meslek,@MedeniDurum,@Telefon,@KanGrubu,@IlAdi,@EPosta,@KayitTarihi,@UyelikDurum)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@TC", TC_TextBox.Text);

                komut.Parameters.AddWithValue("@Ad", Ad_TextBox.Text);
                komut.Parameters.AddWithValue("@Soyad", Soyad_TextBox.Text);
                komut.Parameters.AddWithValue("@DogumTarihi", DogumTarihi_TextBox.Text);
                komut.Parameters.AddWithValue("@DogumYeri", DogumYeri_ComboBox.SelectedItem);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet_ComboBox.SelectedItem);
                komut.Parameters.AddWithValue("@AnneAdi", Anne_TextBox.Text);
                komut.Parameters.AddWithValue("@BabaAdi", Baba_TextBox.Text);
                komut.Parameters.AddWithValue("@Meslek", Meslek_TextBox.Text);
                komut.Parameters.AddWithValue("@MedeniDurum", MedeniDurum_ComboBox.SelectedItem);
                komut.Parameters.AddWithValue("@Telefon", Telefon_TextBox.Text);
                komut.Parameters.AddWithValue("@KanGrubu", KanGrubu_ComboBox.SelectedItem);
                komut.Parameters.AddWithValue("@IlAdi", Sehir_ComboBox.SelectedItem);
                komut.Parameters.AddWithValue("@EPosta", Eposta_TextBox.Text);
                komut.Parameters.AddWithValue("@KayitTarihi", KayitTarihi_TextBox.Text);
                komut.Parameters.AddWithValue("@UyelikDurumu", Aktif_ComboBox.SelectedItem);

                baglanti.Open();

                komut.ExecuteNonQuery(); // fonksiyonu kullanılarakCommandTextproperty’sinde belirtilen ve herhangi bir kayıt döndürmeyen(sorgulama amaçlı olmayan) komutlar çalıştırılabilir. Örneğin; Update,Insert,Delete gibi komutlar.
                baglanti.Close();
            }
            Listele();
            //Bu şekildede veritabanına kayıt sağlanır.
            /*  
            komut.Connection = baglanti;
            komut.CommandText = "insert into UyeEklemeTablosu(TC,Ad,Soyad,DogumTarihi,DogumYeri,Cinsiyet,AnneAdi,BabaAdi,Meslek,MedeniDurum,Telefon,KanGrubu,IlAdi,E-Posta,KayitTarihi,UyelikDurum) values('" + TC_TextBox.Text + "','" + Ad_TextBox.Text + "','" + Soyad_TextBox.Text + "','" + DogumTarihi_TextBox.Text +"','" + DogumYeri_ComboBox.SelectedItem + "','" + Cinsiyet_ComboBox.SelectedItem + "','" + Anne_TextBox.Text + "','" + Baba_TextBox.Text +"','" + Meslek_TextBox.Text + "','" + MedeniDurum_ComboBox.SelectedItem + "','" + Telefon_TextBox.Text + "','" + KanGrubu_ComboBox.SelectedItem + "','" + Sehir_ComboBox.SelectedItem + "','" + Eposta_TextBox.Text + "','" + KayitTarihi_TextBox.Text + "','" +Aktiflik + "')";
            baglanti.Open();
            komut.ExecuteNonQuery();
           // komut.Dispose();
            baglanti.Close();
            ds.Clear();
            Listele();*/
        
            Temizle();


        }
        //UyeEklemeTablosunda verilerin listelenmesi sağlanır. UyeEklemeTablosuna göre veritabanında olan veriler listelenir.
        void Listele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From UyeEklemeTablosu", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds,"UyeEklemeTablosu");
            dataGridView1.DataSource = ds.Tables["UyeEklemeTablosu"];
            adtr.Dispose();
            baglanti.Close();

        }
        //TC'sine göre silme işlemi gerçekleşir.
        void Sil()
        {
            string sorgu = "Delete From UyeEklemeTablosu Where TC=@TC";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TC", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
         
        }
      //TextBoxların içini temizlemek için kullanılır.
        void Temizle()
        {
            TC_TextBox.Clear(); Ad_TextBox.Clear(); Soyad_TextBox.Clear(); DogumTarihi_TextBox.Clear();
            Anne_TextBox.Clear(); Baba_TextBox.Clear(); Meslek_TextBox.Clear(); Telefon_TextBox.Clear();
            Eposta_TextBox.Clear(); KayitTarihi_TextBox.Clear();

        }
        //TC_TextBox'a girilen verinin  veritabanındaki bütün bilgilerin silinmesini sağlar.
        private void Sil_Btn_Click(object sender, EventArgs e)
        {
            Sil();
            
        }
        //tc_TextBox'a girilen verinin istenildiği gibi güncellemesini sağlar. yine veritabanının sıralanmasına göre işlem yapılır.
        //tc_textBox'nın sonunda çagrılıyor olması Tc numarasın göre güncelleme yapılacağındandır.
        private void Güncelle_Btn_Click(object sender, EventArgs e)
        {
            
            string sorgu = "UPDATE UyeEklemeTablosu Set Ad=@Ad,Soyad=@Soyad,DogumTarihi=@DogumTarihi,DogumYeri=@DogumYeri,Cinsiyet=@Cinsiyet,AnneAdi=@AnneAdi,BabaAdi=@BabaAdi,Meslek=@Meslek,MedeniDurum=@MedeniDurum,Telefon=@Telefon,KanGrubu=@KanGrubu,IlAdi=@IlAdi,EPosta=@EPosta,KayitTarihi=@KayitTarihi,UyelikDurum=@UyelikDurum Where TC=@TC";
            komut = new OleDbCommand(sorgu, baglanti);
            
            komut.Parameters.AddWithValue("@Ad", Ad_TextBox.Text);
            komut.Parameters.AddWithValue("@Soyad", Soyad_TextBox.Text);
            komut.Parameters.AddWithValue("@DogumTarihi", DogumTarihi_TextBox.Text);
            komut.Parameters.AddWithValue("@DogumYeri", DogumYeri_ComboBox.SelectedItem);
            komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet_ComboBox.SelectedItem);
            komut.Parameters.AddWithValue("@AnneAdi", Anne_TextBox.Text);
            komut.Parameters.AddWithValue("@BabaAdi", Baba_TextBox.Text);
            komut.Parameters.AddWithValue("@Meslek", Meslek_TextBox.Text);
            komut.Parameters.AddWithValue("@MedeniDurum", MedeniDurum_ComboBox.SelectedItem);
            komut.Parameters.AddWithValue("@Telefon", Telefon_TextBox.Text);
            komut.Parameters.AddWithValue("@KanGrubu", KanGrubu_ComboBox.SelectedItem);
            komut.Parameters.AddWithValue("@IlAdi", Sehir_ComboBox.SelectedItem);
            komut.Parameters.AddWithValue("@EPosta", Eposta_TextBox.Text);
            komut.Parameters.AddWithValue("@KayitTarihi", KayitTarihi_TextBox.Text);
            komut.Parameters.AddWithValue("@UyelikDurumu", Aktif_ComboBox.SelectedItem);

            komut.Parameters.AddWithValue("@TC", TC_TextBox.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
            //Bu şekildede güncelleme yapılabilir.
            /*
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText= "Update UyeEklemeTablosu set[TC]=('" + TC_TextBox.Text + "'),[Ad]=('" + Ad_TextBox.Text + "'),[Soyad]=('" + Soyad_TextBox.Text + "'),[DogumTarihi]=('" + DogumTarihi_TextBox.Text + "'),[DogumYeri]=('" + DogumYeri_ComboBox.Text + "'),[Cinsiyet]=('" + Cinsiyet_ComboBox.Text + "'),[AnneAdi]=('" + Anne_TextBox.Text + "'),[BabaAdi]=('" + Baba_TextBox.Text +
                "'),[Meslek]=('" + Meslek_TextBox.Text + "'),[MedeniDurum]=('" + MedeniDurum_ComboBox.Text + "'),[Telefon]=('" + Telefon_TextBox.Text + "'),[KanGrubu]=('" + KanGrubu_ComboBox.Text + "'),[IlID]=('" + Sehir_ComboBox.Text + "'),[E-Posta]=('" + Eposta_TextBox.Text + "'),[KayitTarihi]=('" + KayitTarihi_TextBox.Text + "'),[UyelikDurumu]=('" +
                Aktif_CheckBox.Text + "') where[TC]=('"+TC_TextBox.Text+"')";
            komut.Dispose();
            baglanti.Close();
            ds.Tables["UyeEklemeTablosu"].Clear();
            Listele();*/

        }

        //TC'sine göre arama yapılır. güncelleme ve silme işlemleri için kolaylık sağlar.
        private void Ara_Btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from UyeEklemeTablosu where TC='" + TC_TextBox.Text + "'", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "UyeEklemeTablosu");
            dataGridView1.DataSource = ds.Tables["UyeEklemeTablosu"];
            adtr.Dispose();
            baglanti.Close();

        }
        //Veritabanına kayıt yapılırken neyin nereye kayıt olması için kolonları belli eder.
        //Colon atlanması durumunda program çalışmaz veya her colon yanlış bilgiyi tutar.
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TC_TextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Ad_TextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Soyad_TextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DogumTarihi_TextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            DogumYeri_ComboBox.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Cinsiyet_ComboBox.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Anne_TextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Baba_TextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Meslek_TextBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            MedeniDurum_ComboBox.SelectedItem = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            Telefon_TextBox.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            KanGrubu_ComboBox.SelectedItem = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            Sehir_ComboBox.SelectedItem = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            Eposta_TextBox.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            KayitTarihi_TextBox.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            Aktif_ComboBox.SelectedItem = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            
        }

        private void Temizle_Btn_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void bİREYBAZLIÖDEMEBİLGİLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyBazliAidatTakip birey_bazlı_aidat = new BireyBazliAidatTakip();
            birey_bazlı_aidat.ShowDialog();
        }

        private void bORÇLULARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borclular_Formu borc = new Borclular_Formu();
            borc.ShowDialog();

        }

        private void tARİHLERARASISORGULAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarihler_Arasi_Sorgulama Tarih_Arasi_Sorgu = new Tarihler_Arasi_Sorgulama();
            Tarih_Arasi_Sorgu.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gRAFİKLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aylaraGöreGrafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafikler Grafik = new Grafikler();
            Grafik.ShowDialog();
        }

        private void şehirDağılımanaGöreGrafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SehirlereGöre grafik2 = new SehirlereGöre();
            grafik2.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
