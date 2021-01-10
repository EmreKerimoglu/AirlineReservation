namespace AirlineReservation
{

    partial class KoltukEkle
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
            this.ucusCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.koltukNoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.koltukEkleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eriskinText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cocukText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sinifCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ucusCombo
            // 
            this.ucusCombo.FormattingEnabled = true;
            this.ucusCombo.ItemHeight = 13;
            this.ucusCombo.Items.AddRange(new object[] {
            ""});
            this.ucusCombo.Location = new System.Drawing.Point(81, 23);
            this.ucusCombo.Name = "ucusCombo";
            this.ucusCombo.Size = new System.Drawing.Size(200, 21);
            this.ucusCombo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uçuş";
            // 
            // koltukNoText
            // 
            this.koltukNoText.Location = new System.Drawing.Point(81, 50);
            this.koltukNoText.Name = "koltukNoText";
            this.koltukNoText.Size = new System.Drawing.Size(200, 20);
            this.koltukNoText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Koltuk No";
            // 
            // koltukEkleButton
            // 
            this.koltukEkleButton.Location = new System.Drawing.Point(206, 169);
            this.koltukEkleButton.Name = "koltukEkleButton";
            this.koltukEkleButton.Size = new System.Drawing.Size(75, 23);
            this.koltukEkleButton.TabIndex = 8;
            this.koltukEkleButton.Text = "Ekle";
            this.koltukEkleButton.UseVisualStyleBackColor = true;
            this.koltukEkleButton.Click += new System.EventHandler(this.koltukEkleButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Erişkin Fiyat";
            // 
            // eriskinText
            // 
            this.eriskinText.Location = new System.Drawing.Point(81, 105);
            this.eriskinText.Name = "eriskinText";
            this.eriskinText.Size = new System.Drawing.Size(200, 20);
            this.eriskinText.TabIndex = 7;
            this.eriskinText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiyatTextKeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Çocuk Fiyat";
            // 
            // cocukText
            // 
            this.cocukText.Location = new System.Drawing.Point(81, 132);
            this.cocukText.Name = "cocukText";
            this.cocukText.Size = new System.Drawing.Size(200, 20);
            this.cocukText.TabIndex = 7;
            this.cocukText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiyatTextKeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sınıf";
            // 
            // sinifCombo
            // 
            this.sinifCombo.FormattingEnabled = true;
            this.sinifCombo.ItemHeight = 13;
            this.sinifCombo.Items.AddRange(new object[] {
            "Ekonomi",
            "Business"});
            this.sinifCombo.Location = new System.Drawing.Point(81, 76);
            this.sinifCombo.Name = "sinifCombo";
            this.sinifCombo.Size = new System.Drawing.Size(200, 21);
            this.sinifCombo.TabIndex = 6;
            // 
            // KoltukEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 204);
            this.Controls.Add(this.koltukEkleButton);
            this.Controls.Add(this.cocukText);
            this.Controls.Add(this.eriskinText);
            this.Controls.Add(this.koltukNoText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sinifCombo);
            this.Controls.Add(this.ucusCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "KoltukEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KoltukEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ucusCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox koltukNoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button koltukEkleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eriskinText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cocukText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sinifCombo;
    }
}