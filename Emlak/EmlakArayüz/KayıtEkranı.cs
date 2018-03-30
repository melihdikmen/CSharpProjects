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
    public partial class KayıtEkranı : Form
    {
        public KayıtEkranı()
        {
            InitializeComponent();
            
        }

        private void il_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String dosya_adi;
            ilce_combobox.Items.Clear();





                dosya_adi = il_combobox.Text+".txt";
                FileStream fs = new FileStream(dosya_adi, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs,Encoding.GetEncoding("iso-8859-9"),false);

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

        private void KayıtEkranı_Load(object sender, EventArgs e)
        {
            kiralik_secim.Select();
           
        }

        private void kiralik_secim_CheckedChanged(object sender, EventArgs e)
        {
            if (kiralik_secim.Checked==true)
            {
                label8.Text = "Depozito:";
                label8.Visible = true;
            }

            if (satilik_secim.Checked == true)
            {
                label8.Text = "Fiyat:";
                label8.Visible = true;
            }
        }

        
        
        private void ButonKayıt_Click(object sender, EventArgs e)
        {
            kayıt();
            this.Close();

           
        }


        Ev[] ev_dizi = new Ev[1000];
        Random rnd = new Random();
       

        public void kayıt()
        {
            if (kiralik_secim.Checked == true)
            {
                if (ilce_combobox.Text != "" && textBoxAlan.Text != "" && comboBox_tur.Text != "" && fiyatordepozito.Text != "")
                {
                    for (int i = 0; i < ev_dizi.Length; i++)
                    {
                        if (ev_dizi[i] == null)
                        {
                            ev_dizi[i] = new KiralıkEv(Convert.ToInt32(oda_sayisi_numeric.Value), Convert.ToInt32(kat_numeric.Value), ilce_combobox.Text, Convert.ToDouble(textBoxAlan.Text), tarih_datetime.Value);
                            ev_dizi[i].depozito = Convert.ToDouble(fiyatordepozito.Text);
                            ev_dizi[i].aktif = true;
                            ev_dizi[i].FiyatHesapla();


                            do
                            {
                                int rastgele = rnd.Next(100, 100000);
                                emlakno_kontrol(2, rastgele);
                                if (sonuc == -1)
                                {
                                    ev_dizi[i].emlak_numarası = rastgele;
                                    emlakno_kontrol(1, rastgele);
                                }

                            } while (sonuc == 0);


                            string tur = comboBox_tur.Text;
                            switch (tur)
                            {
                                case "Daire":
                                    ev_dizi[i].tur = (Ev.türü)0;
                                    break;

                                case "Bahçeli":
                                    ev_dizi[i].tur = (Ev.türü)1;
                                    break;

                                case "Müstakil":
                                    ev_dizi[i].tur = (Ev.türü)2;
                                    break;

                                case "Dubleks":
                                    ev_dizi[i].tur = (Ev.türü)3;

                                    break;
                            }


                            dosya_yaz(0, ev_dizi[i].EvBilgileri(), ev_dizi[i].emlak_numarası.ToString());

                            break;




                        }


                    }

                }

                else
                {
                    MessageBox.Show("Lütfen Bütün Değerleri Giriniz");
                }

            }




            if (satilik_secim.Checked == true)
            {
                if (ilce_combobox.Text != "" && textBoxAlan.Text != "" && comboBox_tur.Text != "" && fiyatordepozito.Text != "")
                {
                    for (int i = 0; i < ev_dizi.Length; i++)
                    {
                        if (ev_dizi[i] == null)
                        {
                            ev_dizi[i] = new SatılıkEv(Convert.ToInt32(oda_sayisi_numeric.Value), Convert.ToInt32(kat_numeric.Value), ilce_combobox.Text, Convert.ToDouble(textBoxAlan.Text), tarih_datetime.Value);
                            ev_dizi[i].fiyat = Convert.ToDouble(fiyatordepozito.Text);
                            ev_dizi[i].aktif = true;





                            do
                            {
                                int rastgele = rnd.Next(100, 100000);
                                emlakno_kontrol(2, rastgele);
                                if (sonuc == -1)
                                {
                                    ev_dizi[i].emlak_numarası = rastgele;
                                    emlakno_kontrol(1, rastgele);
                                }

                            } while (sonuc == 0);



                            string tur = comboBox_tur.Text;
                            switch (tur)
                            {
                                case "Daire":
                                    ev_dizi[i].tur = (Ev.türü)0;
                                    break;

                                case "Bahçeli":
                                    ev_dizi[i].tur = (Ev.türü)1;
                                    break;

                                case "Müstakil":
                                    ev_dizi[i].tur = (Ev.türü)2;
                                    break;

                                case "Dubleks":
                                    ev_dizi[i].tur = (Ev.türü)3;

                                    break;
                            }


                            dosya_yaz(1, ev_dizi[i].EvBilgileri(), ev_dizi[i].emlak_numarası.ToString());
                            break;




                        }


                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bütün Değerleri Giriniz");
                }
            }

                     
        }

      
        string dosya_yolu;

        public void dosya_yaz(int kont,string yazılacak,string resim_klasor)
        {
            
            
            if (kont == 0)
            {
                dosya_yolu = "kiralik.txt";
            }

            if (kont == 1)
            {
                dosya_yolu = "satilik.txt";
            }

            

            StreamWriter sw=new StreamWriter(dosya_yolu,true);

            Directory.CreateDirectory(resim_klasor);

            sw.WriteLine(yazılacak);
            sw.Close();


        }

        int sonuc;
        public void emlakno_kontrol(int gelen,double emlakNo)
        {
            if (gelen == 1)
            {
                StreamWriter sw = new StreamWriter("emlakno.txt", true);
                sw.WriteLine(emlakNo);
                sw.Close();
            }

            if (gelen == 2)
            {
                FileStream fs = new FileStream("emlakno.txt",FileMode.OpenOrCreate,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
              
               
                string okunan=sr.ReadLine();
                
                while(okunan!=null)
                {
                    if (okunan == emlakNo.ToString())
                    {
                        sonuc = 0;
                        break;
                    }

                    okunan = sr.ReadLine();
                }

                sonuc = -1;





                fs.Close();
                sr.Close();
            }


        }

        private void textBoxAlan_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
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
