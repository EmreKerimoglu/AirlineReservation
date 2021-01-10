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

    public partial class SehirEkle : Form
    {
        public SehirEkle()
        {
            InitializeComponent();
        }

        private void sehirEkleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sehirText.Text))
            {
                MessageBox.Show("Şehir giriniz.");
                return;
            }

            string sql = "Insert into Sehirler ('Sehir') Values (@Sehir)";
            SQLiteParameter sehirParam = new SQLiteParameter("@Sehir",sehirText.Text);
            int sonuc = Baglanti.InsertOrUpdate(sql,new SQLiteParameter[] { sehirParam });
            if (sonuc > 0)
                MessageBox.Show("Şehir Eklendi");
            else
                MessageBox.Show("Şehir Eklenemedi");
        }
    }
}
