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

namespace Library_App
{
    public partial class ExcelBookFrm : Form
    {
        public ExcelBookFrm()
        {
            InitializeComponent();
        }

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

                OleDbDataAdapter adap = new OleDbDataAdapter("Select *from [Sayfa1$]", baglan);
                DataTable dt = new DataTable(); //excelden aldığım verileri geçici olarak tutmak için tanımladım
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                baglan.Close();
            }
        }
    }
}
