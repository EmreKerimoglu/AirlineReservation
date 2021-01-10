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

    public partial class UcusEkle : Form
    {
        static int neredenIndex = -1;
        static int nereyeIndex = -1;
        static bool isLoaded = false;
        public UcusEkle()
        {
            InitializeComponent();
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

        private void ekleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ucusNoText.Text))
            {
                MessageBox.Show("Uçuş no giriniz.");
                return;
            }
            
            if (string.IsNullOrEmpty(havayoluText.Text))
            {
                MessageBox.Show("Havayolu giriniz.");
                return;
            }

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

            if (varisTarih.Value < kalkisTarih.Value)
            {
                MessageBox.Show("Kalkış varıştan daha sonra olamaz.");
                return;
            }

            string sql = "Select * from Ucuslar where UcusNo = @UcusNo";

            SQLiteParameter ucusNoParameter = new SQLiteParameter("UcusNo", ucusNoText.Text);
            var dt = Baglanti.Select(sql, new SQLiteParameter[] { ucusNoParameter });
            if (dt.Rows.Count > 0)
            {
                sql = "Insert into Ucuslar(UcusNo,Havayolu,Nereden,Nereye,Kalkis,Varis) Values(@UcusNo,@Havayolu,@Nereden,@Nereye,@Kalkis,@Varis)";
            }
            else 
            {
                sql = "Update Ucuslar  Set Havayolu = @Havayolu, Nereden = @Nereden, Nereye=@Nereye, Kalkis =@Kalkis, Varis=@Varis Where UcusNo = @UcusNo";
            }

            SQLiteParameter havayoluParameter = new SQLiteParameter("Havayolu", havayoluText.Text);
            SQLiteParameter neredenParameter = new SQLiteParameter("Nereden", neredenCombo.SelectedValue.ToString());
            SQLiteParameter nereyeParameter = new SQLiteParameter("Nereye", nereyeCombo.SelectedValue.ToString());
            SQLiteParameter kalkisParameter = new SQLiteParameter("Kalkis", kalkisTarih.Value);
            SQLiteParameter varisParameter = new SQLiteParameter("Varis", varisTarih.Value);
            var sonuc =  Baglanti.InsertOrUpdate(sql, new SQLiteParameter[] { ucusNoParameter,havayoluParameter,neredenParameter,nereyeParameter,kalkisParameter,varisParameter });
            if (sonuc > 0)
                MessageBox.Show("Uçuş Eklendi");
            else
                MessageBox.Show("Uçuş Eklenemedi");
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
    }
}
