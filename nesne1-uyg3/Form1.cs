
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
    }
}

