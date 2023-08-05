using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Library_App
{
    public partial class AddBookFrm : Form
    {
        public AddBookFrm()
        {
            InitializeComponent();
        }

        
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9KCML05V;Initial Catalog=LibraryApp;Integrated Security=True"); //veritabanına bağlandık


        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();  //önce veritabanına olan bağlantıyı açtık
                SqlCommand komut = new SqlCommand("insert into Books(kitapnumarasi,kitapadi,yazari,yayinevi,sayfasayisi,turu) values(@kitapnumarasi,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@turu)", baglanti); //komut oluşturmak için obje oluşturduk

                if (!Compare(BookNumberTxt.Text))
                {
                    MessageBox.Show("Bu kitap daha önce eklenmiş.", "Uyarı");
                }
                else if(string.IsNullOrEmpty(BookNumberTxt.Text) || string.IsNullOrEmpty(BookNameTxt.Text) || string.IsNullOrEmpty(WriterTxt.Text) || string.IsNullOrEmpty(PublisherTxt.Text) || string.IsNullOrEmpty(PageNumberTxt.Text) || string.IsNullOrEmpty(BookTypeCombo.Text) )
                {
                    MessageBox.Show("Lütfen tüm kitap bilgilerini eksiksiz doldurun.", "Uyarı");
                }
                else
                {
                    baglanti.Open();
                    komut.Parameters.AddWithValue("@kitapnumarasi", BookNumberTxt.Text);  //form üzerinde girmiş olduğumuz text'leri veritabanına ekliyoruz
                    komut.Parameters.AddWithValue("@kitapadi", BookNameTxt.Text);
                    komut.Parameters.AddWithValue("@yazari", WriterTxt.Text);
                    komut.Parameters.AddWithValue("@yayinevi", PublisherTxt.Text);
                    komut.Parameters.AddWithValue("@sayfasayisi", PageNumberTxt.Text);
                    komut.Parameters.AddWithValue("@turu", BookTypeCombo.Text);

                    komut.ExecuteNonQuery();  //verilen komutları oku

                    MessageBox.Show("Kitap kaydı başarıyla gerçekleştirildi!");

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
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                   
                        item.Text = "";
                  
                }  
            }
        }

        private bool Compare(string kitapnumarasi)
        {
            SqlCommand query = new SqlCommand("select kitapnumarasi from Books where kitapnumarasi=@p1", baglanti);
            query.Parameters.AddWithValue("@p1", kitapnumarasi);

            SqlDataReader varmi = query.ExecuteReader();

            if (varmi.Read())
            {
                baglanti.Close();
                return false; //veri tabanında var
            }
            else
            {
                baglanti.Close();
                return true; //veri tabanında yok
            }
        }
    }
}
