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
            baglanti.Open();  //önce veritabanına olan bağlantıyı açtık
            SqlCommand komut = new SqlCommand("insert into Member(tc,adsoyad,yas,cinsiyet,telefon,email,okukitapsayisi,adres) values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@email,@okukitapsayisi,@adres)", baglanti); //komut oluşturmak için obje oluşturduk

            komut.Parameters.AddWithValue("@tc",TCTxt.Text);  //form üzerinde girmiş olduğumuz text'leri veritabanına ekliyoruz
            komut.Parameters.AddWithValue("@adsoyad", NameTxt.Text);
            komut.Parameters.AddWithValue("@yas", AgeTxt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", GenderComboBOx.Text);
            komut.Parameters.AddWithValue("@telefon", TelTxt.Text);
            komut.Parameters.AddWithValue("@email", MailTxt.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", BookNumberTxt.Text);
            komut.Parameters.AddWithValue("@adres", addrestxt.Text);
            komut.ExecuteNonQuery();  //verilen komutları oku

            baglanti.Close();

            MessageBox.Show("Üye kaydı başarıyla gerçekleştirildi!");

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
    }
}
