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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            kontrol();
        }

        AnaEkran form;
        public void kontrol()
        {
            
            FileStream fs = new FileStream("users.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string okunan = sr.ReadLine();
            string[] kulanıcı;
            while (okunan != null)
            {
                
                kulanıcı = null;
                kulanıcı=okunan.Split(' ');
                
                if (kullanıcı_text.Text.Trim() == kulanıcı[0].ToString() && sifre_text.Text.Trim() == kulanıcı[1].ToString())
                {

                     form = new AnaEkran();
                    form.Show();
               
                    this.Close();
                    


                    
                }

                okunan = sr.ReadLine();

               
            }

            MessageBox.Show("Yetkisiz Giriş");


        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (form == null)
            {
                Application.Exit();
            }
        }

       

       

        

        

    }
}
