namespace AirlineReservation
{

    partial class SehirEkle
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
            this.sehirText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sehirEkleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sehirText
            // 
            this.sehirText.Location = new System.Drawing.Point(49, 12);
            this.sehirText.Name = "sehirText";
            this.sehirText.Size = new System.Drawing.Size(200, 20);
            this.sehirText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şehir";
            // 
            // sehirEkleButton
            // 
            this.sehirEkleButton.Location = new System.Drawing.Point(264, 11);
            this.sehirEkleButton.Name = "sehirEkleButton";
            this.sehirEkleButton.Size = new System.Drawing.Size(75, 23);
            this.sehirEkleButton.TabIndex = 4;
            this.sehirEkleButton.Text = "Ekle";
            this.sehirEkleButton.UseVisualStyleBackColor = true;
            this.sehirEkleButton.Click += new System.EventHandler(this.sehirEkleButton_Click);
            // 
            // SehirEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 45);
            this.Controls.Add(this.sehirEkleButton);
            this.Controls.Add(this.sehirText);
            this.Controls.Add(this.label1);
            this.Name = "SehirEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SehirEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sehirText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sehirEkleButton;
    }
}