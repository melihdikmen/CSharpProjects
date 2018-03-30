using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace sayi_bulma_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            radioButton3.Checked = true;

        }


        int hak = 0;
        int skor = 0;
        private void button1_Click(object sender, EventArgs e)
        {
             hak =(int) numericUpDown2.Value;
            int basamak = 0;
            int tkrr=0;
            int deger = 0;
           
            
            if (radioButton1.Checked&&radioButton3.Checked)
            {
                basamak = 0;
                tkrr = 0;
                deger = (int)numericUpDown1.Value;
            }

            if (radioButton1.Checked && radioButton4.Checked)
            {
                basamak = 0;
                tkrr = 1;
                deger = (int)numericUpDown1.Value;

            }

            
            
            if (radioButton2.Checked&&radioButton3.Checked)
            {
                basamak = 1;
                tkrr = 0;

            }

            if (radioButton2.Checked && radioButton4.Checked)
            {
                basamak = 1;
                tkrr = 1;
                
            }

            
            basamak_sayisi(basamak, tkrr, deger);
            
            label3.Text = hak.ToString(); ;
        
        }

      

        int basamak_sayi = 0;
        int[] sayi = new int[100];
        TextBox[] texdizi = new TextBox[100];
        int sayac = 0;
        
       
        
        public void basamak_sayisi(int basamak,int tkrr,int deger)
        {
            Random rnd = new Random();
            
            
            if (basamak == 0)
            {
                basamak_sayi = deger;


                if (tkrr == 0)
                {
                    for (int i = 0; i < basamak_sayi; i++)
                    {
                        sayi[i] = rnd.Next(0, 10);
                    }
                }


                if (tkrr == 1)
                {
                    int kont = -1;
                    
                    for (int i = 0; i < basamak_sayi; i++)
                    {
                        sayi[i] = rnd.Next(0, 10);

                        kont = Array.IndexOf(sayi, sayi[i]);

                        if (kont != i && kont != -1)
                        {
                            i--;
                        }
                 
                    }


                }
   
            }



            if (basamak == 1)
            {
                basamak_sayi = rnd.Next(1, 11);
               

                if (tkrr == 0)
                {
                    for (int i = 0; i < basamak_sayi; i++)
                    {
                        sayi[i] = rnd.Next(0, 10);
                    }
                }


                if (tkrr == 1)
                {
                    int kont = -1;

                    for (int i = 0; i < basamak_sayi; i++)
                    {
                        sayi[i] = rnd.Next(0, 10);

                        kont = Array.IndexOf(sayi, sayi[i]);

                        if (kont != i && kont != -1)
                        {
                            i--;
                        }


                    }

                }

            }

            for(int i=0;i<basamak_sayi; i++)
            {
            TextBox textbox = new TextBox();
            textbox.Top = 50;
            textbox.Left = 400 + (i * 50);
            textbox.Width = 25;
            textbox.Text = null;
            textbox.MaxLength = 1;
            textbox.KeyPress += sadece_sayi;
            
            

            texdizi[i] = textbox;

            this.Controls.Add(textbox);
            }

            for (int i = 0; i < basamak_sayi; i++)
            {
                label1.Text += sayi[i];
                
            }


        }

       
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

       
        
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sayi_kontrol();
           
          
        }


        public void sayi_kontrol()
        {
            
            
            for (int i = 0; i < basamak_sayi; i++)
            {
                if (texdizi[i].Text == "")
                {
                    MessageBox.Show("Boş kutucuk bırakmayınız!!!");
                    break;
                }
                
                if (sayi[i] != -1)
                {
                    if (texdizi[i].BackColor == Color.Red)
                    {
                        texdizi[i].BackColor = Color.White;
                    }


                    int indeks = -1;

                    int temp = Convert.ToInt32(texdizi[i].Text.Trim());

                    if (temp == sayi[i])
                    {
                        texdizi[i].BackColor = Color.Blue;
                        sayi[i] = -1;
                        skor += 5;
                        label8.Text = skor.ToString();


                    }

                    else
                    {
                        indeks = Array.IndexOf(sayi, temp);

                    }


                    if (indeks != -1 && sayi[indeks] != -1)
                    {
                        texdizi[i].BackColor = Color.Red;
                    }




                    if (texdizi[i].BackColor != Color.Blue && texdizi[i].BackColor != Color.Red)
                    {
                        texdizi[i].Text = "";
                    }


                }
                
            }

            for (int i = 0; i < basamak_sayi; i++)
            {
                if (sayi[i] == -1)
                {
                    sayac++;

                }

            }
           

            if (sayac == basamak_sayi)
            {

                MessageBox.Show("Butun sayilari dogru tahmin ettniz");
                skor_yaz(skor);
                Application.Restart();
            }

            sayac = 0;
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label4.Text == "0")
            {
               

                if (hak == 1)
                {
                    MessageBox.Show("Hakkınız bitti");
                    skor_yaz(skor);
                }

                else
                {
                    hak--;
                    label3.Text = hak.ToString();
                }
                


                for (int i = 0; i < basamak_sayi; i++)
                {
                    
                    if (texdizi[i].BackColor != Color.Blue&&texdizi[i].BackColor!=Color.Red)
                    {
                        texdizi[i].BackColor = Color.White;
                        texdizi[i].Text = "";
                    }
                   
                    
                }

                

                timer1.Stop();

                

                label4.Text = "30";

                MessageBox.Show("Süreniz Bitmiştir");
            }

           
            
            
            else
            {
                label4.Text = (Convert.ToInt32(label4.Text) - 1).ToString();
            }

           
            




        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            numericUpDown1.Enabled = true;
        }


        public void skor_yaz(int skor)
        {
            StreamWriter sw = new StreamWriter("skor.txt", true);
            sw.WriteLine(skor);

            sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            skor sk = new skor();
            sk.Show();
        }



        private void sadece_sayi(object sender,KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
 
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("sadece sayı girebilirsiniz!");
            }

        }



    }
}
