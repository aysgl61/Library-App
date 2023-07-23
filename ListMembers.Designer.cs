namespace Library_App
{
    partial class ListMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MemberListLbl = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.GenderComboBOx = new System.Windows.Forms.ComboBox();
            this.TelTxt = new System.Windows.Forms.TextBox();
            this.BookNumberTxt = new System.Windows.Forms.TextBox();
            this.MailTxt = new System.Windows.Forms.TextBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BookNumLbl = new System.Windows.Forms.Label();
            this.MailLbl = new System.Windows.Forms.Label();
            this.TelLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.TCLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.TCFindTxt = new System.Windows.Forms.TextBox();
            this.TCFindLbl = new System.Windows.Forms.Label();
            this.libraryAppDataSet = new Library_App.LibraryAppDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new Library_App.LibraryAppDataSetTableAdapters.MemberTableAdapter();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okukitapsayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.MemberListLbl);
            this.panel1.Location = new System.Drawing.Point(-11, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 91);
            this.panel1.TabIndex = 0;
            // 
            // MemberListLbl
            // 
            this.MemberListLbl.AutoSize = true;
            this.MemberListLbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MemberListLbl.Location = new System.Drawing.Point(463, 28);
            this.MemberListLbl.Name = "MemberListLbl";
            this.MemberListLbl.Size = new System.Drawing.Size(161, 35);
            this.MemberListLbl.TabIndex = 0;
            this.MemberListLbl.Text = "Üye Listesi";
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(138, 303);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(155, 22);
            this.addresstxt.TabIndex = 34;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addressLbl.Location = new System.Drawing.Point(13, 309);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(42, 17);
            this.addressLbl.TabIndex = 33;
            this.addressLbl.Text = "Şehir";
            // 
            // GenderComboBOx
            // 
            this.GenderComboBOx.FormattingEnabled = true;
            this.GenderComboBOx.Items.AddRange(new object[] {
            "Kadın ",
            "Erkek"});
            this.GenderComboBOx.Location = new System.Drawing.Point(138, 266);
            this.GenderComboBOx.Name = "GenderComboBOx";
            this.GenderComboBOx.Size = new System.Drawing.Size(155, 24);
            this.GenderComboBOx.TabIndex = 32;
            // 
            // TelTxt
            // 
            this.TelTxt.Location = new System.Drawing.Point(138, 348);
            this.TelTxt.Name = "TelTxt";
            this.TelTxt.Size = new System.Drawing.Size(155, 22);
            this.TelTxt.TabIndex = 31;
            // 
            // BookNumberTxt
            // 
            this.BookNumberTxt.Location = new System.Drawing.Point(138, 430);
            this.BookNumberTxt.Name = "BookNumberTxt";
            this.BookNumberTxt.Size = new System.Drawing.Size(155, 22);
            this.BookNumberTxt.TabIndex = 30;
            // 
            // MailTxt
            // 
            this.MailTxt.Location = new System.Drawing.Point(138, 392);
            this.MailTxt.Name = "MailTxt";
            this.MailTxt.Size = new System.Drawing.Size(155, 22);
            this.MailTxt.TabIndex = 29;
            // 
            // AgeTxt
            // 
            this.AgeTxt.Location = new System.Drawing.Point(138, 229);
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.Size = new System.Drawing.Size(155, 22);
            this.AgeTxt.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BookNumLbl
            // 
            this.BookNumLbl.AutoSize = true;
            this.BookNumLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookNumLbl.Location = new System.Drawing.Point(1, 432);
            this.BookNumLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookNumLbl.Name = "BookNumLbl";
            this.BookNumLbl.Size = new System.Drawing.Size(139, 17);
            this.BookNumLbl.TabIndex = 25;
            this.BookNumLbl.Text = "Okunan Kitap Sayısı";
            // 
            // MailLbl
            // 
            this.MailLbl.AutoSize = true;
            this.MailLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MailLbl.Location = new System.Drawing.Point(19, 394);
            this.MailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MailLbl.Name = "MailLbl";
            this.MailLbl.Size = new System.Drawing.Size(54, 17);
            this.MailLbl.TabIndex = 24;
            this.MailLbl.Text = "E- mail";
            // 
            // TelLbl
            // 
            this.TelLbl.AutoSize = true;
            this.TelLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelLbl.Location = new System.Drawing.Point(13, 353);
            this.TelLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TelLbl.Name = "TelLbl";
            this.TelLbl.Size = new System.Drawing.Size(54, 17);
            this.TelLbl.TabIndex = 23;
            this.TelLbl.Text = "Telefon";
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenderLbl.Location = new System.Drawing.Point(13, 273);
            this.GenderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(60, 17);
            this.GenderLbl.TabIndex = 22;
            this.GenderLbl.Text = "Cinsiyet";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AgeLbl.Location = new System.Drawing.Point(13, 234);
            this.AgeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(32, 17);
            this.AgeLbl.TabIndex = 21;
            this.AgeLbl.Text = "Yaş";
            // 
            // TCLbl
            // 
            this.TCLbl.AutoSize = true;
            this.TCLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCLbl.Location = new System.Drawing.Point(13, 160);
            this.TCLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TCLbl.Name = "TCLbl";
            this.TCLbl.Size = new System.Drawing.Size(28, 17);
            this.TCLbl.TabIndex = 19;
            this.TCLbl.Text = "TC";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLbl.Location = new System.Drawing.Point(13, 197);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(70, 17);
            this.NameLbl.TabIndex = 20;
            this.NameLbl.Text = "Ad Soyad";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(138, 192);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(155, 22);
            this.NameTxt.TabIndex = 27;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateBtn.Location = new System.Drawing.Point(20, 488);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(116, 37);
            this.UpdateBtn.TabIndex = 35;
            this.UpdateBtn.Text = "Güncelle";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.ExitBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitBtn.Location = new System.Drawing.Point(177, 488);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(116, 37);
            this.ExitBtn.TabIndex = 36;
            this.ExitBtn.Text = "Çıkış";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.yasDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.okukitapsayisiDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(357, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(666, 299);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBtn.Location = new System.Drawing.Point(767, 488);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(116, 37);
            this.DeleteBtn.TabIndex = 38;
            this.DeleteBtn.Text = "Sil";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // TCFindTxt
            // 
            this.TCFindTxt.Location = new System.Drawing.Point(575, 496);
            this.TCFindTxt.Name = "TCFindTxt";
            this.TCFindTxt.Size = new System.Drawing.Size(164, 22);
            this.TCFindTxt.TabIndex = 40;
            this.TCFindTxt.TextChanged += new System.EventHandler(this.TCFindTxt_TextChanged);
            // 
            // TCFindLbl
            // 
            this.TCFindLbl.AutoSize = true;
            this.TCFindLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCFindLbl.Location = new System.Drawing.Point(501, 498);
            this.TCFindLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TCFindLbl.Name = "TCFindLbl";
            this.TCFindLbl.Size = new System.Drawing.Size(53, 17);
            this.TCFindLbl.TabIndex = 39;
            this.TCFindLbl.Text = "TC ara";
            // 
            // libraryAppDataSet
            // 
            this.libraryAppDataSet.DataSetName = "LibraryAppDataSet";
            this.libraryAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.libraryAppDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.Width = 125;
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            this.adsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yasDataGridViewTextBoxColumn
            // 
            this.yasDataGridViewTextBoxColumn.DataPropertyName = "yas";
            this.yasDataGridViewTextBoxColumn.HeaderText = "yas";
            this.yasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yasDataGridViewTextBoxColumn.Name = "yasDataGridViewTextBoxColumn";
            this.yasDataGridViewTextBoxColumn.Width = 125;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // okukitapsayisiDataGridViewTextBoxColumn
            // 
            this.okukitapsayisiDataGridViewTextBoxColumn.DataPropertyName = "okukitapsayisi";
            this.okukitapsayisiDataGridViewTextBoxColumn.HeaderText = "okukitapsayisi";
            this.okukitapsayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.okukitapsayisiDataGridViewTextBoxColumn.Name = "okukitapsayisiDataGridViewTextBoxColumn";
            this.okukitapsayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // ListMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TCFindTxt);
            this.Controls.Add(this.TCFindLbl);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.GenderComboBOx);
            this.Controls.Add(this.TelTxt);
            this.Controls.Add(this.BookNumberTxt);
            this.Controls.Add(this.MailTxt);
            this.Controls.Add(this.AgeTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BookNumLbl);
            this.Controls.Add(this.MailLbl);
            this.Controls.Add(this.TelLbl);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.TCLbl);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Üye Listesi";
            this.Load += new System.EventHandler(this.ListMembers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MemberListLbl;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.ComboBox GenderComboBOx;
        private System.Windows.Forms.TextBox TelTxt;
        private System.Windows.Forms.TextBox BookNumberTxt;
        private System.Windows.Forms.TextBox MailTxt;
        private System.Windows.Forms.TextBox AgeTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label BookNumLbl;
        private System.Windows.Forms.Label MailLbl;
        private System.Windows.Forms.Label TelLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label TCLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox TCFindTxt;
        private System.Windows.Forms.Label TCFindLbl;
        private LibraryAppDataSet libraryAppDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private LibraryAppDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okukitapsayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}