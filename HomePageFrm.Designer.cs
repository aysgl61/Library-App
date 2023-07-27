namespace Library_App
{
    partial class HomePageFrm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MemberGBox = new System.Windows.Forms.GroupBox();
            this.MemberListingBtn = new System.Windows.Forms.Button();
            this.MemberAddBtn = new System.Windows.Forms.Button();
            this.BookGBox = new System.Windows.Forms.GroupBox();
            this.BookListingBtn = new System.Windows.Forms.Button();
            this.BookAddBtn = new System.Windows.Forms.Button();
            this.DepositBookGBox = new System.Windows.Forms.GroupBox();
            this.DepositBookBackBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.DepositBookListingBtn = new System.Windows.Forms.Button();
            this.SortingGBox = new System.Windows.Forms.GroupBox();
            this.SortingBtn = new System.Windows.Forms.Button();
            this.GraphicsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.MemberGBox.SuspendLayout();
            this.BookGBox.SuspendLayout();
            this.DepositBookGBox.SuspendLayout();
            this.SortingGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.HeaderLabel);
            this.panel1.Location = new System.Drawing.Point(-11, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 91);
            this.panel1.TabIndex = 0;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.HeaderLabel.Location = new System.Drawing.Point(369, 31);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(336, 35);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Kütüphane Otomasyonu";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MemberGBox
            // 
            this.MemberGBox.Controls.Add(this.MemberListingBtn);
            this.MemberGBox.Controls.Add(this.MemberAddBtn);
            this.MemberGBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MemberGBox.Location = new System.Drawing.Point(77, 171);
            this.MemberGBox.Margin = new System.Windows.Forms.Padding(4);
            this.MemberGBox.Name = "MemberGBox";
            this.MemberGBox.Padding = new System.Windows.Forms.Padding(4);
            this.MemberGBox.Size = new System.Drawing.Size(323, 143);
            this.MemberGBox.TabIndex = 1;
            this.MemberGBox.TabStop = false;
            this.MemberGBox.Text = "Üye İşlemleri";
            // 
            // MemberListingBtn
            // 
            this.MemberListingBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.MemberListingBtn.Location = new System.Drawing.Point(24, 89);
            this.MemberListingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MemberListingBtn.Name = "MemberListingBtn";
            this.MemberListingBtn.Size = new System.Drawing.Size(279, 38);
            this.MemberListingBtn.TabIndex = 1;
            this.MemberListingBtn.Text = "Üye Listeleme İşlemleri";
            this.MemberListingBtn.UseVisualStyleBackColor = false;
            this.MemberListingBtn.Click += new System.EventHandler(this.MemberListingBtn_Click);
            // 
            // MemberAddBtn
            // 
            this.MemberAddBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.MemberAddBtn.Location = new System.Drawing.Point(24, 43);
            this.MemberAddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MemberAddBtn.Name = "MemberAddBtn";
            this.MemberAddBtn.Size = new System.Drawing.Size(279, 38);
            this.MemberAddBtn.TabIndex = 0;
            this.MemberAddBtn.Text = "Üye Ekleme İşlemleri";
            this.MemberAddBtn.UseVisualStyleBackColor = false;
            this.MemberAddBtn.Click += new System.EventHandler(this.MemberAddBtn_Click);
            // 
            // BookGBox
            // 
            this.BookGBox.Controls.Add(this.BookListingBtn);
            this.BookGBox.Controls.Add(this.BookAddBtn);
            this.BookGBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookGBox.Location = new System.Drawing.Point(649, 171);
            this.BookGBox.Margin = new System.Windows.Forms.Padding(4);
            this.BookGBox.Name = "BookGBox";
            this.BookGBox.Padding = new System.Windows.Forms.Padding(4);
            this.BookGBox.Size = new System.Drawing.Size(323, 143);
            this.BookGBox.TabIndex = 2;
            this.BookGBox.TabStop = false;
            this.BookGBox.Text = "Kitap İşlemleri";
            // 
            // BookListingBtn
            // 
            this.BookListingBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.BookListingBtn.Location = new System.Drawing.Point(21, 89);
            this.BookListingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BookListingBtn.Name = "BookListingBtn";
            this.BookListingBtn.Size = new System.Drawing.Size(279, 38);
            this.BookListingBtn.TabIndex = 1;
            this.BookListingBtn.Text = "Kitap Listeleme İşlemleri";
            this.BookListingBtn.UseVisualStyleBackColor = false;
            // 
            // BookAddBtn
            // 
            this.BookAddBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.BookAddBtn.Location = new System.Drawing.Point(21, 43);
            this.BookAddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BookAddBtn.Name = "BookAddBtn";
            this.BookAddBtn.Size = new System.Drawing.Size(279, 38);
            this.BookAddBtn.TabIndex = 0;
            this.BookAddBtn.Text = "Kitap Ekleme İşlemleri";
            this.BookAddBtn.UseVisualStyleBackColor = false;
            this.BookAddBtn.Click += new System.EventHandler(this.BookAddBtn_Click);
            // 
            // DepositBookGBox
            // 
            this.DepositBookGBox.Controls.Add(this.DepositBookBackBtn);
            this.DepositBookGBox.Controls.Add(this.button5);
            this.DepositBookGBox.Controls.Add(this.DepositBookListingBtn);
            this.DepositBookGBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DepositBookGBox.Location = new System.Drawing.Point(77, 359);
            this.DepositBookGBox.Margin = new System.Windows.Forms.Padding(4);
            this.DepositBookGBox.Name = "DepositBookGBox";
            this.DepositBookGBox.Padding = new System.Windows.Forms.Padding(4);
            this.DepositBookGBox.Size = new System.Drawing.Size(323, 178);
            this.DepositBookGBox.TabIndex = 3;
            this.DepositBookGBox.TabStop = false;
            this.DepositBookGBox.Text = "Emanet Kitap İşlemleri";
            // 
            // DepositBookBackBtn
            // 
            this.DepositBookBackBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.DepositBookBackBtn.Location = new System.Drawing.Point(24, 117);
            this.DepositBookBackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DepositBookBackBtn.Name = "DepositBookBackBtn";
            this.DepositBookBackBtn.Size = new System.Drawing.Size(279, 38);
            this.DepositBookBackBtn.TabIndex = 2;
            this.DepositBookBackBtn.Text = "Emanet Kitap İade İşlemleri";
            this.DepositBookBackBtn.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.Location = new System.Drawing.Point(24, 26);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(279, 38);
            this.button5.TabIndex = 0;
            this.button5.Text = "Emanet Kitap Verme İşlemleri";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // DepositBookListingBtn
            // 
            this.DepositBookListingBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.DepositBookListingBtn.Location = new System.Drawing.Point(24, 71);
            this.DepositBookListingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DepositBookListingBtn.Name = "DepositBookListingBtn";
            this.DepositBookListingBtn.Size = new System.Drawing.Size(279, 38);
            this.DepositBookListingBtn.TabIndex = 1;
            this.DepositBookListingBtn.Text = "Emanet Kitap Listeleme İşlemleri";
            this.DepositBookListingBtn.UseVisualStyleBackColor = false;
            // 
            // SortingGBox
            // 
            this.SortingGBox.Controls.Add(this.SortingBtn);
            this.SortingGBox.Controls.Add(this.GraphicsBtn);
            this.SortingGBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SortingGBox.Location = new System.Drawing.Point(649, 359);
            this.SortingGBox.Margin = new System.Windows.Forms.Padding(4);
            this.SortingGBox.Name = "SortingGBox";
            this.SortingGBox.Padding = new System.Windows.Forms.Padding(4);
            this.SortingGBox.Size = new System.Drawing.Size(323, 143);
            this.SortingGBox.TabIndex = 4;
            this.SortingGBox.TabStop = false;
            this.SortingGBox.Text = "Sıralama ve Grafikler";
            // 
            // SortingBtn
            // 
            this.SortingBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.SortingBtn.Location = new System.Drawing.Point(21, 26);
            this.SortingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortingBtn.Name = "SortingBtn";
            this.SortingBtn.Size = new System.Drawing.Size(279, 38);
            this.SortingBtn.TabIndex = 0;
            this.SortingBtn.Text = "Sıralama";
            this.SortingBtn.UseVisualStyleBackColor = false;
            // 
            // GraphicsBtn
            // 
            this.GraphicsBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.GraphicsBtn.Location = new System.Drawing.Point(21, 71);
            this.GraphicsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GraphicsBtn.Name = "GraphicsBtn";
            this.GraphicsBtn.Size = new System.Drawing.Size(279, 38);
            this.GraphicsBtn.TabIndex = 1;
            this.GraphicsBtn.Text = "Grafikler";
            this.GraphicsBtn.UseVisualStyleBackColor = false;
            // 
            // HomePageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SortingGBox);
            this.Controls.Add(this.DepositBookGBox);
            this.Controls.Add(this.BookGBox);
            this.Controls.Add(this.MemberGBox);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePageFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MemberGBox.ResumeLayout(false);
            this.BookGBox.ResumeLayout(false);
            this.DepositBookGBox.ResumeLayout(false);
            this.SortingGBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.GroupBox MemberGBox;
        private System.Windows.Forms.GroupBox BookGBox;
        private System.Windows.Forms.GroupBox DepositBookGBox;
        private System.Windows.Forms.GroupBox SortingGBox;
        private System.Windows.Forms.Button MemberListingBtn;
        private System.Windows.Forms.Button MemberAddBtn;
        private System.Windows.Forms.Button BookListingBtn;
        private System.Windows.Forms.Button BookAddBtn;
        private System.Windows.Forms.Button DepositBookBackBtn;
        private System.Windows.Forms.Button DepositBookListingBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button GraphicsBtn;
        private System.Windows.Forms.Button SortingBtn;
    }
}

