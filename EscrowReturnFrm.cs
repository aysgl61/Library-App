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
    public partial class EscrowReturnFrm : Form
    {
        public EscrowReturnFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9KCML05V;Initial Catalog=LibraryApp;Integrated Security=True"); //veritabanına bağlandık
        DataSet daset = new DataSet();

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EscrowBook", baglanti);
            adtr.Fill(daset, "EscrowBook");
            dataGridView1.DataSource = daset.Tables["EscrowBook"];
            baglanti.Close();
        }

        private void EscrowReturnFrm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void findtctxt_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EscrowBook"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EscrowBook where tc like  '%"+findtctxt.Text+"%'", baglanti);
            adtr.Fill(daset, "EscrowBook");
            baglanti.Close();

            if (findtctxt.Text == "")
            {
                daset.Tables["EscrowBook"].Clear();
                Listele();
            }

        }

        private void findbooktxt_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EscrowBook"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EscrowBook where kitapno like  '%" + findbooktxt.Text+ "%'", baglanti);
            adtr.Fill(daset, "EscrowBook");
            baglanti.Close();

            if (findbooktxt.Text == "")
            {
                daset.Tables["EscrowBook"].Clear();
                Listele();
            }

        }
    }
}
