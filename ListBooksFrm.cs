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
    public partial class ListBooksFrm : Form
    {
        public ListBooksFrm()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9KCML05V;Initial Catalog=LibraryApp;Integrated Security=True"); //veritabanına bağlandık
        DataSet daset = new DataSet();

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBook()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Books ", baglanti);
            adtr.Fill(daset, "Books");
            dataGridView1.DataSource = daset.Tables["Books"];
            baglanti.Close();
        }

        private void ListBooksFrm_Load(object sender, EventArgs e)
        {
            ListBook();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if(dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Books where kitapnumarasi=@kitapnumarasi", baglanti);
                komut.Parameters.AddWithValue("@kitapnumarasi", dataGridView1.CurrentRow.Cells["kitapnumarasi"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Silme işlemi gerçekleştirildi.");
                daset.Tables["Books"].Clear();

                ListBook();

                Clear();
            }
        }

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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Books set kitapadi=@kitapadi, yazari=@yazari, yayinevi=@yayinevi, sayfasayisi=@sayfasayisi, turu=@turu where kitapnumarasi=@kitapnumarasi", baglanti);

            komut.Parameters.AddWithValue("@kitapnumarasi", BookNumberTxt.Text);
            komut.Parameters.AddWithValue("@kitapadi", BookNameTxt.Text);
            komut.Parameters.AddWithValue("@yazari", WriterTxt.Text);
            komut.Parameters.AddWithValue("@yayinevi", PublisherTxt.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", PageNumberTxt.Text);
            komut.Parameters.AddWithValue("@turu", BookTypeCombo.Text);
          

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Güncelleme işlemi gerçekleşti.");

            daset.Tables["Books"].Clear();

            ListBook();
            Clear();
           
        }

        private void FindBookNumberTxt_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Books"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Books where kitapnumarasi like '%" + FindBookNumberTxt.Text + "%'", baglanti);
            adtr.Fill(daset, "Books");
            dataGridView1.DataSource = daset.Tables["Books"];
            baglanti.Close();
        }

        private void BookNumberTxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Books where kitapnumarasi like '" + BookNumberTxt.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                BookNameTxt.Text = read["kitapadi"].ToString();
                WriterTxt.Text = read["yazari"].ToString();
                PublisherTxt.Text = read["yayinevi"].ToString();
                PageNumberTxt.Text = read["sayfasayisi"].ToString();
                BookTypeCombo.Text = read["turu"].ToString();
            }

            baglanti.Close();
        }
    }
}
