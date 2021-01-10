namespace AirlineReservation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class IslemSecim : Form
    {
        static DialogResult result;

        public IslemSecim()
        {
            InitializeComponent();
            Baglanti baglanti = new Baglanti();
        }

        private void Rezervation_Click(object sender, EventArgs e)
        {
            UcusArama ucusArama = new UcusArama();
            this.Hide();
            result = ucusArama.ShowDialog();
            if (result == DialogResult.Cancel)
                this.Close();
            else
                this.Show();
        }

        private void Yonetim_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            this.Hide();
            result = kullanici.ShowDialog();
            if (result == DialogResult.Cancel)
                this.Close();
            else
                this.Show();
        }
    }
}
