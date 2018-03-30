using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ClassLibrary1;

namespace EmlakArayüz
{
    public partial class SorgulamaEkranı : Form
    {
        public SorgulamaEkranı()
        {
            InitializeComponent();
        }

       


        
        
            private void il_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String dosya_adi;
            ilce_combobox.Items.Clear();





            dosya_adi = il_combobox.Text + ".txt";
            FileStream fs = new FileStream(dosya_adi, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("iso-8859-9"), false);

            String okunan = sr.ReadLine();

            while (okunan != null)
            {
                ilce_combobox.Items.Add(okunan);
                okunan = sr.ReadLine();
            }

            fs.Close();
            sr.Close();





            ilce_combobox.Text = ilce_combobox.Items[0].ToString();
            
        }

            private void kiralik_secim_CheckedChanged(object sender, EventArgs e)
            {
                if (kiralik_secim.Checked == true)
                {
                    label8.Text = "Kira:";
                }

                if (satilik_secim.Checked == true)
                {
                    label8.Text = "Fiyat:";
                }



            }

            private void SorgulamaEkranı_Load(object sender, EventArgs e)
            {
                kiralik_secim.Select();
            }

            private void ButonSorgula_Click(object sender, EventArgs e)
            {
                sorgula();
               
                    
            }


            string dosya_yolu;
            String[] kayitlar;
            String okunan;
          public static  Ev[] ev = new Ev[1000];
          public static int kont;

