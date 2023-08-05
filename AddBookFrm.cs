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
            baglanti.Open();  //önce veritabanına olan bağlantıyı açtık
            SqlCommand komut = new SqlCommand("insert into Books(kitapnumarasi,kitapadi,yazari,yayinevi,sayfasayisi,turu) values(@kitapnumarasi,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@turu)", baglanti); //komut oluşturmak için obje oluşturduk

            
            komut.Parameters.AddWithValue("@kitapnumarasi", BookNumberTxt.Text);  //form üzerinde girmiş olduğumuz text'leri veritabanına ekliyoruz
            komut.Parameters.AddWithValue("@kitapadi", BookNameTxt.Text);
            komut.Parameters.AddWithValue("@yazari", WriterTxt.Text);
            komut.Parameters.AddWithValue("@yayinevi", PublisherTxt.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", PageNumberTxt.Text);
            komut.Parameters.AddWithValue("@turu", BookTypeCombo.Text);
     
            komut.ExecuteNonQuery();  //verilen komutları oku

            baglanti.Close();

            MessageBox.Show("Kitap kaydı başarıyla gerçekleştirildi!");

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
    }
}
