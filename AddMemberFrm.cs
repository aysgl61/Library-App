using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //veritabanı için
namespace Library_App
{
    public partial class AddMemberFrm : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9KCML05V;Initial Catalog=LibraryApp;Integrated Security=True"); //veritabanına bağlandık

        public AddMemberFrm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //bu sayfadan çıkmamızı sağlar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                baglanti.Open();  // Veritabanına olan bağlantıyı açtık
                SqlCommand komut = new SqlCommand("insert into Member(tc,adsoyad,yas,cinsiyet,telefon,email,okukitapsayisi,adres) values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@email,@okukitapsayisi,@adres)", baglanti);

                if (!Compare(TCTxt.Text))
                {
                    MessageBox.Show("Bu üye daha önce kaydolmuştur.", "Uyarı");
                }

                else if (string.IsNullOrEmpty(TCTxt.Text) ||
                string.IsNullOrEmpty(NameTxt.Text) ||
                string.IsNullOrEmpty(AgeTxt.Text) ||
                string.IsNullOrEmpty(GenderComboBOx.Text) ||
                string.IsNullOrEmpty(TelTxt.Text) ||
                string.IsNullOrEmpty(MailTxt.Text) ||
                string.IsNullOrEmpty(BookNumberTxt.Text) ||
                string.IsNullOrEmpty(addrestxt.Text))
                {
                    MessageBox.Show("Lütfen tüm üye bilgilerini eksiksiz doldurun.", "Uyarı");

                }

                else
                {
                    baglanti.Open();
                    komut.Parameters.AddWithValue("@tc", TCTxt.Text);
                    komut.Parameters.AddWithValue("@adsoyad", NameTxt.Text);
                    komut.Parameters.AddWithValue("@yas", AgeTxt.Text);
                    komut.Parameters.AddWithValue("@cinsiyet", GenderComboBOx.Text);
                    komut.Parameters.AddWithValue("@telefon", TelTxt.Text);
                    komut.Parameters.AddWithValue("@email", MailTxt.Text);
                    komut.Parameters.AddWithValue("@okukitapsayisi", BookNumberTxt.Text);
                    komut.Parameters.AddWithValue("@adres", addrestxt.Text);

                    komut.ExecuteNonQuery();  // Verilen komutları çalıştır

                    MessageBox.Show("Üye kaydı başarıyla gerçekleştirildi!");
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda burada işlem yapabilirsiniz
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata");
            }
            finally
            {
                baglanti.Close(); // Bağlantıyı kapat
            }

            Clear();
        }


        //textbox içindekileri temizleyen fonk
        void Clear()
        {
            foreach(Control item in Controls)
            {
               if(item is TextBox)
                {
                    if(item != BookNumberTxt) //okunan kitap sayısı hariç diğerlerini temizlesin !!DAHA SONRA SİLEBİLRİM
                    {
                        item.Text = "";
                    }
                    
                }
            }
        }

        private bool Compare(string tc)
        {
            SqlCommand query = new SqlCommand("select tc from Member where tc=@p1", baglanti);
            query.Parameters.AddWithValue("@p1", tc);

            SqlDataReader varmi = query.ExecuteReader(); //veritabanında var mı diye kontrol amaçlı

            if (varmi.Read())
            {
                baglanti.Close();
                return false; //veri tabanında var
            }

            else
            {
                baglanti.Close();
                return true; //veri tabanınfa yok
            }
        }
    }
}
