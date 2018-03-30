namespace EmlakArayüz
{
    partial class SorgulamaEkranı
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
            this.ilce_combobox = new System.Windows.Forms.ComboBox();
            this.il_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.satilik_secim = new System.Windows.Forms.RadioButton();
            this.comboBox_tur = new System.Windows.Forms.ComboBox();
            this.kiralik_secim = new System.Windows.Forms.RadioButton();
            this.ButonSorgula = new System.Windows.Forms.Button();
            this.textBoxAlanMin = new System.Windows.Forms.TextBox();
            this.kat_numeric = new System.Windows.Forms.NumericUpDown();
            this.oda_sayisi_numeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fiyatorkiraMin = new System.Windows.Forms.TextBox();
            this.fiyatorkiraMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAlanMax = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.kat_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda_sayisi_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ilce_combobox
            // 
            this.ilce_combobox.FormattingEnabled = true;
            this.ilce_combobox.Location = new System.Drawing.Point(361, 36);
            this.ilce_combobox.Name = "ilce_combobox";
            this.ilce_combobox.Size = new System.Drawing.Size(121, 21);
            this.ilce_combobox.TabIndex = 5;
            // 
            // il_combobox
            // 
            this.il_combobox.FormattingEnabled = true;
            this.il_combobox.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir"});
            this.il_combobox.Location = new System.Drawing.Point(122, 38);
            this.il_combobox.Name = "il_combobox";
            this.il_combobox.Size = new System.Drawing.Size(121, 21);
            this.il_combobox.TabIndex = 4;
            this.il_combobox.SelectedIndexChanged += new System.EventHandler(this.il_combobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(304, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "İl:";
            // 
            // satilik_secim
            // 
            this.satilik_secim.AutoSize = true;
            this.satilik_secim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satilik_secim.Location = new System.Drawing.Point(386, 107);
            this.satilik_secim.Name = "satilik_secim";
            this.satilik_secim.Size = new System.Drawing.Size(73, 24);
            this.satilik_secim.TabIndex = 18;
            this.satilik_secim.Text = "Satılık ";
            this.satilik_secim.UseVisualStyleBackColor = true;
            // 
            // comboBox_tur
            // 
            this.comboBox_tur.FormattingEnabled = true;
            this.comboBox_tur.Items.AddRange(new object[] {
            "Daire",
            "Bahçeli",
            "Müstakil",
            "Dubleks"});
            this.comboBox_tur.Location = new System.Drawing.Point(189, 358);
            this.comboBox_tur.Name = "comboBox_tur";
            this.comboBox_tur.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tur.TabIndex = 12;
            // 
            // kiralik_secim
            // 
            this.kiralik_secim.AutoSize = true;
            this.kiralik_secim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiralik_secim.Location = new System.Drawing.Point(99, 107);
            this.kiralik_secim.Name = "kiralik_secim";
            this.kiralik_secim.Size = new System.Drawing.Size(68, 24);
            this.kiralik_secim.TabIndex = 19;
            this.kiralik_secim.Text = "Kiralık";
            this.kiralik_secim.UseVisualStyleBackColor = true;
            this.kiralik_secim.CheckedChanged += new System.EventHandler(this.kiralik_secim_CheckedChanged);
            // 
            // ButonSorgula
            // 
            this.ButonSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButonSorgula.Location = new System.Drawing.Point(406, 421);
            this.ButonSorgula.Name = "ButonSorgula";
            this.ButonSorgula.Size = new System.Drawing.Size(97, 42);
            this.ButonSorgula.TabIndex = 17;
            this.ButonSorgula.Text = "Sorgula";
            this.ButonSorgula.UseVisualStyleBackColor = true;
            this.ButonSorgula.Click += new System.EventHandler(this.ButonSorgula_Click);
            // 
            // textBoxAlanMin
            // 
            this.textBoxAlanMin.Location = new System.Drawing.Point(189, 248);
            this.textBoxAlanMin.Name = "textBoxAlanMin";
            this.textBoxAlanMin.Size = new System.Drawing.Size(54, 20);
            this.textBoxAlanMin.TabIndex = 16;
            this.textBoxAlanMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlanMin_KeyPress);
            // 
            // kat_numeric
            // 
            this.kat_numeric.Location = new System.Drawing.Point(189, 201);
            this.kat_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kat_numeric.Name = "kat_numeric";
            this.kat_numeric.Size = new System.Drawing.Size(61, 20);
            this.kat_numeric.TabIndex = 14;
            this.kat_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // oda_sayisi_numeric
            // 
            this.oda_sayisi_numeric.Location = new System.Drawing.Point(189, 165);
            this.oda_sayisi_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.oda_sayisi_numeric.Name = "oda_sayisi_numeric";
            this.oda_sayisi_numeric.Size = new System.Drawing.Size(61, 20);
            this.oda_sayisi_numeric.TabIndex = 13;
            this.oda_sayisi_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(95, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(95, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tür:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(95, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(95, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(95, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Oda Sayısı:";
            // 
            // fiyatorkiraMin
            // 
            this.fiyatorkiraMin.Location = new System.Drawing.Point(189, 304);
            this.fiyatorkiraMin.Name = "fiyatorkiraMin";
            this.fiyatorkiraMin.Size = new System.Drawing.Size(54, 20);
            this.fiyatorkiraMin.TabIndex = 15;
            this.fiyatorkiraMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlanMin_KeyPress);
            // 
            // fiyatorkiraMax
            // 
            this.fiyatorkiraMax.Location = new System.Drawing.Point(297, 304);
            this.fiyatorkiraMax.Name = "fiyatorkiraMax";
            this.fiyatorkiraMax.Size = new System.Drawing.Size(54, 20);
            this.fiyatorkiraMax.TabIndex = 15;
            this.fiyatorkiraMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlanMin_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(149, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(256, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "max:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(145, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "min:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(256, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "max:";
            // 
            // textBoxAlanMax
            // 
            this.textBoxAlanMax.Location = new System.Drawing.Point(304, 248);
            this.textBoxAlanMax.Name = "textBoxAlanMax";
            this.textBoxAlanMax.Size = new System.Drawing.Size(47, 20);
            this.textBoxAlanMax.TabIndex = 16;
            this.textBoxAlanMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlanMin_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(122, 421);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(222, 24);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Arşivlenmiş Olanları da Tara";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SorgulamaEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 482);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.satilik_secim);
            this.Controls.Add(this.comboBox_tur);
            this.Controls.Add(this.kiralik_secim);
            this.Controls.Add(this.ButonSorgula);
            this.Controls.Add(this.fiyatorkiraMax);
            this.Controls.Add(this.fiyatorkiraMin);
            this.Controls.Add(this.textBoxAlanMax);
            this.Controls.Add(this.textBoxAlanMin);
            this.Controls.Add(this.kat_numeric);
            this.Controls.Add(this.oda_sayisi_numeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ilce_combobox);
            this.Controls.Add(this.il_combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SorgulamaEkranı";
            this.Text = "SorgulamaEkranı";
            this.Load += new System.EventHandler(this.SorgulamaEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kat_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda_sayisi_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ilce_combobox;
        private System.Windows.Forms.ComboBox il_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton satilik_secim;
        private System.Windows.Forms.ComboBox comboBox_tur;
        private System.Windows.Forms.RadioButton kiralik_secim;
        private System.Windows.Forms.Button ButonSorgula;
        private System.Windows.Forms.TextBox textBoxAlanMin;
        private System.Windows.Forms.NumericUpDown kat_numeric;
        private System.Windows.Forms.NumericUpDown oda_sayisi_numeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fiyatorkiraMin;
        private System.Windows.Forms.TextBox fiyatorkiraMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAlanMax;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}