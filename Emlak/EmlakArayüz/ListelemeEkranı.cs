using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace EmlakArayüz
{
    public partial class ListelemeEkranı : Form
    {
        public ListelemeEkranı()
        {
            InitializeComponent();
        }

        private void ListelemeEkranı_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SorgulamaEkranı.ev.Length; i++)
            {
                if (SorgulamaEkranı.ev[i] != null)
                {
                    listBox1.Items.Add(SorgulamaEkranı.ev[i].EvBilgileri());
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != "")
            {
                sil();
            }

            else
            {
                MessageBox.Show("Seçim Yapılmadı");
            }
        }




        string dosya_yolu;
        public void sil()
        {
            if (SorgulamaEkranı.kont == 0)
            {
                dosya_yolu = "kiralik.txt";
            }

            if (SorgulamaEkranı.kont == 1)
            {
                dosya_yolu = "satilik.txt";
            }

            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            StreamWriter sw = new StreamWriter("gecici.txt");

            string okunan = sr.ReadLine();
            int indeks = listBox1.SelectedIndex;
            Directory.Delete (SorgulamaEkranı.ev[indeks].emlak_numarası.ToString());
            while (okunan != null)
            {
                if (okunan != listBox1.Text)
                {
                    sw.WriteLine(okunan);
                    
                }

                okunan = sr.ReadLine();
            }

            fs.Close();
            sr.Close();
            sw.Close();
            listBox1.Items.Remove(listBox1.Text);
            File.Delete(dosya_yolu);
            File.Move("gecici.txt", dosya_yolu);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != "")
            {
                arsivle();
            }

            else
            {
                MessageBox.Show("Seçim Yapılmadı");
            }
        }


        public void arsivle()
        {
            if (SorgulamaEkranı.kont == 0)
            {
                dosya_yolu = "kiralik.txt";
            }

            if (SorgulamaEkranı.kont == 1)
            {
                dosya_yolu = "satilik.txt";
            }

            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            StreamWriter sw = new StreamWriter("gecici.txt");

            int indeks = listBox1.SelectedIndex;

            if (SorgulamaEkranı.ev[indeks].aktif == true)
            {
                SorgulamaEkranı.ev[indeks].aktif = false;
            }


            else if (SorgulamaEkranı.ev[indeks].aktif == false)
            {
                SorgulamaEkranı.ev[indeks].aktif = true;
            }
       


            string okunan = sr.ReadLine();

            while (okunan != null)
            {
                if (okunan != listBox1.Text)
                {
                    sw.WriteLine(okunan);

                }
                if(okunan==listBox1.Text)
                {
                    sw.WriteLine(SorgulamaEkranı.ev[indeks].EvBilgileri());
                }


                okunan = sr.ReadLine();
            }

            fs.Close();
            sr.Close();
            sw.Close();
            listBox1.Items.Remove(listBox1.Text);
            listBox1.Items.Add(SorgulamaEkranı.ev[indeks].EvBilgileri());
            File.Delete(dosya_yolu);
            File.Move("gecici.txt", dosya_yolu);
                


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (listBox1.Text != "")
            {
                klasor_ac();
            }

            else
            {
                MessageBox.Show("Seçim Yapılmadı");
            }

        }

        public void klasor_ac()
        {
            int indeks = listBox1.SelectedIndex;
          
            Process.Start(SorgulamaEkranı.ev[indeks].emlak_numarası.ToString());
        }

        
        public static int indeks;
        public static string secilen_ev;
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != "")
            {
                DüzenlemeEkranı dznform = new DüzenlemeEkranı();

                dznform.Show();

                indeks = listBox1.SelectedIndex;
                secilen_ev = listBox1.Text;
                
            }

            else
            {
                MessageBox.Show("Seçim Yapılmadı");
            }
           
        }

    }
}
