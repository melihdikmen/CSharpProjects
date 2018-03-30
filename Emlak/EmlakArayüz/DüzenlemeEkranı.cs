using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EmlakArayüz
{
    public partial class DüzenlemeEkranı : Form
    {
        public DüzenlemeEkranı()
        {
            InitializeComponent();
        }

        int indeks = ListelemeEkranı.indeks;
        private void DüzenlemeEkranı_Load(object sender, EventArgs e)
        {
            if (SorgulamaEkranı.kont == 0)
            {
                label1.Text = "Kirası:";
                kiraorfiyat_textbox.Text = SorgulamaEkranı.ev[indeks].kira.ToString();
                depozito_textbox.Text= SorgulamaEkranı.ev[indeks].depozito.ToString();

            }

            else
            {
                label1.Text = "Fiyatı:";
                kiraorfiyat_textbox.Text = SorgulamaEkranı.ev[indeks].fiyat.ToString();
                label2.Visible = false;
                depozito_textbox.Visible = false;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            guncelle();
        }


       
        
        string dosya_yolu;
        public void guncelle()
        {
            
            
            if (SorgulamaEkranı.kont == 0)
            {
                dosya_yolu = "kiralik.txt";

                if (kiraorfiyat_textbox.Text != "" || depozito_textbox.Text != null)
                {
                    SorgulamaEkranı.ev[indeks].kira = Convert.ToDouble(kiraorfiyat_textbox.Text);
                    SorgulamaEkranı.ev[indeks].depozito = Convert.ToDouble(depozito_textbox.Text);
                }

                else
                {
                    MessageBox.Show("Lutfen boş yer bırakmayınız");
                }
                
            }

            if (SorgulamaEkranı.kont == 1)
            {
                dosya_yolu = "satilik.txt";
                
                if (kiraorfiyat_textbox.Text != "" )
                {
                    SorgulamaEkranı.ev[indeks].fiyat = Convert.ToDouble(kiraorfiyat_textbox.Text);
   
                }

                else
                {
                    MessageBox.Show("Lutfen boş yer bırakmayınız");
                }
            }

            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            StreamWriter sw = new StreamWriter("gecici.txt");

            

           
             


            string okunan = sr.ReadLine();

            while (okunan != null)
            {
                if (okunan != ListelemeEkranı.secilen_ev)
                {
                    sw.WriteLine(okunan);

                }
                if (okunan ==  ListelemeEkranı.secilen_ev)
                {
                    sw.WriteLine(SorgulamaEkranı.ev[indeks].EvBilgileri());
                }


                okunan = sr.ReadLine();
            }

            fs.Close();
            sr.Close();
            sw.Close();
           
           
            File.Delete(dosya_yolu);
            File.Move("gecici.txt", dosya_yolu);
        }

        private void kiraorfiyat_textbox_KeyPress(object sender, KeyPressEventArgs e)
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
