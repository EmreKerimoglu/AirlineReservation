namespace AirlineReservation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SQLite;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class KoltukSecme : Form
    {
        int eriskinNumber=0;
        int cocukNumber=0;
        double toplamUcret = 0;
        DataTable koltuklar;
        Dictionary<int,Rezervasyon> rezervasyonListesi = new Dictionary<int,Rezervasyon>();
        public KoltukSecme(Ucus ucus, int eriskin, int cocuk)
        {
            InitializeComponent();
            eriskinNumber = eriskin;
            cocukNumber = cocuk;
            int i = 1;
            for (; i <= eriskin; i++)
            {
                yolcuCombo.Items.Add(new { Text = i + ".Erişkin", Value = i, Type = 1 });
            }
            
            for (; i <= eriskin+cocuk; i++)
            {
                yolcuCombo.Items.Add(new { Text = i + ".Çocuk", Value = i, Type = 2 });
            }

            yolcuCombo.DisplayMember = "Text";
            yolcuCombo.ValueMember = "Value";


            string sql = "Select * from Koltuklar Where UcusNo = @UcusNo";
            SQLiteParameter ucusParameter = new SQLiteParameter("UcusNo", ucus.UcusNo);
            koltuklar= Baglanti.Select(sql, new SQLiteParameter[] { ucusParameter });
            koltukCombo.DataSource = koltuklar.DefaultView;
            koltukCombo.DisplayMember = "KoltukNo";
            koltukCombo.ValueMember = "KoltukNo";
        }

        private void koltukSecButton_Click(object sender, EventArgs e)
        {
            var adSoyad = adSoaydText.Text;
            var koltuk = koltukCombo.SelectedItem?.ToString();
            var cinsiyet = cinsiyetKombo.SelectedItem?.ToString();
            dynamic yolcu = yolcuCombo.SelectedItem;
            int yolcuNumber = (int)yolcu.Value;
            if (string.IsNullOrWhiteSpace(adSoyad))
            {
                MessageBox.Show("Ad soayad giriniz");
                return;
            }
            if(string.IsNullOrWhiteSpace(koltuk))
            {
                MessageBox.Show("Koltuk seçiniz");
                return;
            }
            if(string.IsNullOrWhiteSpace(cinsiyet))
            {
                MessageBox.Show("Cinsiyet seçiniz");
                return;
            }

            if(rezervasyonListesi.Values.Any(x=>x.KoltukNo == koltuk))
            {
                MessageBox.Show("Bu koltuğu başka biri için seçtiniz.\nLütfen başka bir koltuk seçiniz.");
                return;
            }

            var koltukEntity = (DataRowView)koltukCombo.SelectedItem;
            double fiyat = yolcuNumber <= eriskinNumber ? Convert.ToDouble(koltukEntity.Row["EriskinFiyat"]) : Convert.ToDouble(koltukEntity.Row["CocukFiyat"]);

            var res = new Rezervasyon() { AdSoyad=adSoyad,KoltukNo=koltuk,Cinsiyet = cinsiyet };
            //listBox1.Items.Add(new { AdSoyad=adSoyad,Koltuk= koltuk,Cinsiyet = cinsiyet, Fiyat = fiyat});
            rezervasyonListesi.Add(yolcuNumber,res);
            toplamUcret += fiyat; 
        }

        private void yolcuCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = yolcuCombo.SelectedValue;
            if (item == null)
                return;
            if (rezervasyonListesi.ContainsKey((int)item))
            {
                MessageBox.Show("Bu yolcu için zaten seçim yaptınız!");
                yolcuCombo.SelectedIndex = -1;
            }
        }

        private void tamamlaButton_Click(object sender, EventArgs e)
        {
            if(rezervasyonListesi.Count != (eriskinNumber+cocukNumber))
            {
                MessageBox.Show("Lütfen tüm yolcular için seçim yapınız!");
                return;
            }

            int sonuc = 0;
            string result = "Rezervasyon Listesi:";
            foreach (var rezervasyon in rezervasyonListesi.Values)
            {
                string sql = "Insert into Rezervasyonlar(UcusNo,AdSoyad,KoltukNo,Cinsiyet) Values(@UcusNo,@KoltukNo,@AdSoyad,@Cinsiyet)";
                SQLiteParameter koltukParameter = new SQLiteParameter("KoltukNo", rezervasyon.KoltukNo);
                SQLiteParameter ucusParameter = new SQLiteParameter("UcusNo", rezervasyon.UcusNo);
                SQLiteParameter adsoyadParameter = new SQLiteParameter("AdSoyad", rezervasyon.AdSoyad);
                SQLiteParameter cinsiyetParameter = new SQLiteParameter("Cinsiyet", rezervasyon.Cinsiyet);
                
                sonuc = Baglanti.InsertOrUpdate(sql, new SQLiteParameter[] { koltukParameter, ucusParameter, adsoyadParameter, cinsiyetParameter });

                sql = "Update Koltuklar set DoluMu=1 Where UcusNo=@UcusNo And KoltukNo=@KoltukNo";
                sonuc = Baglanti.InsertOrUpdate(sql, new SQLiteParameter[] { koltukParameter, ucusParameter });
                if (sonuc <= 0)
                    break;
                result += ("\n{0}\t {1}\t\t {2}",rezervasyon.Cinsiyet, rezervasyon.AdSoyad,rezervasyon.KoltukNo);
            }
            if (sonuc > 0)
            {
                MessageBox.Show(result + "\nToplam ücret:" + toplamUcret.ToString() + " İyi uçuşlar dileriz.");
            }
            else
            {
                MessageBox.Show("Koltuk seçimi tamamlanamadı.");
            }

            this.Close();
        }

        private void sinifCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            koltuklar.DefaultView.RowFilter = String.Format("Sinif = '{0}'", sinifCombo.SelectedItem.ToString());
            koltukCombo.DataSource = koltuklar.DefaultView;
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
