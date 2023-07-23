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
    }
}
