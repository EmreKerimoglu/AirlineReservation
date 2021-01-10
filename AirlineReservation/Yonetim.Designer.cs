namespace AirlineReservation
{

    partial class Yonetim
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
            this.ucusEkleButton = new System.Windows.Forms.Button();
            this.sehirEkleButton = new System.Windows.Forms.Button();
            this.KoltukEkleButton = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucusEkleButton
            // 
            this.ucusEkleButton.Location = new System.Drawing.Point(212, 26);
            this.ucusEkleButton.Name = "ucusEkleButton";
            this.ucusEkleButton.Size = new System.Drawing.Size(166, 80);
            this.ucusEkleButton.TabIndex = 1;
            this.ucusEkleButton.Text = "Uçuş Ekle";
            this.ucusEkleButton.UseVisualStyleBackColor = true;
            this.ucusEkleButton.Click += new System.EventHandler(this.ucusEkleButton_Click);
            // 
            // sehirEkleButton
            // 
            this.sehirEkleButton.Location = new System.Drawing.Point(23, 26);
            this.sehirEkleButton.Name = "sehirEkleButton";
            this.sehirEkleButton.Size = new System.Drawing.Size(166, 80);
            this.sehirEkleButton.TabIndex = 1;
            this.sehirEkleButton.Text = "Şehir Ekle";
            this.sehirEkleButton.UseVisualStyleBackColor = true;
            this.sehirEkleButton.Click += new System.EventHandler(this.sehirEkleButton_Click);
            // 
            // KoltukEkleButton
            // 
            this.KoltukEkleButton.Location = new System.Drawing.Point(396, 26);
            this.KoltukEkleButton.Name = "KoltukEkleButton";
            this.KoltukEkleButton.Size = new System.Drawing.Size(166, 80);
            this.KoltukEkleButton.TabIndex = 1;
            this.KoltukEkleButton.Text = "Koltuk Ekle";
            this.KoltukEkleButton.UseVisualStyleBackColor = true;
            this.KoltukEkleButton.Click += new System.EventHandler(this.KoltukEkleButton_Click);
            // 
            // geriButton
            // 
            this.geriButton.Location = new System.Drawing.Point(23, 121);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(75, 23);
            this.geriButton.TabIndex = 4;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // Yonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 146);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.sehirEkleButton);
            this.Controls.Add(this.KoltukEkleButton);
            this.Controls.Add(this.ucusEkleButton);
            this.Name = "Yonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yonetim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ucusEkleButton;
        private System.Windows.Forms.Button sehirEkleButton;
        private System.Windows.Forms.Button KoltukEkleButton;
        private System.Windows.Forms.Button geriButton;
    }
}