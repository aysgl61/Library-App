namespace Library_App
{
    partial class AddBookFrm
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
            this.BookNumberTxt = new System.Windows.Forms.TextBox();
            this.PublisherTxt = new System.Windows.Forms.TextBox();
            this.BookNameTxt = new System.Windows.Forms.TextBox();
            this.PageNumberTxt = new System.Windows.Forms.TextBox();
            this.WriterTxt = new System.Windows.Forms.TextBox();
            this.BookNumberLbl = new System.Windows.Forms.Label();
            this.BookNameLbl = new System.Windows.Forms.Label();
            this.WriterLbl = new System.Windows.Forms.Label();
            this.PublisherLbl = new System.Windows.Forms.Label();
            this.PageNumberLbl = new System.Windows.Forms.Label();
            this.BookTypeLbl = new System.Windows.Forms.Label();
            this.BookTypeCombo = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.HeaderLbl);
            this.panel1.Location = new System.Drawing.Point(-9, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 97);
            this.panel1.TabIndex = 0;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderLbl.Location = new System.Drawing.Point(374, 31);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(333, 38);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Kitap Ekleme İşlemleri";
            // 
            // BookNumberTxt
            // 
            this.BookNumberTxt.Location = new System.Drawing.Point(257, 212);
            this.BookNumberTxt.Name = "BookNumberTxt";
            this.BookNumberTxt.Size = new System.Drawing.Size(189, 25);
            this.BookNumberTxt.TabIndex = 1;
            // 
            // PublisherTxt
            // 
            this.PublisherTxt.Location = new System.Drawing.Point(649, 212);
            this.PublisherTxt.Name = "PublisherTxt";
            this.PublisherTxt.Size = new System.Drawing.Size(189, 25);
            this.PublisherTxt.TabIndex = 2;
            // 
            // BookNameTxt
            // 
            this.BookNameTxt.Location = new System.Drawing.Point(257, 287);
            this.BookNameTxt.Name = "BookNameTxt";
            this.BookNameTxt.Size = new System.Drawing.Size(189, 25);
            this.BookNameTxt.TabIndex = 3;
            // 
            // PageNumberTxt
            // 
            this.PageNumberTxt.Location = new System.Drawing.Point(649, 287);
            this.PageNumberTxt.Name = "PageNumberTxt";
            this.PageNumberTxt.Size = new System.Drawing.Size(189, 25);
            this.PageNumberTxt.TabIndex = 4;
            // 
            // WriterTxt
            // 
            this.WriterTxt.Location = new System.Drawing.Point(257, 363);
            this.WriterTxt.Name = "WriterTxt";
            this.WriterTxt.Size = new System.Drawing.Size(189, 25);
            this.WriterTxt.TabIndex = 6;
            // 
            // BookNumberLbl
            // 
            this.BookNumberLbl.AutoSize = true;
            this.BookNumberLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookNumberLbl.Location = new System.Drawing.Point(134, 215);
            this.BookNumberLbl.Name = "BookNumberLbl";
            this.BookNumberLbl.Size = new System.Drawing.Size(108, 17);
            this.BookNumberLbl.TabIndex = 7;
            this.BookNumberLbl.Text = "Kitap Numarası";
            // 
            // BookNameLbl
            // 
            this.BookNameLbl.AutoSize = true;
            this.BookNameLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookNameLbl.Location = new System.Drawing.Point(178, 290);
            this.BookNameLbl.Name = "BookNameLbl";
            this.BookNameLbl.Size = new System.Drawing.Size(64, 17);
            this.BookNameLbl.TabIndex = 8;
            this.BookNameLbl.Text = "Kitap Adı";
            // 
            // WriterLbl
            // 
            this.WriterLbl.AutoSize = true;
            this.WriterLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WriterLbl.Location = new System.Drawing.Point(146, 366);
            this.WriterLbl.Name = "WriterLbl";
            this.WriterLbl.Size = new System.Drawing.Size(96, 17);
            this.WriterLbl.TabIndex = 9;
            this.WriterLbl.Text = "Kitabın Yazarı";
            // 
            // PublisherLbl
            // 
            this.PublisherLbl.AutoSize = true;
            this.PublisherLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PublisherLbl.Location = new System.Drawing.Point(585, 210);
            this.PublisherLbl.Name = "PublisherLbl";
            this.PublisherLbl.Size = new System.Drawing.Size(60, 17);
            this.PublisherLbl.TabIndex = 10;
            this.PublisherLbl.Text = "Yayınevi";
            // 
            // PageNumberLbl
            // 
            this.PageNumberLbl.AutoSize = true;
            this.PageNumberLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PageNumberLbl.Location = new System.Drawing.Point(557, 287);
            this.PageNumberLbl.Name = "PageNumberLbl";
            this.PageNumberLbl.Size = new System.Drawing.Size(88, 17);
            this.PageNumberLbl.TabIndex = 11;
            this.PageNumberLbl.Text = "Sayfa Sayısı";
            // 
            // BookTypeLbl
            // 
            this.BookTypeLbl.AutoSize = true;
            this.BookTypeLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookTypeLbl.Location = new System.Drawing.Point(559, 371);
            this.BookTypeLbl.Name = "BookTypeLbl";
            this.BookTypeLbl.Size = new System.Drawing.Size(86, 17);
            this.BookTypeLbl.TabIndex = 12;
            this.BookTypeLbl.Text = "Kitabın Türü";
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
            this.BookTypeCombo.Location = new System.Drawing.Point(649, 371);
            this.BookTypeCombo.Name = "BookTypeCombo";
            this.BookTypeCombo.Size = new System.Drawing.Size(189, 25);
            this.BookTypeCombo.TabIndex = 13;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.AddBtn.Location = new System.Drawing.Point(372, 470);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(116, 37);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Ekle";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.ExitBtn.Location = new System.Drawing.Point(582, 470);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(116, 37);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.Text = "Çıkış";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // AddBookFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 589);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.BookTypeCombo);
            this.Controls.Add(this.BookTypeLbl);
            this.Controls.Add(this.PageNumberLbl);
            this.Controls.Add(this.PublisherLbl);
            this.Controls.Add(this.WriterLbl);
            this.Controls.Add(this.BookNameLbl);
            this.Controls.Add(this.BookNumberLbl);
            this.Controls.Add(this.WriterTxt);
            this.Controls.Add(this.PageNumberTxt);
            this.Controls.Add(this.BookNameTxt);
            this.Controls.Add(this.PublisherTxt);
            this.Controls.Add(this.BookNumberTxt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AddBookFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekleme Sayfası";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.TextBox BookNumberTxt;
        private System.Windows.Forms.TextBox PublisherTxt;
        private System.Windows.Forms.TextBox BookNameTxt;
        private System.Windows.Forms.TextBox PageNumberTxt;
        private System.Windows.Forms.TextBox WriterTxt;
        private System.Windows.Forms.Label BookNumberLbl;
        private System.Windows.Forms.Label BookNameLbl;
        private System.Windows.Forms.Label WriterLbl;
        private System.Windows.Forms.Label PageNumberLbl;
        private System.Windows.Forms.Label BookTypeLbl;
        private System.Windows.Forms.Label PublisherLbl;
        private System.Windows.Forms.ComboBox BookTypeCombo;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}