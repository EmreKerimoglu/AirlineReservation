namespace AirlineReservation
{

    partial class KoltukSecme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sinifCombo = new System.Windows.Forms.ComboBox();
            this.koltukCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adSoaydText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cinsiyetKombo = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.koltukSecButton = new System.Windows.Forms.Button();
            this.tamamlaButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.yolcuCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toplamText = new System.Windows.Forms.TextBox();
            this.geriButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sinifCombo
            // 
            this.sinifCombo.FormattingEnabled = true;
            this.sinifCombo.Items.AddRange(new object[] {
            "Ekonomi",
            "Business"});
            this.sinifCombo.Location = new System.Drawing.Point(78, 35);
            this.sinifCombo.Name = "sinifCombo";
            this.sinifCombo.Size = new System.Drawing.Size(200, 21);
            this.sinifCombo.TabIndex = 7;
            this.sinifCombo.SelectedIndexChanged += new System.EventHandler(this.sinifCombo_SelectedIndexChanged);
            // 
            // koltukCombo
            // 
            this.koltukCombo.FormattingEnabled = true;
            this.koltukCombo.ItemHeight = 13;
            this.koltukCombo.Items.AddRange(new object[] {
            ""});
            this.koltukCombo.Location = new System.Drawing.Point(78, 62);
            this.koltukCombo.Name = "koltukCombo";
            this.koltukCombo.Size = new System.Drawing.Size(200, 21);
            this.koltukCombo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Koltuk";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sınıf";
            // 
            // adSoaydText
            // 
            this.adSoaydText.Location = new System.Drawing.Point(78, 89);
            this.adSoaydText.Name = "adSoaydText";
            this.adSoaydText.Size = new System.Drawing.Size(200, 20);
            this.adSoaydText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adı Soyadı";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cinsiyet";
            // 
            // cinsiyetKombo
            // 
            this.cinsiyetKombo.FormattingEnabled = true;
            this.cinsiyetKombo.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cinsiyetKombo.Location = new System.Drawing.Point(78, 115);
            this.cinsiyetKombo.Name = "cinsiyetKombo";
            this.cinsiyetKombo.Size = new System.Drawing.Size(200, 21);
            this.cinsiyetKombo.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(294, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 303);
            this.listBox1.TabIndex = 12;
            // 
            // koltukSecButton
            // 
            this.koltukSecButton.Location = new System.Drawing.Point(203, 142);
            this.koltukSecButton.Name = "koltukSecButton";
            this.koltukSecButton.Size = new System.Drawing.Size(75, 23);
            this.koltukSecButton.TabIndex = 13;
            this.koltukSecButton.Text = "Koltuk Seç";
            this.koltukSecButton.UseVisualStyleBackColor = true;
            this.koltukSecButton.Click += new System.EventHandler(this.koltukSecButton_Click);
            // 
            // tamamlaButton
            // 
            this.tamamlaButton.Location = new System.Drawing.Point(203, 281);
            this.tamamlaButton.Name = "tamamlaButton";
            this.tamamlaButton.Size = new System.Drawing.Size(75, 23);
            this.tamamlaButton.TabIndex = 13;
            this.tamamlaButton.Text = "Tamamla";
            this.tamamlaButton.UseVisualStyleBackColor = true;
            this.tamamlaButton.Click += new System.EventHandler(this.tamamlaButton_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yolcu";
            // 
            // yolcuCombo
            // 
            this.yolcuCombo.FormattingEnabled = true;
            this.yolcuCombo.Location = new System.Drawing.Point(78, 8);
            this.yolcuCombo.Name = "yolcuCombo";
            this.yolcuCombo.Size = new System.Drawing.Size(200, 21);
            this.yolcuCombo.TabIndex = 7;
            this.yolcuCombo.SelectedIndexChanged += new System.EventHandler(this.yolcuCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Toplam";
            // 
            // toplamText
            // 
            this.toplamText.Enabled = false;
            this.toplamText.Location = new System.Drawing.Point(78, 255);
            this.toplamText.Name = "toplamText";
            this.toplamText.Size = new System.Drawing.Size(200, 20);
            this.toplamText.TabIndex = 11;
            // 
            // geriButton
            // 
            this.geriButton.Location = new System.Drawing.Point(12, 281);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(75, 23);
            this.geriButton.TabIndex = 13;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // KoltukSecme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 323);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.tamamlaButton);
            this.Controls.Add(this.koltukSecButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toplamText);
            this.Controls.Add(this.adSoaydText);
            this.Controls.Add(this.cinsiyetKombo);
            this.Controls.Add(this.yolcuCombo);
            this.Controls.Add(this.sinifCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.koltukCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "KoltukSecme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KoltukSecme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sinifCombo;
        private System.Windows.Forms.ComboBox koltukCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adSoaydText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cinsiyetKombo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button koltukSecButton;
        private System.Windows.Forms.Button tamamlaButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox yolcuCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox toplamText;
        private System.Windows.Forms.Button geriButton;
    }
}