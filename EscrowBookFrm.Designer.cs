namespace Library_App
{
    partial class EscrowBookFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TelLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.FindTCLbl = new System.Windows.Forms.Label();
            this.TelTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.FindTCTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IadedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TeslimdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PageNumberTxt = new System.Windows.Forms.TextBox();
            this.PublisherTxt = new System.Windows.Forms.TextBox();
            this.WriterTxt = new System.Windows.Forms.TextBox();
            this.BookNameTxt = new System.Windows.Forms.TextBox();
            this.BookNumberTxt = new System.Windows.Forms.TextBox();
            this.IadeLbl = new System.Windows.Forms.Label();
            this.TeslimLbl = new System.Windows.Forms.Label();
            this.PageNumberLbl = new System.Windows.Forms.Label();
            this.PublisherLbl = new System.Windows.Forms.Label();
            this.WriterLbl = new System.Windows.Forms.Label();
            this.BookNameLbl = new System.Windows.Forms.Label();
            this.BookNumberLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TeslimBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.HeaderLbl);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(-9, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 91);
            this.panel1.TabIndex = 0;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HeaderLbl.Location = new System.Drawing.Point(355, 32);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(438, 38);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Emanet Kitap Verme İşlemleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 334);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TelLbl);
            this.groupBox1.Controls.Add(this.NameLbl);
            this.groupBox1.Controls.Add(this.FindTCLbl);
            this.groupBox1.Controls.Add(this.TelTxt);
            this.groupBox1.Controls.Add(this.NameTxt);
            this.groupBox1.Controls.Add(this.FindTCTxt);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri";
            // 
            // TelLbl
            // 
            this.TelLbl.AutoSize = true;
            this.TelLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelLbl.Location = new System.Drawing.Point(46, 112);
            this.TelLbl.Name = "TelLbl";
            this.TelLbl.Size = new System.Drawing.Size(54, 17);
            this.TelLbl.TabIndex = 5;
            this.TelLbl.Text = "Telefon";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLbl.Location = new System.Drawing.Point(31, 75);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(70, 17);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Ad Soyad";
            // 
            // FindTCLbl
            // 
            this.FindTCLbl.AutoSize = true;
            this.FindTCLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FindTCLbl.Location = new System.Drawing.Point(48, 38);
            this.FindTCLbl.Name = "FindTCLbl";
            this.FindTCLbl.Size = new System.Drawing.Size(53, 17);
            this.FindTCLbl.TabIndex = 3;
            this.FindTCLbl.Text = "TC Ara";
            // 
            // TelTxt
            // 
            this.TelTxt.Location = new System.Drawing.Point(120, 108);
            this.TelTxt.Name = "TelTxt";
            this.TelTxt.Size = new System.Drawing.Size(178, 27);
            this.TelTxt.TabIndex = 2;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(120, 71);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(178, 27);
            this.NameTxt.TabIndex = 1;
            // 
            // FindTCTxt
            // 
            this.FindTCTxt.Location = new System.Drawing.Point(120, 34);
            this.FindTCTxt.Name = "FindTCTxt";
            this.FindTCTxt.Size = new System.Drawing.Size(178, 27);
            this.FindTCTxt.TabIndex = 0;
            this.FindTCTxt.TextChanged += new System.EventHandler(this.FindTCTxt_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IadedateTimePicker);
            this.groupBox2.Controls.Add(this.TeslimdateTimePicker);
            this.groupBox2.Controls.Add(this.PageNumberTxt);
            this.groupBox2.Controls.Add(this.PublisherTxt);
            this.groupBox2.Controls.Add(this.WriterTxt);
            this.groupBox2.Controls.Add(this.BookNameTxt);
            this.groupBox2.Controls.Add(this.BookNumberTxt);
            this.groupBox2.Controls.Add(this.IadeLbl);
            this.groupBox2.Controls.Add(this.TeslimLbl);
            this.groupBox2.Controls.Add(this.PageNumberLbl);
            this.groupBox2.Controls.Add(this.PublisherLbl);
            this.groupBox2.Controls.Add(this.WriterLbl);
            this.groupBox2.Controls.Add(this.BookNameLbl);
            this.groupBox2.Controls.Add(this.BookNumberLbl);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 276);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgileri";
            // 
            // IadedateTimePicker
            // 
            this.IadedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IadedateTimePicker.Location = new System.Drawing.Point(120, 235);
            this.IadedateTimePicker.Name = "IadedateTimePicker";
            this.IadedateTimePicker.Size = new System.Drawing.Size(178, 27);
            this.IadedateTimePicker.TabIndex = 13;
            // 
            // TeslimdateTimePicker
            // 
            this.TeslimdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TeslimdateTimePicker.Location = new System.Drawing.Point(120, 202);
            this.TeslimdateTimePicker.Name = "TeslimdateTimePicker";
            this.TeslimdateTimePicker.Size = new System.Drawing.Size(178, 27);
            this.TeslimdateTimePicker.TabIndex = 12;
            // 
            // PageNumberTxt
            // 
            this.PageNumberTxt.Location = new System.Drawing.Point(120, 168);
            this.PageNumberTxt.Name = "PageNumberTxt";
            this.PageNumberTxt.Size = new System.Drawing.Size(178, 27);
            this.PageNumberTxt.TabIndex = 11;
            // 
            // PublisherTxt
            // 
            this.PublisherTxt.Location = new System.Drawing.Point(120, 135);
            this.PublisherTxt.Name = "PublisherTxt";
            this.PublisherTxt.Size = new System.Drawing.Size(178, 27);
            this.PublisherTxt.TabIndex = 10;
            // 
            // WriterTxt
            // 
            this.WriterTxt.Location = new System.Drawing.Point(120, 102);
            this.WriterTxt.Name = "WriterTxt";
            this.WriterTxt.Size = new System.Drawing.Size(178, 27);
            this.WriterTxt.TabIndex = 9;
            // 
            // BookNameTxt
            // 
            this.BookNameTxt.Location = new System.Drawing.Point(120, 69);
            this.BookNameTxt.Name = "BookNameTxt";
            this.BookNameTxt.Size = new System.Drawing.Size(178, 27);
            this.BookNameTxt.TabIndex = 8;
            // 
            // BookNumberTxt
            // 
            this.BookNumberTxt.Location = new System.Drawing.Point(120, 36);
            this.BookNumberTxt.Name = "BookNumberTxt";
            this.BookNumberTxt.Size = new System.Drawing.Size(178, 27);
            this.BookNumberTxt.TabIndex = 7;
            this.BookNumberTxt.TextChanged += new System.EventHandler(this.BookNumberTxt_TextChanged);
            // 
            // IadeLbl
            // 
            this.IadeLbl.AutoSize = true;
            this.IadeLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IadeLbl.Location = new System.Drawing.Point(41, 242);
            this.IadeLbl.Name = "IadeLbl";
            this.IadeLbl.Size = new System.Drawing.Size(73, 17);
            this.IadeLbl.TabIndex = 6;
            this.IadeLbl.Text = "İade Tarihi";
            // 
            // TeslimLbl
            // 
            this.TeslimLbl.AutoSize = true;
            this.TeslimLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeslimLbl.Location = new System.Drawing.Point(26, 209);
            this.TeslimLbl.Name = "TeslimLbl";
            this.TeslimLbl.Size = new System.Drawing.Size(88, 17);
            this.TeslimLbl.TabIndex = 5;
            this.TeslimLbl.Text = "Teslim Tarihi";
            // 
            // PageNumberLbl
            // 
            this.PageNumberLbl.AutoSize = true;
            this.PageNumberLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PageNumberLbl.Location = new System.Drawing.Point(26, 172);
            this.PageNumberLbl.Name = "PageNumberLbl";
            this.PageNumberLbl.Size = new System.Drawing.Size(88, 17);
            this.PageNumberLbl.TabIndex = 4;
            this.PageNumberLbl.Text = "Sayfa Sayısı";
            // 
            // PublisherLbl
            // 
            this.PublisherLbl.AutoSize = true;
            this.PublisherLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PublisherLbl.Location = new System.Drawing.Point(54, 139);
            this.PublisherLbl.Name = "PublisherLbl";
            this.PublisherLbl.Size = new System.Drawing.Size(60, 17);
            this.PublisherLbl.TabIndex = 3;
            this.PublisherLbl.Text = "Yayınevi";
            // 
            // WriterLbl
            // 
            this.WriterLbl.AutoSize = true;
            this.WriterLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WriterLbl.Location = new System.Drawing.Point(66, 106);
            this.WriterLbl.Name = "WriterLbl";
            this.WriterLbl.Size = new System.Drawing.Size(48, 17);
            this.WriterLbl.TabIndex = 2;
            this.WriterLbl.Text = "Yazarı";
            // 
            // BookNameLbl
            // 
            this.BookNameLbl.AutoSize = true;
            this.BookNameLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookNameLbl.Location = new System.Drawing.Point(50, 73);
            this.BookNameLbl.Name = "BookNameLbl";
            this.BookNameLbl.Size = new System.Drawing.Size(64, 17);
            this.BookNameLbl.TabIndex = 1;
            this.BookNameLbl.Text = "Kitap Adı";
            // 
            // BookNumberLbl
            // 
            this.BookNumberLbl.AutoSize = true;
            this.BookNumberLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookNumberLbl.Location = new System.Drawing.Point(6, 40);
            this.BookNumberLbl.Name = "BookNumberLbl";
            this.BookNumberLbl.Size = new System.Drawing.Size(108, 17);
            this.BookNumberLbl.TabIndex = 0;
            this.BookNumberLbl.Text = "Kitap Numarası";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.AddBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddBtn.Location = new System.Drawing.Point(97, 610);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(116, 37);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Ekle";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TeslimBtn
            // 
            this.TeslimBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.TeslimBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeslimBtn.Location = new System.Drawing.Point(712, 521);
            this.TeslimBtn.Name = "TeslimBtn";
            this.TeslimBtn.Size = new System.Drawing.Size(116, 37);
            this.TeslimBtn.TabIndex = 5;
            this.TeslimBtn.Text = "Teslim Et";
            this.TeslimBtn.UseVisualStyleBackColor = false;
            this.TeslimBtn.Click += new System.EventHandler(this.TeslimBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.CancelBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CancelBtn.Location = new System.Drawing.Point(868, 518);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(116, 37);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "İptal";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBtn.Location = new System.Drawing.Point(712, 564);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(116, 35);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Sil";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EscrowBookFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1129, 668);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.TeslimBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "EscrowBookFrm";
            this.Text = "Emanet Kitap Verme Sayfası";
            this.Load += new System.EventHandler(this.EscrowBookFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TelTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox FindTCTxt;
        private System.Windows.Forms.Label TelLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label FindTCLbl;
        private System.Windows.Forms.DateTimePicker IadedateTimePicker;
        private System.Windows.Forms.DateTimePicker TeslimdateTimePicker;
        private System.Windows.Forms.TextBox PageNumberTxt;
        private System.Windows.Forms.TextBox PublisherTxt;
        private System.Windows.Forms.TextBox WriterTxt;
        private System.Windows.Forms.TextBox BookNameTxt;
        private System.Windows.Forms.TextBox BookNumberTxt;
        private System.Windows.Forms.Label IadeLbl;
        private System.Windows.Forms.Label TeslimLbl;
        private System.Windows.Forms.Label PageNumberLbl;
        private System.Windows.Forms.Label PublisherLbl;
        private System.Windows.Forms.Label WriterLbl;
        private System.Windows.Forms.Label BookNameLbl;
        private System.Windows.Forms.Label BookNumberLbl;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button TeslimBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}