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
    public partial class SortingFrm : Form
    {
        public SortingFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9KCML05V;Initial Catalog=LibraryApp;Integrated Security=True"); //veritabanına bağlandık

        DataSet daset = new DataSet(); //verileri geçici olarak tutacağımız tablo

        private void SortingFrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EscrowBook", baglanti); //alınan kitap sayısına göre sıralanabilir.
            adtr.Fill(daset, "EscrowBook");                                                //yani totalde verilen emanet kitapları göstersin.
            dataGridView1.DataSource = daset.Tables["EscrowBook"];                         //kitaplar kime verilmiş onu da göster
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
