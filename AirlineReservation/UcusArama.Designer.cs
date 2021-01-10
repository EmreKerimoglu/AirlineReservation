namespace AirlineReservation
{

    partial class UcusArama
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
            this.neredenCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nereyeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tarihSecim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.araButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eriskinNum = new System.Windows.Forms.NumericUpDown();
            this.cocukNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eriskinNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cocukNum)).BeginInit();
            this.SuspendLayout();
            // 
            // neredenCombo
            // 
            this.neredenCombo.FormattingEnabled = true;
            this.neredenCombo.ItemHeight = 13;
            this.neredenCombo.Items.AddRange(new object[] {
            ""});
            this.neredenCombo.Location = new System.Drawing.Point(12, 48);
            this.neredenCombo.Name = "neredenCombo";
            this.neredenCombo.Size = new System.Drawing.Size(169, 21);
            this.neredenCombo.TabIndex = 0;
            this.neredenCombo.SelectedIndexChanged += new System.EventHandler(this.neredenCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nereden";
            // 
            // nereyeCombo
            // 
            this.nereyeCombo.FormattingEnabled = true;
            this.nereyeCombo.Items.AddRange(new object[] {
            ""});
            this.nereyeCombo.Location = new System.Drawing.Point(199, 48);
            this.nereyeCombo.Name = "nereyeCombo";
            this.nereyeCombo.Size = new System.Drawing.Size(169, 21);
            this.nereyeCombo.TabIndex = 0;
            this.nereyeCombo.SelectedIndexChanged += new System.EventHandler(this.nereyeCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nereye";
            // 
            // tarihSecim
            // 
            this.tarihSecim.Location = new System.Drawing.Point(383, 49);
            this.tarihSecim.Name = "tarihSecim";
            this.tarihSecim.Size = new System.Drawing.Size(174, 20);
            this.tarihSecim.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tarih";
            // 
            // araButton
            // 
            this.araButton.Location = new System.Drawing.Point(782, 46);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(75, 23);
            this.araButton.TabIndex = 3;
            this.araButton.Text = "Ara";
            this.araButton.UseVisualStyleBackColor = true;
            this.araButton.Click += new System.EventHandler(this.Ara_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(845, 272);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // eriskinNum
            // 
            this.eriskinNum.Location = new System.Drawing.Point(583, 49);
            this.eriskinNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.eriskinNum.Name = "eriskinNum";
            this.eriskinNum.Size = new System.Drawing.Size(51, 20);
            this.eriskinNum.TabIndex = 5;
            // 
            // cocukNum
            // 
            this.cocukNum.Location = new System.Drawing.Point(663, 49);
            this.cocukNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cocukNum.Name = "cocukNum";
            this.cocukNum.Size = new System.Drawing.Size(51, 20);
            this.cocukNum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Erişkin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Çocuk";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(782, 393);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.Text = "Uçuş Seç";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SecButton_Click);
            // 
            // geriButton
            // 
            this.geriButton.Location = new System.Drawing.Point(12, 393);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(75, 23);
            this.geriButton.TabIndex = 3;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // UcusArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 428);
            this.Controls.Add(this.cocukNum);
            this.Controls.Add(this.eriskinNum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.tarihSecim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nereyeCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.neredenCombo);
            this.Name = "UcusArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ucus Arama";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eriskinNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cocukNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox neredenCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nereyeCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tarihSecim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown eriskinNum;
        private System.Windows.Forms.NumericUpDown cocukNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button geriButton;
    }
}

