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

    public partial class Yonetim : Form
    {
        public Yonetim()
        {
            InitializeComponent();
        }

        private void ucusEkleButton_Click(object sender, EventArgs e)
        {
            UcusEkle ucusEkle = new UcusEkle();
            ucusEkle.ShowDialog();
        }

        private void sehirEkleButton_Click(object sender, EventArgs e)
        {
            SehirEkle sehirEkle = new SehirEkle();
            sehirEkle.ShowDialog();
        }

        private void KoltukEkleButton_Click(object sender, EventArgs e)
        {
            KoltukEkle koltukEkle = new KoltukEkle();
            koltukEkle.ShowDialog();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
