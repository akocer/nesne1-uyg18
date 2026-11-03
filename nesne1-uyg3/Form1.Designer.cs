namespace nesne1_uyg3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnKapat = new Button();
            btnKaydet = new Button();
            btnHesapla = new Button();
            btnAc = new Button();
            dgKayitlar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgKayitlar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(btnKapat);
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(btnHesapla);
            panel1.Controls.Add(btnAc);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 115);
            panel1.TabIndex = 0;
            // 
            // btnKapat
            // 
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.Location = new Point(633, 26);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(201, 65);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Location = new Point(426, 26);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(201, 65);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.Location = new Point(219, 26);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(201, 65);
            btnHesapla.TabIndex = 0;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnAc
            // 
            btnAc.FlatStyle = FlatStyle.Flat;
            btnAc.Location = new Point(12, 26);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(201, 65);
            btnAc.TabIndex = 0;
            btnAc.Text = "Dosya Aç";
            btnAc.UseVisualStyleBackColor = true;
            btnAc.Click += btnAc_Click;
            // 
            // dgKayitlar
            // 
            dgKayitlar.AllowUserToAddRows = false;
            dgKayitlar.AllowUserToDeleteRows = false;
            dgKayitlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKayitlar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgKayitlar.Dock = DockStyle.Fill;
            dgKayitlar.Location = new Point(0, 115);
            dgKayitlar.Name = "dgKayitlar";
            dgKayitlar.RowHeadersWidth = 62;
            dgKayitlar.RowTemplate.Height = 33;
            dgKayitlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKayitlar.Size = new Size(1164, 481);
            dgKayitlar.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "SN";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Öğrenci No";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Adı Soyadı";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "Vize";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Final";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ort";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Sonuç";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 150;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 596);
            Controls.Add(dgKayitlar);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgKayitlar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgKayitlar;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button btnKapat;
        private Button btnKaydet;
        private Button btnHesapla;
        private Button btnAc;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }

}
