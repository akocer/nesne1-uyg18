
using System.Windows.Forms;

namespace nesne1_uyg3

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        string satir;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Dosyalarý |*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            int sira = 1;
            while ((satir = sr.ReadLine()) != null)
            {
                string[] parcala = satir.Split(';');
                dgKayitlar.Rows.Add(sira, parcala[0], parcala[1], parcala[2], parcala[3]);
                sira++;
            }
            sr.Close();
            fs.Close();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgKayitlar.RowCount; i++)
            {
                double v = Convert.ToDouble(dgKayitlar.Rows[i].Cells[3].Value.ToString());
                double f = Convert.ToDouble(dgKayitlar.Rows[i].Cells[4].Value.ToString());
                double ort = (v * 0.4) + (f * 0.6);
                string sonuc = "";
                if (ort < 60)
                {
                    sonuc = "Kaldý";
                    dgKayitlar.Rows[i].Cells[6].Style.BackColor = Color.Red;
                }
                else
                {
                    sonuc = "Geçti";
                    dgKayitlar.Rows[i].Cells[6].Style.BackColor = Color.Green;

                }
                dgKayitlar.Rows[i].Cells[5].Value = ort.ToString("0.00");
                dgKayitlar.Rows[i].Cells[6].Value = sonuc.ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (dgKayitlar.RowCount == 0)
            {
                MessageBox.Show("Kayýt bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog1.FileName = "sonuc.csv";
            saveFileDialog1.Filter = "CSV Dosyalarý |*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
            sw = new StreamWriter(fs,System.Text.Encoding.UTF8);
            for (int i = 0; i < dgKayitlar.RowCount; i++)
            {
                satir = "";
                for (int j = 1; j < dgKayitlar.ColumnCount; j++)
                {
                    satir += dgKayitlar.Rows[i].Cells[j].Value.ToString() + ";";
                }
                sw.WriteLine(satir);
            }
            sw.Close();
            fs.Close();

            if (MessageBox.Show("Sonuçlar Dosyaya Yazýldý Açýlsýn mý?","Onay",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = saveFileDialog1.FileName;
            p.StartInfo.UseShellExecute = true;
            p.Start();
        }
    }
}

