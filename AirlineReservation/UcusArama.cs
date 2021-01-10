namespace AirlineReservation
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    using System.Data.SQLite;
    using System.Collections.Generic;

    public partial class UcusArama : Form
    {
        static int neredenIndex = -1;
        static int nereyeIndex = -1;
        static bool isLoaded = false;
        static Ucus seciliUcus;
        private int eriskin;
        private int cocuk;

        public UcusArama()
        {
            InitializeComponent();
            isLoaded = false;
            string sql = "Select Sehir from Sehirler";
            var dt = Baglanti.Select(sql, null);

            neredenCombo.DisplayMember = "Sehir";
            neredenCombo.ValueMember = "Sehir";
            neredenCombo.DataSource = dt.DefaultView;


            DataTable dt2 = dt.Copy();
            nereyeCombo.DisplayMember = "Sehir";
            nereyeCombo.ValueMember = "Sehir";
            nereyeCombo.DataSource = dt2.DefaultView;

            isLoaded = true;
            nereyeCombo.SelectedIndex = 1;
        }

        private void UcusAra(string nereden, string nereye, DateTime tarih, int koltukSayisi)
        {
            string sql = "SELECT * FROM(SELECT distinct u.*, count(k.KoltukId) KoltukSayi FROM Ucuslar u, Koltuklar k WHERE u.UcusNo = k.UcusNo AND u.Nereden=@Nereden AND u.Nereye=@Nereye AND u.Kalkis >= @Min AND u.Kalkis<@Max AND k.DoluMu=0 GROUP BY k.UcusNo) WHERE KoltukSayi>=@Sayi";
            SQLiteParameter neredenParameter = new SQLiteParameter("Nereden", nereden);
            SQLiteParameter nereyeParameter = new SQLiteParameter("Nereye", nereye);
            SQLiteParameter mintarihParameter = new SQLiteParameter("Min", tarih);
            SQLiteParameter maxtarihParameter = new SQLiteParameter("Max", tarih.AddDays(1));
            SQLiteParameter sayiParameter = new SQLiteParameter("Sayi", koltukSayisi);
            var dt = Baglanti.Select(sql, new SQLiteParameter[] { neredenParameter, nereyeParameter, mintarihParameter, maxtarihParameter, sayiParameter });
            
            dataGridView1.DataSource = null;
            
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Aradığınız kriterlere uygun uçuş bulunamadı.");
                return;
            }
            
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            var nereden = neredenCombo.SelectedValue.ToString();
            if (string.IsNullOrEmpty(nereden))
            {
                MessageBox.Show("Nereden uçmak istediğinizi seçiniz.");
                return;
            }
            var nereye = nereyeCombo.SelectedValue.ToString();
            if (string.IsNullOrEmpty(nereye))
            {
                MessageBox.Show("Nereye uçmak istediğinizi seçiniz.");
                return;
            }
            if (nereden == nereye)
            {
                MessageBox.Show("Aynı noktalar arası uçulamaz.");
                return;
            }
            var tarih = tarihSecim.Value.Date;
            if (tarih < DateTime.Now.Date)
            {
                MessageBox.Show("Geçmiş bir tarih. Lütfen ileri bir tarih seçiniz.");
                return;
            }

            if (eriskinNum.Value + cocukNum.Value <= 0)
            {
                MessageBox.Show("Lütfen en az 1 yolcu seçiniz.");
                return;
            }

            eriskin = (int)eriskinNum.Value;
            cocuk = (int)cocukNum.Value;

            UcusAra(nereden, nereye, tarih, (int)(eriskinNum.Value + cocukNum.Value));
        }

        private void neredenCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded && neredenCombo.SelectedIndex == nereyeCombo.SelectedIndex)
            {
                MessageBox.Show("Aynı noktalar arası uçulamaz.");
                neredenCombo.SelectedIndex = neredenIndex;
            }
            else
            {
                neredenIndex = neredenCombo.SelectedIndex;
            }
        }

        private void nereyeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded && nereyeCombo.SelectedIndex == neredenCombo.SelectedIndex)
            {
                MessageBox.Show("Aynı noktalar arası uçulamaz.");
                nereyeCombo.SelectedIndex = nereyeIndex;
            }
            else
            {
                nereyeIndex = nereyeCombo.SelectedIndex;
            }
        }

        private void SecButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Lütfen uçuş seçiniz.");
                return;
            }

            KoltukSecme koltukSecme = new KoltukSecme(seciliUcus, eriskin, cocuk);
            this.Hide();
            var result = koltukSecme.ShowDialog();
            if (result == DialogResult.Cancel)
                this.Close();
            else
                this.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            seciliUcus = new Ucus();
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            seciliUcus.Havayolu = dataGridView1.SelectedRows[0].Cells["Havayolu"].Value.ToString();
            seciliUcus.UcusNo = dataGridView1.SelectedRows[0].Cells["UcusNo"].Value.ToString();
            seciliUcus.UcusId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UcusId"].Value.ToString());
            seciliUcus.Nereden = dataGridView1.SelectedRows[0].Cells["Nereden"].Value.ToString();
            seciliUcus.Nereye = dataGridView1.SelectedRows[0].Cells["Nereye"].Value.ToString();
            seciliUcus.Kalkis = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["Kalkis"].Value);
            seciliUcus.Varis = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["Varis"].Value.ToString());
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
