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
using System.Text.RegularExpressions;

namespace Library_App
{
    public partial class ExcelBookFrm : Form
    {

        Regex kitapnumarasirgx = new Regex(@"\d{1,}");  //kitapnumarası sadece sayı olabilir
        Regex kitapadirgx = new Regex(@"\w{1,}"); //kitap adi yazar adı harf,rakam vs olsun
        Regex yazarirgx = new Regex(@"\w{1,}"); //yazar adı harf,rakam vs olsun
        Regex yayinevirgx = new Regex(@"\w{1,}"); //yayinevi harf,rakam vs olsun
        Regex sayfasayisirgx = new Regex(@"\d{1,}");  //sayfa sayısı sadece sayı olabilir
        Regex turrgx = new Regex(@"\w{1,}"); //kitap türü yazar adı harf,rakam vs olsun                                              

        Match m;  //kitap no için
        Match m1; //kitap adi için
        Match m2;  //yazar için
        Match m3; //yayinevi için
        Match m4;  //sayfa no için
        Match m5; //tür için

        string kitapnumarasi,kitapadi,yazari,yayinevi,sayfasayisi,turu;
        int e0, e1, e2, e3, e4, e5,totalerror;  //hata sayısını tutar
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

            ChangeColor();
        }

 
        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            //datagrid içindeki verileri database içine aktarma işlemi
           

            Cursor.Current = Cursors.WaitCursor;

            totalerror = e0 + e1 + e2 + e3 + e4 + e5;
            int rows = dataGridView1.Rows.Count; 

            if(rows != 0)  //excelde veri varsa
            {
                for(int i=0; i < rows; i++)
                {
                    if (totalerror == 0)
                    {
                        baglanti.Open();

                        string kitapnumarasi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        string kitapadi = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        string yazari = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        string yayinevi = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        string sayfasayisi = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        string turu = dataGridView1.Rows[i].Cells[5].Value.ToString();

                        SqlCommand komut = new SqlCommand("insert into Books (kitapnumarasi,kitapadi,yazari,yayinevi,sayfasayisi,turu) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

                        komut.Parameters.AddWithValue("@p1", kitapnumarasi);
                        komut.Parameters.AddWithValue("@p2", kitapadi);
                        komut.Parameters.AddWithValue("@p3", yazari);
                        komut.Parameters.AddWithValue("@p4", yayinevi);
                        komut.Parameters.AddWithValue("@p5", sayfasayisi);
                        komut.Parameters.AddWithValue("@p6", turu);

                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Kitaplar veri tabanına kaydedildi.", "İşlem tamamlandı");
                    }

                    else if (e0 != 0)
                    {
                        MessageBox.Show("Kitap numarası sadece sayı formatında girilmelidir.", "Uyarı");
                        break;
                    }

                    else if (e1 != 0)
                    {
                        MessageBox.Show("Kitap adı harf veya rakam formatında girilmelidir.", "Uyarı");
                        break;
                    }

                    else if (e2 != 0)
                    {
                        MessageBox.Show("Yazar adı harf veya rakam formatında girilmelidir.", "Uyarı");
                        break;
                    }

                    else if (e3 != 0)
                    {
                        MessageBox.Show("Yayınevi adı harf veya rakam formatında girilmelidir.", "Uyarı");
                        break;
                    }

                    else if (e4 != 0)
                    {
                        MessageBox.Show("Sayfa sayısı sadece sayı formatında girilmelidir.", "Uyarı");
                        break;
                    }

                    else if (e5 != 0)
                    {
                        MessageBox.Show("Kitabı türü harf veya rakam formatında girilmelidir.", "Uyarı");
                        break;
                    }

                   
                }
            }

            Cursor.Current = Cursors.Default;

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        //hatalı verilerin rengini değiştirerek uyarı verir 
        private void ChangeColor()
        {
            for(int i=0; i < dataGridView1.Rows.Count; i++)
            {
                kitapnumarasi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                kitapadi = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                yazari = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                yayinevi = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                sayfasayisi = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                turu = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);

                m = kitapnumarasirgx.Match(kitapnumarasi);
                m1 = kitapadirgx.Match(kitapadi);
                m2 = yazarirgx.Match(yazari);
                m3 = yayinevirgx.Match(yayinevi);
                m4 = sayfasayisirgx.Match(sayfasayisi);
                m5 = turrgx.Match(turu);

                if (!m.Success)
                {
                    e0++;
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.White;
                }


                if (!m1.Success)
                {
                    e1++;
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.White;
                }


                if (!m2.Success)
                {
                    e2++;
                    dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.White;
                }


                if (!m3.Success)
                {
                    e3++;
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.White;
                }


                if (!m4.Success)
                {
                    e4++;
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.White;
                }


                if (!m5.Success)
                {
                    e5++;
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.White;
                }
            }
        }
    }
}
