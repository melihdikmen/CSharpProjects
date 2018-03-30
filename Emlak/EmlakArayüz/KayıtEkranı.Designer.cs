namespace EmlakArayüz
{
    partial class KayıtEkranı
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
            this.il_combobox = new System.Windows.Forms.ComboBox();
            this.ilce_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tarih_datetime = new System.Windows.Forms.DateTimePicker();
            this.satilik_secim = new System.Windows.Forms.RadioButton();
            this.comboBox_tur = new System.Windows.Forms.ComboBox();
            this.kiralik_secim = new System.Windows.Forms.RadioButton();
            this.ButonKayıt = new System.Windows.Forms.Button();
            this.fiyatordepozito = new System.Windows.Forms.TextBox();
            this.textBoxAlan = new System.Windows.Forms.TextBox();
            this.kat_numeric = new System.Windows.Forms.NumericUpDown();
            this.oda_sayisi_numeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kat_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda_sayisi_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl:";
            // 
            // il_combobox
            // 
            this.il_combobox.FormattingEnabled = true;
            this.il_combobox.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir"});
            this.il_combobox.Location = new System.Drawing.Point(63, 36);
            this.il_combobox.Name = "il_combobox";
            this.il_combobox.Size = new System.Drawing.Size(121, 21);
            this.il_combobox.TabIndex = 0;
            this.il_combobox.SelectedIndexChanged += new System.EventHandler(this.il_combobox_SelectedIndexChanged);
            // 
            // ilce_combobox
            // 
            this.ilce_combobox.FormattingEnabled = true;
            this.ilce_combobox.Location = new System.Drawing.Point(302, 34);
            this.ilce_combobox.Name = "ilce_combobox";
            this.ilce_combobox.Size = new System.Drawing.Size(121, 21);
            this.ilce_combobox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(245, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Semt:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tarih_datetime);
            this.groupBox1.Controls.Add(this.satilik_secim);
            this.groupBox1.Controls.Add(this.comboBox_tur);
            this.groupBox1.Controls.Add(this.kiralik_secim);
            this.groupBox1.Controls.Add(this.ButonKayıt);
            this.groupBox1.Controls.Add(this.fiyatordepozito);
            this.groupBox1.Controls.Add(this.textBoxAlan);
            this.groupBox1.Controls.Add(this.kat_numeric);
            this.groupBox1.Controls.Add(this.oda_sayisi_numeric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 325);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özellikler";
            // 
            // tarih_datetime
            // 
            this.tarih_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih_datetime.Location = new System.Drawing.Point(408, 95);
            this.tarih_datetime.Name = "tarih_datetime";
            this.tarih_datetime.Size = new System.Drawing.Size(106, 26);
            this.tarih_datetime.TabIndex = 5;
            // 
            // satilik_secim
            // 
            this.satilik_secim.AutoSize = true;
            this.satilik_secim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satilik_secim.Location = new System.Drawing.Point(305, 38);
            this.satilik_secim.Name = "satilik_secim";
            this.satilik_secim.Size = new System.Drawing.Size(73, 24);
            this.satilik_secim.TabIndex = 4;
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
            this.comboBox_tur.Location = new System.Drawing.Point(393, 173);
            this.comboBox_tur.Name = "comboBox_tur";
            this.comboBox_tur.Size = new System.Drawing.Size(121, 28);
            this.comboBox_tur.TabIndex = 0;
            // 
            // kiralik_secim
            // 
            this.kiralik_secim.AutoSize = true;
            this.kiralik_secim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiralik_secim.Location = new System.Drawing.Point(18, 38);
            this.kiralik_secim.Name = "kiralik_secim";
            this.kiralik_secim.Size = new System.Drawing.Size(68, 24);
            this.kiralik_secim.TabIndex = 4;
            this.kiralik_secim.Text = "Kiralık";
            this.kiralik_secim.UseVisualStyleBackColor = true;
            this.kiralik_secim.CheckedChanged += new System.EventHandler(this.kiralik_secim_CheckedChanged);
            // 
            // ButonKayıt
            // 
            this.ButonKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButonKayıt.Location = new System.Drawing.Point(417, 253);
            this.ButonKayıt.Name = "ButonKayıt";
            this.ButonKayıt.Size = new System.Drawing.Size(97, 42);
            this.ButonKayıt.TabIndex = 3;
            this.ButonKayıt.Text = "Kaydet";
            this.ButonKayıt.UseVisualStyleBackColor = true;
            this.ButonKayıt.Click += new System.EventHandler(this.ButonKayıt_Click);
            // 
            // fiyatordepozito
            // 
            this.fiyatordepozito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fiyatordepozito.Location = new System.Drawing.Point(108, 235);
            this.fiyatordepozito.Name = "fiyatordepozito";
            this.fiyatordepozito.Size = new System.Drawing.Size(100, 26);
            this.fiyatordepozito.TabIndex = 2;
            this.fiyatordepozito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlan_KeyPress);
            // 
            // textBoxAlan
            // 
            this.textBoxAlan.Location = new System.Drawing.Point(108, 176);
            this.textBoxAlan.Name = "textBoxAlan";
            this.textBoxAlan.Size = new System.Drawing.Size(100, 26);
            this.textBoxAlan.TabIndex = 2;
            this.textBoxAlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlan_KeyPress);
            // 
            // kat_numeric
            // 
            this.kat_numeric.Location = new System.Drawing.Point(108, 132);
            this.kat_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kat_numeric.Name = "kat_numeric";
            this.kat_numeric.Size = new System.Drawing.Size(61, 26);
            this.kat_numeric.TabIndex = 1;
            this.kat_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // oda_sayisi_numeric
            // 
            this.oda_sayisi_numeric.Location = new System.Drawing.Point(108, 96);
            this.oda_sayisi_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.oda_sayisi_numeric.Name = "oda_sayisi_numeric";
            this.oda_sayisi_numeric.Size = new System.Drawing.Size(61, 26);
            this.oda_sayisi_numeric.TabIndex = 1;
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
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(351, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tür:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "label";
            this.label8.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(301, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yapım Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Oda Sayısı:";
            // 
            // KayıtEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 447);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ilce_combobox);
            this.Controls.Add(this.il_combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KayıtEkranı";
            this.Text = "KayıtEkranı";
            this.Load += new System.EventHandler(this.KayıtEkranı_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kat_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda_sayisi_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox il_combobox;
        private System.Windows.Forms.ComboBox ilce_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown oda_sayisi_numeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown kat_numeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAlan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButonKayıt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tarih_datetime;
        private System.Windows.Forms.RadioButton satilik_secim;
        private System.Windows.Forms.RadioButton kiralik_secim;
        private System.Windows.Forms.ComboBox comboBox_tur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fiyatordepozito;
        private System.Windows.Forms.Label label8;
    }
}