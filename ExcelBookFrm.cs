using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_App
{
    public partial class ExcelBookFrm : Form
    {
        public ExcelBookFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9KCML05V;Initial Catalog=LibraryApp;Integrated Security=True"); //veritabanına bağlandık

        private void secbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası |*.xls"; //Sadece xlsx ve xls uzantılı dosyaları seçebiliyoruz
            o.Title = "Excel Dosyası Seçiniz.";

            if (o.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection baglan;
                baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + o.FileName + "; Extended Properties='Excel 12.0 xml; HDR=YES'");
                baglan.Open();
                OleDbDataAdapter adap = new OleDbDataAdapter("Select *from [Sayfa1$]", baglan); //Sayfa1 içindeki verileri yazdır (excelde altta yazıyo Sayfa1 diye)
                DataTable dt = new DataTable(); //excelden aldığım verileri geçici olarak tutmak için tanımladım
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                baglan.Close();
            }
        }

 
        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            //datagrid içindeki verileri database içine aktarma işlemi
           

            Cursor.Current = Cursors.WaitCursor;

            int rows = dataGridView1.Rows.Count; 

            if(rows != 0)  //excelde veri varsa
            {
                for(int i=0; i < rows; i++)
                {
                    baglanti.Open();

                    string kitapnumarasi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string kitapadi = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string yazari = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string yayinevi = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string sayfasayisi= dataGridView1.Rows[i].Cells[4].Value.ToString();
                    string turu = dataGridView1.Rows[i].Cells[5].Value.ToString();

                    SqlCommand komut = new SqlCommand("insert into Books (kitapnumarasi,kitapadi,yazari,yayinevi,sayfasayisi,turu) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);

                    komut.Parameters.AddWithValue("@p1", kitapnumarasi);
                    komut.Parameters.AddWithValue("@p2", kitapadi);
                    komut.Parameters.AddWithValue("@p3", yazari);
                    komut.Parameters.AddWithValue("@p4", yayinevi);
                    komut.Parameters.AddWithValue("@p5", sayfasayisi);
                    komut.Parameters.AddWithValue("@p6", turu);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
            }

            Cursor.Current = Cursors.Default;

            MessageBox.Show("Kitaplar veri tabanına kaydedildi.","İşlem tamamlandı");

        }
    }
}
