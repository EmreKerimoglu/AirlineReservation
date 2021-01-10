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

    public partial class KoltukEkle : Form
    {
        public KoltukEkle()
        {
            InitializeComponent();
            string sql = "Select UcusNo from Ucuslar";
            var dt = Baglanti.Select(sql, null);

            ucusCombo.DisplayMember = "UcusNo";
            ucusCombo.ValueMember = "UcusNo";
            ucusCombo.DataSource = dt.DefaultView;
        }

        private void fiyatTextKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void koltukEkleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(koltukNoText.Text))
            {
                MessageBox.Show("Koltuk no giriniz.");
                return;
            }

            if (string.IsNullOrEmpty(ucusCombo.SelectedValue.ToString()))
            {
                MessageBox.Show("Uçuş seçiniz.");
                return;
            }

            if (string.IsNullOrEmpty(sinifCombo.SelectedValue.ToString()))
            {
                MessageBox.Show("Sınıf seçiniz.");
                return;
            }


            if (string.IsNullOrEmpty(eriskinText.Text))
            {
                MessageBox.Show("Koltuk no giriniz.");
                return;
            }


            if (string.IsNullOrEmpty(cocukText.Text))
            {
                MessageBox.Show("Koltuk no giriniz.");
                return;
            }

            string sql = "Insert into Koltuklar(KoltukNo,UcusNo,Sinif,EriskinFiyat,CocukFiyat) Values(@KoltukNo,@UcusNo,@Sinif,@EriskinFiyat,@CocukFiyat)";
            SQLiteParameter koltukParameter = new SQLiteParameter("KoltukNo", koltukNoText.Text);
            SQLiteParameter ucusParameter = new SQLiteParameter("UcusNo", ucusCombo.SelectedValue.ToString());
            SQLiteParameter sinifParameter = new SQLiteParameter("Sinif", sinifCombo.SelectedValue.ToString());
            SQLiteParameter eriskinParameter = new SQLiteParameter("EriskinFiyat", eriskinText.Text);
            SQLiteParameter cocukParameter = new SQLiteParameter("CocukFiyat", cocukText.Text);
            var sonuc = Baglanti.InsertOrUpdate(sql, new SQLiteParameter[] { koltukParameter, ucusParameter, sinifParameter, eriskinParameter, cocukParameter });
            if (sonuc > 0)
                MessageBox.Show("Koltuk Eklendi");
            else
                MessageBox.Show("Koltuk Eklenemedi");

        }
    }
}
