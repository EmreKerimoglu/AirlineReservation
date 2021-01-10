namespace AirlineReservation
{

    partial class UcusEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.ucusNoText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.havayoluText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.varisTarih = new System.Windows.Forms.DateTimePicker();
            this.kalkisTarih = new System.Windows.Forms.DateTimePicker();
            this.nereyeCombo = new System.Windows.Forms.ComboBox();
            this.neredenCombo = new System.Windows.Forms.ComboBox();
            this.ekleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uçuş No";
            // 
            // ucusNoText
            // 
            this.ucusNoText.Location = new System.Drawing.Point(89, 36);
            this.ucusNoText.Name = "ucusNoText";
            this.ucusNoText.Size = new System.Drawing.Size(200, 20);
            this.ucusNoText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Havayolu";
            // 
            // havayoluText
            // 
            this.havayoluText.Location = new System.Drawing.Point(89, 62);
            this.havayoluText.Name = "havayoluText";
            this.havayoluText.Size = new System.Drawing.Size(200, 20);
            this.havayoluText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nereden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nereye";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kalkış";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vaış";
            // 
            // varisTarih
            // 
            this.varisTarih.CustomFormat = "dd.MM.yyyy HH:mm";
            this.varisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.varisTarih.Location = new System.Drawing.Point(89, 167);
            this.varisTarih.Name = "varisTarih";
            this.varisTarih.Size = new System.Drawing.Size(200, 20);
            this.varisTarih.TabIndex = 2;
            // 
            // kalkisTarih
            // 
            this.kalkisTarih.CustomFormat = "dd.MM.yyyy HH:mm";
            this.kalkisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kalkisTarih.Location = new System.Drawing.Point(89, 141);
            this.kalkisTarih.Name = "kalkisTarih";
            this.kalkisTarih.Size = new System.Drawing.Size(200, 20);
            this.kalkisTarih.TabIndex = 2;
            // 
            // nereyeCombo
            // 
            this.nereyeCombo.FormattingEnabled = true;
            this.nereyeCombo.Items.AddRange(new object[] {
            ""});
            this.nereyeCombo.Location = new System.Drawing.Point(89, 114);
            this.nereyeCombo.Name = "nereyeCombo";
            this.nereyeCombo.Size = new System.Drawing.Size(200, 21);
            this.nereyeCombo.TabIndex = 3;
            // 
            // neredenCombo
            // 
            this.neredenCombo.FormattingEnabled = true;
            this.neredenCombo.ItemHeight = 13;
            this.neredenCombo.Items.AddRange(new object[] {
            ""});
            this.neredenCombo.Location = new System.Drawing.Point(89, 88);
            this.neredenCombo.Name = "neredenCombo";
            this.neredenCombo.Size = new System.Drawing.Size(200, 21);
            this.neredenCombo.TabIndex = 4;
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(214, 206);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(75, 23);
            this.ekleButton.TabIndex = 5;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // UcusEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 241);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.nereyeCombo);
            this.Controls.Add(this.neredenCombo);
            this.Controls.Add(this.kalkisTarih);
            this.Controls.Add(this.varisTarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.havayoluText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucusNoText);
            this.Controls.Add(this.label1);
            this.Name = "UcusEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UcusEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ucusNoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox havayoluText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker varisTarih;
        private System.Windows.Forms.DateTimePicker kalkisTarih;
        private System.Windows.Forms.ComboBox nereyeCombo;
        private System.Windows.Forms.ComboBox neredenCombo;
        private System.Windows.Forms.Button ekleButton;
    }
}