            public void sorgula()
            {


                if (kiralik_secim.Checked == true)
                {
                    dosya_yolu = "kiralik.txt";

                    int i = 0;

                    FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                    StreamReader sr = new StreamReader(fs);

                    kont = 0;

                    if (ilce_combobox.Text != "" && textBoxAlanMax.Text != "" && textBoxAlanMin.Text != "" && fiyatorkiraMax.Text != "" && fiyatorkiraMin.Text != "" && comboBox_tur.Text != "")
                    {
                        okunan = sr.ReadLine();

                        while (okunan != null)
                        {
                            kayitlar = okunan.Split(':', ',');

                            if (checkBox1.Checked==true)                            {
                                if (Convert.ToDecimal(kayitlar[1]) == oda_sayisi_numeric.Value && Convert.ToDecimal(kayitlar[3]) == kat_numeric.Value && kayitlar[5] == ilce_combobox.Text && Convert.ToInt32(kayitlar[7]) > Convert.ToInt32(textBoxAlanMin.Text) && Convert.ToInt32(kayitlar[7]) < Convert.ToInt32(textBoxAlanMax.Text) && Convert.ToInt32(kayitlar[15]) > Convert.ToInt32(fiyatorkiraMin.Text) && Convert.ToInt32(kayitlar[15]) < Convert.ToInt32(fiyatorkiraMax.Text) && kayitlar[19] == comboBox_tur.Text)
                                {
                                    ev[i] = new KiralıkEv(Convert.ToInt32(kayitlar[1]), Convert.ToInt32(kayitlar[3]), kayitlar[5], Convert.ToDouble(kayitlar[7]), Convert.ToDateTime(kayitlar[9]));
                                    ev[i].aktif = Convert.ToBoolean(kayitlar[11]);
                                    ev[i].emlak_numarası = Convert.ToDouble(kayitlar[13]);
                                    ev[i].kira = Convert.ToDouble(kayitlar[15]);
                                    ev[i].depozito = Convert.ToDouble(kayitlar[17]);

                                    string tur = kayitlar[19];
                                    switch (tur)
                                    {
                                        case "Daire":
                                            ev[i].tur = (Ev.türü)0;
                                            break;

                                        case "Bahçeli":
                                            ev[i].tur = (Ev.türü)1;
                                            break;

                                        case "Dubleks":
                                            ev[i].tur = (Ev.türü)2;
                                            break;

                                        case "Müstakil":
                                            ev[i].tur = (Ev.türü)3;

                                            break;
                                    }

                                    i++;

                                }
                            }


                            else
                            {
                                if (Convert.ToDecimal(kayitlar[1]) == oda_sayisi_numeric.Value && Convert.ToDecimal(kayitlar[3]) == kat_numeric.Value && kayitlar[5] == ilce_combobox.Text && Convert.ToInt32(kayitlar[7]) > Convert.ToInt32(textBoxAlanMin.Text) && Convert.ToInt32(kayitlar[7]) < Convert.ToInt32(textBoxAlanMax.Text) && Convert.ToInt32(kayitlar[15]) > Convert.ToInt32(fiyatorkiraMin.Text) && Convert.ToInt32(kayitlar[15]) < Convert.ToInt32(fiyatorkiraMax.Text) && kayitlar[19] == comboBox_tur.Text && kayitlar[11] == "True")
                                {
                                    ev[i] = new KiralıkEv(Convert.ToInt32(kayitlar[1]), Convert.ToInt32(kayitlar[3]), kayitlar[5], Convert.ToDouble(kayitlar[7]), Convert.ToDateTime(kayitlar[9]));
                                    ev[i].aktif = Convert.ToBoolean(kayitlar[11]);
                                    ev[i].emlak_numarası = Convert.ToDouble(kayitlar[13]);
                                    ev[i].kira = Convert.ToDouble(kayitlar[15]);
                                    ev[i].depozito = Convert.ToDouble(kayitlar[17]);

                                    string tur = kayitlar[19];
                                    switch (tur)
                                    {
                                        case "Daire":
                                            ev[i].tur = (Ev.türü)0;
                                            break;

                                        case "Bahçeli":
                                            ev[i].tur = (Ev.türü)1;
                                            break;

                                        case "Dubleks":
                                            ev[i].tur = (Ev.türü)2;
                                            break;

                                        case "Müstakil":
                                            ev[i].tur = (Ev.türü)3;

                                            break;
                                    }

                                    i++;

                                }
                            }

                           

                            okunan = sr.ReadLine();
                            kayitlar = null;




                        }


                        fs.Close();
                        sr.Close();
                        ListelemeEkranı lst = new ListelemeEkranı();
                        lst.Show();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Lütfen bütün değerleri giriniz");
                    }
                }


                if (satilik_secim.Checked == true)
                {
                    dosya_yolu = "satilik.txt";


                    int i = 0;

                    FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                    StreamReader sr = new StreamReader(fs);


                    kont = 1;

                    if (ilce_combobox.Text != "" && textBoxAlanMax.Text != "" && textBoxAlanMin.Text != "" && fiyatorkiraMax.Text != "" && fiyatorkiraMin.Text != "" && comboBox_tur.Text != "")
                    {
                        okunan = sr.ReadLine();



                        while (okunan != null)
                        {
                            kayitlar = okunan.Split(':', ',');

                            if (checkBox1.Checked == true)      
                            {
                                if (Convert.ToDecimal(kayitlar[1]) == oda_sayisi_numeric.Value && Convert.ToDecimal(kayitlar[3]) == kat_numeric.Value && kayitlar[5] == ilce_combobox.Text && Convert.ToInt32(kayitlar[7]) > Convert.ToInt32(textBoxAlanMin.Text) && Convert.ToInt32(kayitlar[7]) < Convert.ToInt32(textBoxAlanMax.Text) && Convert.ToInt32(kayitlar[15]) > Convert.ToDouble(fiyatorkiraMin.Text) && Convert.ToInt32(kayitlar[15]) < Convert.ToDouble(fiyatorkiraMax.Text) && kayitlar[17] == comboBox_tur.Text)
                                {
                                    ev[i] = new SatılıkEv(Convert.ToInt32(kayitlar[1]), Convert.ToInt32(kayitlar[3]), kayitlar[5], Convert.ToDouble(kayitlar[7]), Convert.ToDateTime(kayitlar[9]));
                                    ev[i].aktif = Convert.ToBoolean(kayitlar[11]);
                                    ev[i].emlak_numarası = Convert.ToDouble(kayitlar[13]);
                                    ev[i].fiyat = Convert.ToDouble(kayitlar[15]);


                                    string tur = kayitlar[17];
                                    switch (tur)
                                    {
                                        case "Daire":
                                            ev[i].tur = (Ev.türü)0;
                                            break;

                                        case "Bahçeli":
                                            ev[i].tur = (Ev.türü)1;
                                            break;

                                        case "Dubleks":
                                            ev[i].tur = (Ev.türü)2;
                                            break;

                                        case "Müstakil":
                                            ev[i].tur = (Ev.türü)3;

                                            break;
                                    }

                                    i++;
                                }
                            }

                            else
                            {
                                if (Convert.ToDecimal(kayitlar[1]) == oda_sayisi_numeric.Value && Convert.ToDecimal(kayitlar[3]) == kat_numeric.Value && kayitlar[5] == ilce_combobox.Text && Convert.ToInt32(kayitlar[7]) > Convert.ToInt32(textBoxAlanMin.Text) && Convert.ToInt32(kayitlar[7]) < Convert.ToInt32(textBoxAlanMax.Text) && Convert.ToInt32(kayitlar[15]) > Convert.ToDouble(fiyatorkiraMin.Text) && Convert.ToInt32(kayitlar[15]) < Convert.ToDouble(fiyatorkiraMax.Text) && kayitlar[17] == comboBox_tur.Text && kayitlar[11] == "True")
                                {
                                    ev[i] = new SatılıkEv(Convert.ToInt32(kayitlar[1]), Convert.ToInt32(kayitlar[3]), kayitlar[5], Convert.ToDouble(kayitlar[7]), Convert.ToDateTime(kayitlar[9]));
                                    ev[i].aktif = Convert.ToBoolean(kayitlar[11]);
                                    ev[i].emlak_numarası = Convert.ToDouble(kayitlar[13]);
                                    ev[i].fiyat = Convert.ToDouble(kayitlar[15]);


                                    string tur = kayitlar[17];
                                    switch (tur)
                                    {
                                        case "Daire":
                                            ev[i].tur = (Ev.türü)0;
                                            break;

                                        case "Bahçeli":
                                            ev[i].tur = (Ev.türü)1;
                                            break;

                                        case "Dubleks":
                                            ev[i].tur = (Ev.türü)2;
                                            break;

                                        case "Müstakil":
                                            ev[i].tur = (Ev.türü)3;

                                            break;
                                    }

                                    i++;
                                }
                            }


                            okunan = sr.ReadLine();
                            kayitlar = null;




                        }


                        fs.Close();
                        sr.Close();
                        ListelemeEkranı lst = new ListelemeEkranı();
                        lst.Show();
                        this.Close();



                    }

                    else
                    {
                        MessageBox.Show("Lütfen bütün değerleri giriniz");
                    }

                }

                
            }

            private void textBoxAlanMin_KeyPress(object sender, KeyPressEventArgs e)
            {

                if ((int)e.KeyChar >= 48 && (int)e.KeyChar <=57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }
 
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
            }

            

        
        }
}
   
