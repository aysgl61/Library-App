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
    public partial class ListMembers : Form
    {
        public ListMembers()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9KCML05V;Initial Catalog=LibraryApp;Integrated Security=True"); //veritabanına bağlandık

        DataSet daset = new DataSet(); //verileri geçici olarak tutacağımız tablo

        /*   private void NameLbl_Click(object sender, EventArgs e)
           {

           }

           private void NameTxt_TextChanged(object sender, EventArgs e)
           {

           }*/

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString(); //veritabanındaki tc'yi ilgili textbox'ta göster
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Member where tc like '"+textBox1.Text+"'", baglanti);  //Member tablosundaki verilere ulaştık. 
            SqlDataReader read = komut.ExecuteReader(); //tablodaki verileri textlere atar
            while (read.Read()) //tablodaki veriler okunduğu sürece
            {
                NameTxt.Text = read["adsoyad"].ToString();
                AgeTxt.Text = read["yas"].ToString();
                GenderComboBOx.Text = read["cinsiyet"].ToString();
                TelTxt.Text = read["telefon"].ToString();
                MailTxt.Text = read["email"].ToString();
                BookNumberTxt.Text = read["okukitapsayisi"].ToString();
                addresstxt.Text = read["adres"].ToString();
            }

            baglanti.Close();
        }

        private void TCFindTxt_TextChanged(object sender, EventArgs e)
        {
            // Textbox'tan girilen değeri alalım
            string tcValue = TCFindTxt.Text.Trim();

            // Eğer girilen değer boş ise, veritabanından tüm verileri çekelim
            if (string.IsNullOrEmpty(tcValue))
            {
                ListMember();
                return;
            }

            // Girilen değeri içeren verileri çekmek için parametreli sorgu kullanalım
            string query = "SELECT * FROM Member WHERE tc LIKE @tc";

            // Parametre oluşturalım
            SqlParameter parameter = new SqlParameter("@tc", "%" + tcValue + "%");

            // Bağlantıyı açalım ve verileri çekelim
            try
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(query, baglanti);
                adtr.SelectCommand.Parameters.Add(parameter);
                daset.Tables["Member"].Clear();
                adtr.Fill(daset, "Member");
                dataGridView1.DataSource = daset.Tables["Member"];
            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajını gösterelim
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatalım
                baglanti.Close();
            }
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bu kaydı silmek mi istiyorsunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Member where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleşti.");

                daset.Tables["Member"].Clear();
                ListMember();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }


        private void ListMember()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Member", baglanti);
            dataGridView1.DataSource = daset.Tables["Member"];
            baglanti.Close();
        }

        private void ListMembers_Load(object sender, EventArgs e)
        {
            // Önce bağlantıyı açalım
            baglanti.Open();

            // SqlDataAdapter ile verileri çekip DataSet'e dolduralım
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM Member", baglanti);
            adtr.Fill(daset, "Member");

            // DataGridView'e DataSet'teki tabloyu bağlayalım
            dataGridView1.DataSource = daset.Tables["Member"];

            // Bağlantıyı kapatmayı unutmayalım
            baglanti.Close();
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Member set adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,email=@email,adres=@adres where tc=@tc", baglanti);

            komut.Parameters.AddWithValue("@tc", textBox1.Text);
            komut.Parameters.AddWithValue("@adsoyad", NameTxt.Text);
            komut.Parameters.AddWithValue("@yas", AgeTxt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", GenderComboBOx.Text);
            komut.Parameters.AddWithValue("@telefon", TelTxt.Text);
            komut.Parameters.AddWithValue("@adres", addresstxt.Text);
            komut.Parameters.AddWithValue("@email", MailTxt.Text);
           // komut.Parameters.AddWithValue("@okukitapsaiyisi", int.Parse(BookNumberTxt.Text));

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Güncelleme işlemi gerçekleşti.");

            daset.Tables["Member"].Clear();
            ListMember();

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
