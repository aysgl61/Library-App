namespace Library_App
{
    partial class ListBooksFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.BookTypeCombo = new System.Windows.Forms.ComboBox();
            this.BookTypeLbl = new System.Windows.Forms.Label();
            this.PageNumberLbl = new System.Windows.Forms.Label();
            this.PublisherLbl = new System.Windows.Forms.Label();
            this.WriterLbl = new System.Windows.Forms.Label();
            this.BookNameLbl = new System.Windows.Forms.Label();
            this.BookNumberLbl = new System.Windows.Forms.Label();
            this.WriterTxt = new System.Windows.Forms.TextBox();
            this.PageNumberTxt = new System.Windows.Forms.TextBox();
            this.BookNameTxt = new System.Windows.Forms.TextBox();
            this.PublisherTxt = new System.Windows.Forms.TextBox();
            this.BookNumberTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FindBookNumberLbl = new System.Windows.Forms.Label();
            this.FindBookNumberTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.HeaderLbl);
            this.panel1.Location = new System.Drawing.Point(-11, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 91);
            this.panel1.TabIndex = 0;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderLbl.Location = new System.Drawing.Point(436, 29);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(195, 39);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Kitap Listesi";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.ExitBtn.Location = new System.Drawing.Point(208, 473);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(116, 37);
            this.ExitBtn.TabIndex = 29;
            this.ExitBtn.Text = "Çıkış";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.UpdateBtn.Location = new System.Drawing.Point(59, 473);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(116, 37);
            this.UpdateBtn.TabIndex = 28;
            this.UpdateBtn.Text = "Güncelle";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // BookTypeCombo
            // 
            this.BookTypeCombo.FormattingEnabled = true;
            this.BookTypeCombo.Items.AddRange(new object[] {
            "Roman",
            "Hikaye ",
            "Gezi ",
            "Şiir ",
            "Biyografi ",
            "Din ",
            "Çocuk kitapları",
            "Anı",
            "Anlatı",
            "Araştırma-İnceleme",
            "Bilim",
            "Otobiyografi",
            "Çizgi Roman",
            "Deneme",
            "Edebiyat",
            "Eğitim",
            "Felsefe",
            "Gençlik",
            "Gezi",
            "Hikaye",
            "Hobi",
            "İnceleme",
            "İş Ekonomi - Hukuk",
            "Kişisel Gelişim",
            "Konuşmalar",
            "Masal",
            "Mektup",
            "Mizah",
            "Öykü",
            "Polisiye",
            "Psikoloji",
            "Resimli Öykü",
            "Roman",
            "Sağlık",
            "Sanat - Tasarım",
            "Sanat- Müzik",
            "Sinema Tarihi",
            "Söyleşi",
            "Şiir",
            "Tarih",
            "Yemek Kitapları"});
            this.BookTypeCombo.Location = new System.Drawing.Point(135, 409);
            this.BookTypeCombo.Name = "BookTypeCombo";
            this.BookTypeCombo.Size = new System.Drawing.Size(189, 24);
            this.BookTypeCombo.TabIndex = 27;
            // 
            // BookTypeLbl
            // 
            this.BookTypeLbl.AutoSize = true;
            this.BookTypeLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookTypeLbl.Location = new System.Drawing.Point(45, 409);
            this.BookTypeLbl.Name = "BookTypeLbl";
            this.BookTypeLbl.Size = new System.Drawing.Size(86, 17);
            this.BookTypeLbl.TabIndex = 26;
            this.BookTypeLbl.Text = "Kitabın Türü";
            // 
            // PageNumberLbl
            // 
            this.PageNumberLbl.AutoSize = true;
            this.PageNumberLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PageNumberLbl.Location = new System.Drawing.Point(43, 353);
            this.PageNumberLbl.Name = "PageNumberLbl";
            this.PageNumberLbl.Size = new System.Drawing.Size(88, 17);
            this.PageNumberLbl.TabIndex = 25;
            this.PageNumberLbl.Text = "Sayfa Sayısı";
            // 
            // PublisherLbl
            // 
            this.PublisherLbl.AutoSize = true;
            this.PublisherLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PublisherLbl.Location = new System.Drawing.Point(71, 300);
            this.PublisherLbl.Name = "PublisherLbl";
            this.PublisherLbl.Size = new System.Drawing.Size(60, 17);
            this.PublisherLbl.TabIndex = 24;
            this.PublisherLbl.Text = "Yayınevi";
            // 
            // WriterLbl
            // 
            this.WriterLbl.AutoSize = true;
            this.WriterLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WriterLbl.Location = new System.Drawing.Point(24, 254);
            this.WriterLbl.Name = "WriterLbl";
            this.WriterLbl.Size = new System.Drawing.Size(96, 17);
            this.WriterLbl.TabIndex = 23;
            this.WriterLbl.Text = "Kitabın Yazarı";
            // 
            // BookNameLbl
            // 
            this.BookNameLbl.AutoSize = true;
            this.BookNameLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookNameLbl.Location = new System.Drawing.Point(56, 206);
            this.BookNameLbl.Name = "BookNameLbl";
            this.BookNameLbl.Size = new System.Drawing.Size(64, 17);
            this.BookNameLbl.TabIndex = 22;
            this.BookNameLbl.Text = "Kitap Adı";
            // 
            // BookNumberLbl
            // 
            this.BookNumberLbl.AutoSize = true;
            this.BookNumberLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookNumberLbl.Location = new System.Drawing.Point(12, 160);
            this.BookNumberLbl.Name = "BookNumberLbl";
            this.BookNumberLbl.Size = new System.Drawing.Size(108, 17);
            this.BookNumberLbl.TabIndex = 21;
            this.BookNumberLbl.Text = "Kitap Numarası";
            // 
            // WriterTxt
            // 
            this.WriterTxt.Location = new System.Drawing.Point(135, 251);
            this.WriterTxt.Name = "WriterTxt";
            this.WriterTxt.Size = new System.Drawing.Size(189, 22);
            this.WriterTxt.TabIndex = 20;
            // 
            // PageNumberTxt
            // 
            this.PageNumberTxt.Location = new System.Drawing.Point(135, 353);
            this.PageNumberTxt.Name = "PageNumberTxt";
            this.PageNumberTxt.Size = new System.Drawing.Size(189, 22);
            this.PageNumberTxt.TabIndex = 19;
            // 
            // BookNameTxt
            // 
            this.BookNameTxt.Location = new System.Drawing.Point(135, 203);
            this.BookNameTxt.Name = "BookNameTxt";
            this.BookNameTxt.Size = new System.Drawing.Size(189, 22);
            this.BookNameTxt.TabIndex = 18;
            // 
            // PublisherTxt
            // 
            this.PublisherTxt.Location = new System.Drawing.Point(135, 302);
            this.PublisherTxt.Name = "PublisherTxt";
            this.PublisherTxt.Size = new System.Drawing.Size(189, 22);
            this.PublisherTxt.TabIndex = 17;
            // 
            // BookNumberTxt
            // 
            this.BookNumberTxt.Location = new System.Drawing.Point(135, 157);
            this.BookNumberTxt.Name = "BookNumberTxt";
            this.BookNumberTxt.Size = new System.Drawing.Size(189, 22);
            this.BookNumberTxt.TabIndex = 16;
            this.BookNumberTxt.TextChanged += new System.EventHandler(this.BookNumberTxt_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(686, 276);
            this.dataGridView1.TabIndex = 30;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBtn.Location = new System.Drawing.Point(927, 464);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(116, 37);
            this.DeleteBtn.TabIndex = 31;
            this.DeleteBtn.Text = "Sil";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kitap Numarası";
            // 
            // FindBookNumberLbl
            // 
            this.FindBookNumberLbl.AutoSize = true;
            this.FindBookNumberLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FindBookNumberLbl.Location = new System.Drawing.Point(419, 482);
            this.FindBookNumberLbl.Name = "FindBookNumberLbl";
            this.FindBookNumberLbl.Size = new System.Drawing.Size(250, 19);
            this.FindBookNumberLbl.TabIndex = 32;
            this.FindBookNumberLbl.Text = "Kitap numarası ile arama yapınız";
            // 
            // FindBookNumberTxt
            // 
            this.FindBookNumberTxt.Location = new System.Drawing.Point(687, 481);
            this.FindBookNumberTxt.Name = "FindBookNumberTxt";
            this.FindBookNumberTxt.Size = new System.Drawing.Size(172, 22);
            this.FindBookNumberTxt.TabIndex = 33;
            this.FindBookNumberTxt.TextChanged += new System.EventHandler(this.FindBookNumberTxt_TextChanged);
            // 
            // ListBooksFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.FindBookNumberTxt);
            this.Controls.Add(this.FindBookNumberLbl);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.BookTypeCombo);
            this.Controls.Add(this.BookTypeLbl);
            this.Controls.Add(this.PageNumberLbl);
            this.Controls.Add(this.PublisherLbl);
            this.Controls.Add(this.WriterLbl);
            this.Controls.Add(this.BookNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookNumberLbl);
            this.Controls.Add(this.WriterTxt);
            this.Controls.Add(this.PageNumberTxt);
            this.Controls.Add(this.BookNameTxt);
            this.Controls.Add(this.PublisherTxt);
            this.Controls.Add(this.BookNumberTxt);
            this.Controls.Add(this.panel1);
            this.Name = "ListBooksFrm";
            this.Text = "Kitap Listesi";
            this.Load += new System.EventHandler(this.ListBooksFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ComboBox BookTypeCombo;
        private System.Windows.Forms.Label BookTypeLbl;
        private System.Windows.Forms.Label PageNumberLbl;
        private System.Windows.Forms.Label PublisherLbl;
        private System.Windows.Forms.Label WriterLbl;
        private System.Windows.Forms.Label BookNameLbl;
        private System.Windows.Forms.Label BookNumberLbl;
        private System.Windows.Forms.TextBox WriterTxt;
        private System.Windows.Forms.TextBox PageNumberTxt;
        private System.Windows.Forms.TextBox BookNameTxt;
        private System.Windows.Forms.TextBox PublisherTxt;
        private System.Windows.Forms.TextBox BookNumberTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FindBookNumberLbl;
        private System.Windows.Forms.TextBox FindBookNumberTxt;
    }
}