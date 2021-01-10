namespace AirlineReservation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SQLite;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Kullanicilar WHERE KullaniciAdi = @Adi";
            SQLiteParameter adi = new SQLiteParameter("Adi",kullaniciAdiText.Text);
            var dt = Baglanti.Select(sql, new SQLiteParameter[] { adi });
            
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("Böyle bir kullanıcı yok");
                return;
            }

            if (sifreText.Text == dt.Rows[0]["Sifre"].ToString())
            {
                Yonetim yonetim = new Yonetim();
                this.Hide();
                var result = yonetim.ShowDialog();
                if(result == DialogResult.Cancel)
                    this.Close();
                else
                    this.Show();
            }
            else
            {
                this.DialogResult = DialogResult.No;
                MessageBox.Show("Şifreniz hatalı");
            }
        }
    }
}
