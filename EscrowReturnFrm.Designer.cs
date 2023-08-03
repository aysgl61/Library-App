namespace Library_App
{
    partial class EscrowReturnFrm
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
            this.exitbtn = new System.Windows.Forms.Button();
            this.teslimalbtn = new System.Windows.Forms.Button();
            this.findtctxt = new System.Windows.Forms.TextBox();
            this.findbooktxt = new System.Windows.Forms.TextBox();
            this.findtclbl = new System.Windows.Forms.Label();
            this.findbooklbl = new System.Windows.Forms.Label();
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
            this.HeaderLbl.Location = new System.Drawing.Point(342, 28);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(417, 39);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Emanet Kitap İade İşlemleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 331);
            this.dataGridView1.TabIndex = 1;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.exitbtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitbtn.Location = new System.Drawing.Point(923, 454);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(116, 37);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Çıkış";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // teslimalbtn
            // 
            this.teslimalbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.teslimalbtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimalbtn.Location = new System.Drawing.Point(787, 454);
            this.teslimalbtn.Name = "teslimalbtn";
            this.teslimalbtn.Size = new System.Drawing.Size(116, 37);
            this.teslimalbtn.TabIndex = 3;
            this.teslimalbtn.Text = "Teslim Al";
            this.teslimalbtn.UseVisualStyleBackColor = false;
            // 
            // findtctxt
            // 
            this.findtctxt.Location = new System.Drawing.Point(883, 198);
            this.findtctxt.Name = "findtctxt";
            this.findtctxt.Size = new System.Drawing.Size(172, 22);
            this.findtctxt.TabIndex = 4;
            this.findtctxt.TextChanged += new System.EventHandler(this.findtctxt_TextChanged);
            // 
            // findbooktxt
            // 
            this.findbooktxt.Location = new System.Drawing.Point(883, 258);
            this.findbooktxt.Name = "findbooktxt";
            this.findbooktxt.Size = new System.Drawing.Size(172, 22);
            this.findbooktxt.TabIndex = 5;
            this.findbooktxt.TextChanged += new System.EventHandler(this.findbooktxt_TextChanged);
            // 
            // findtclbl
            // 
            this.findtclbl.AutoSize = true;
            this.findtclbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findtclbl.Location = new System.Drawing.Point(796, 203);
            this.findtclbl.Name = "findtclbl";
            this.findtclbl.Size = new System.Drawing.Size(71, 17);
            this.findtclbl.TabIndex = 6;
            this.findtclbl.Text = "TC ile ara";
            // 
            // findbooklbl
            // 
            this.findbooklbl.AutoSize = true;
            this.findbooklbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findbooklbl.Location = new System.Drawing.Point(763, 263);
            this.findbooklbl.Name = "findbooklbl";
            this.findbooklbl.Size = new System.Drawing.Size(104, 17);
            this.findbooklbl.TabIndex = 7;
            this.findbooklbl.Text = "Kitap no ile ara";
            // 
            // EscrowReturnFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.findbooklbl);
            this.Controls.Add(this.findtclbl);
            this.Controls.Add(this.findbooktxt);
            this.Controls.Add(this.findtctxt);
            this.Controls.Add(this.teslimalbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "EscrowReturnFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap İade İşlemleri";
            this.Load += new System.EventHandler(this.EscrowReturnFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button teslimalbtn;
        private System.Windows.Forms.TextBox findtctxt;
        private System.Windows.Forms.TextBox findbooktxt;
        private System.Windows.Forms.Label findtclbl;
        private System.Windows.Forms.Label findbooklbl;
    }
}