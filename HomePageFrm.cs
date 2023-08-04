using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_App
{
    public partial class HomePageFrm : Form
    {
        public HomePageFrm()
        {
            InitializeComponent();
        }

        private void MemberAddBtn_Click(object sender, EventArgs e)
        {
            AddMemberFrm addm = new AddMemberFrm();
            addm.ShowDialog();  //bu butona basınca üye ekleme ekranı açılacak
        }

        private void MemberListingBtn_Click(object sender, EventArgs e)
        {
            ListMembers lstm = new ListMembers();
            lstm.ShowDialog();
        }

        private void BookAddBtn_Click(object sender, EventArgs e)
        {
            AddBookFrm addb = new AddBookFrm();
            addb.ShowDialog();
        }

        private void BookListingBtn_Click(object sender, EventArgs e)
        {
            ListBooksFrm lstb = new ListBooksFrm();
            lstb.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EscrowBookFrm ebf = new EscrowBookFrm();
            ebf.ShowDialog();
        }

        private void DepositBookListingBtn_Click(object sender, EventArgs e)
        {
            ListEscrowBookFrm lebf = new ListEscrowBookFrm();
            lebf.ShowDialog();
        }

        private void DepositBookBackBtn_Click(object sender, EventArgs e)
        {
            EscrowReturnFrm erf = new EscrowReturnFrm();
            erf.ShowDialog();
        }

        private void SortingBtn_Click(object sender, EventArgs e)
        {
            SortingFrm sfrm = new SortingFrm();
            sfrm.ShowDialog();
        }

        private void excelbookbtn_Click(object sender, EventArgs e)
        {
            ExcelBookFrm ebf = new ExcelBookFrm();
            ebf.ShowDialog();
        }
    }
}
