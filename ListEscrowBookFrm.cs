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
    public partial class ListEscrowBookFrm : Form
    {
        public ListEscrowBookFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9KCML05V;Initial Catalog=LibraryApp;Integrated Security=True"); //veritabanına bağlandık

        DataSet daset = new DataSet(); //verileri geçici olarak tutacağımız tablo

        private void ListEscrowBookFrm_Load(object sender, EventArgs e)
        {
            Listele();
            FilterComboBox.SelectedIndex = 0; //combobox içinde ilk index otomatik olarak seçili gelsin
        }

        private void Listele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EscrowBook", baglanti);
            adtr.Fill(daset, "EscrowBook");
            dataGridView1.DataSource = daset.Tables["EscrowBook"];
            baglanti.Close();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["EscrowBook"].Clear();

            if (FilterComboBox.SelectedIndex == 0) //tüm kitapları listele
            {
                Listele();
            }
            else if (FilterComboBox.SelectedIndex == 1) //geciken kitapları listele
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from EscrowBook where '"+DateTime.Now.ToShortDateString()+"'>iadetarihi ", baglanti); //şu anın tarihi iade tarihinden geçse kitap, zamanında getirilmemiştir
                adtr.Fill(daset, "EscrowBook");
                dataGridView1.DataSource = daset.Tables["EscrowBook"];
                baglanti.Close();
            }
            else if (FilterComboBox.SelectedIndex == 2) //gecikmeyen kitapları listele
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from EscrowBook where '" + DateTime.Now.ToShortDateString() + "'<=iadetarihi ", baglanti); //şu anın tarihi iade tarihini geçmemişse kitap, zamanında getirilmiştir
                adtr.Fill(daset, "EscrowBook");
                dataGridView1.DataSource = daset.Tables["EscrowBook"];
                baglanti.Close();
            }
        }
    }
}
