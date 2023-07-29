using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient; //veritabanı için

namespace Library_App
{
    public partial class EscrowBookFrm : Form
    {
        public EscrowBookFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9KCML05V;Initial Catalog=LibraryApp;Integrated Security=True"); //veritabanına bağlandık
        DataSet daset = new DataSet();


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from DataGrid", baglanti);
            adtr.Fill(daset, "DataGrid");
            dataGridView1.DataSource = daset.Tables["Member"];
            baglanti.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into DataGrid(kitapno,kitapadi,yazari,yayinevi,sayfasayisi,teslimtarihi,iadetarihi) values(@kitapno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@kitapno", BookNumberTxt.Text);
            komut.Parameters.AddWithValue("@kitapadi", BookNameTxt.Text);
            komut.Parameters.AddWithValue("@yazari", WriterTxt.Text);
            komut.Parameters.AddWithValue("@yayinevi", PublisherTxt.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", PageNumberTxt.Text);
            komut.Parameters.AddWithValue("@teslimtarihi", TeslimdateTimePicker.Text);
            komut.Parameters.AddWithValue("@iadetarihi", IadedateTimePicker.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Emanet verilecek kitaplar listeye eklendi.");

            daset.Tables["DataGrid"].Clear();
            Listele();

            //bu kısımda Clear metodu çağırılabilir
            foreach(Control item in groupBox2.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void EscrowBookFrm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void FindTCTxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Member where tc like '" + FindTCTxt.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                NameTxt.Text = read["adsoyad"].ToString();
                TelTxt.Text = read["telefon"].ToString();
            }

            baglanti.Close();

            if (FindTCTxt.Text == "")
            {
                foreach(Control item in groupBox1.Controls)
                {
                    item.Text = "";
                }
            }
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
            }

            baglanti.Close();

            foreach(Control item in groupBox2.Controls)
            {
                item.Text = "";
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from DataGrid where kitapno= '" + dataGridView1.CurrentRow.Cells["kitapno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Silme işlemi gerçekleştirildi.","Silme işlemi");
            daset.Tables["DataGrid"].Clear();
            Listele();
        }
    }
}
