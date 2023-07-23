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
            TCTxt.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString(); //veritabanındaki tc'yi ilgili textbox'ta göster
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Member where tc like '"+TCTxt.Text+"'", baglanti);  //Member tablosundaki verilere ulaştık. 
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
            daset.Tables["Member"].Clear(); //tablodaki verilerde çakışma olmaması için önce temizliyoruz
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Member where like '%"+TCFindTxt.Text+"%'", baglanti);
            adtr.Fill(daset, "Member");
            dataGridView1.DataSource = daset.Tables["Member"];
            baglanti.Close();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek mi istiyorsunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Member where like tc=@tc", baglanti); //parameters ile erişeceğimiz için @ kullandık
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
            // TODO: Bu kod satırı 'libraryAppDataSet.Member' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.memberTableAdapter.Fill(this.libraryAppDataSet.Member);
            ListMember(); //form açıldığında üye listesi gelsin
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Member set adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,email=@email,okukitapsayisi=@okukitapsayisi,adres=@adres where tc=@tc", baglanti);

            komut.Parameters.AddWithValue("@tc", TCTxt.Text);
            komut.Parameters.AddWithValue("@adsoyad", NameTxt.Text);
            komut.Parameters.AddWithValue("@yas", AgeTxt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", GenderComboBOx.Text);
            komut.Parameters.AddWithValue("@telefon", TelTxt.Text);
            komut.Parameters.AddWithValue("@adres", addresstxt.Text);
            komut.Parameters.AddWithValue("@email", MailTxt.Text);
            komut.Parameters.AddWithValue("@okukitapsaiyisi",int.Parse(BookNumberTxt.Text));

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
