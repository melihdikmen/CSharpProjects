using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ClassLibrary1
{
    public abstract  class Ev
    {
        private int OdaSayısı;
        private int KatNumarası;
        private string Semti;
        private double Alanı;
        private DateTime YapımTarihi;
        
        public   enum türü
        {
              Daire,
              Bahçeli,
              Müstakil,
              Dubleks,
           
        }  

        private bool Aktif;
        private double Emlak_numarası;
        private double Depozito;
        private double Kirası;
        private double Fiyat;
        
      

        //property
        public int oda_sayısı
        {
            get
            {
                return OdaSayısı;
            }

            set
            {
                if (value < 0)
                {
                    
                    OdaSayısı = 0;
                }

                else
                {
                    OdaSayısı = value;
                }

                log_yaz(value);
                              
            }

        }

        public int kat_numarası
        {
            get
            {
                return KatNumarası;
            }


            set
            {
                             
                    KatNumarası = value;
                

                
            }
        }

        public string semt
        {
            get
            {
                return Semti;
            }

            set
            {
                if (value != null)
                {
                    Semti = value;
                }

                else
                {
                    throw new Exception("değer girilmedi");
                }

            }
        }

        public double alan
        {
            get
            {
                return Alanı;
            }

            set
            {
                
                    Alanı = value;
                

            }
        }

        public DateTime yapım_tarihi
        {
            get
            {
                return YapımTarihi;
            }

            set
            {
                if (value != null)
                {
                    YapımTarihi = value;
                }

                else
                {
                    throw new Exception("değer girilmedi");
                }
            }
        }

        public türü tur;
        
        
        

      

       

        public bool aktif
        {
            get
            {
                return Aktif;
            }

            set
            {

                Aktif = value; 
                
            }
        }

        public double emlak_numarası
        {
            get
            {
                return Emlak_numarası;
            }

            set
            {
                
                
                    Emlak_numarası = value;
                

               
            }
        }

        public double depozito
        {
            get
            {
                return Depozito;
            }

            set
            {

              
              
                    Depozito = value;
                

                
            }
        }

        public double kira
        {
            get
            {
                return Kirası;
            }

            set
            {
                
                
                    Kirası = value;
                                
            }
        }

        public double fiyat
        {
            get
            {
                return Fiyat;
            }

            set
            {
                
                    Fiyat = value;
                

                
            }
        }

        public int yas
        {
            get
            {
                return DateTime.Now.Year - YapımTarihi.Year;
            }
        }

       
        //log yazma işlemi
        public void log_yaz(object deger)
        {
            StreamWriter sw = new StreamWriter("log.txt", true);

            sw.WriteLine(DateTime.Now + " " + deger);

            sw.Close();
        }

       
        //Constructorlar
        public Ev(int oda_sayisi, int kat_numarasi, string semt, double alan)
        {
            this.OdaSayısı = oda_sayisi;
            this.KatNumarası = kat_numarasi;
            this.Semti = semt;
            this.Alanı = alan;

        }

        //Constructor overloading
        public Ev(int oda_sayisi, int kat_numarasi, string semt, double alan,DateTime yapım_tarihi)
        {
            this.OdaSayısı = oda_sayisi;
            this.KatNumarası = kat_numarasi;
            this.Semti = semt;
            this.Alanı = alan;
            this.YapımTarihi=yapım_tarihi;

        }



        //Constructor overloading
        public Ev(int oda_sayisi, int kat_numarasi, string semt, double alan,double Emlakno)
        { 
            this.OdaSayısı = oda_sayisi;
            this.KatNumarası = kat_numarasi;
            this.Semti = semt;
            this.Alanı = alan;
            this.Emlak_numarası = Emlakno;

        }

        
        
           
        

        
        //metodlar
        public abstract  string EvBilgileri();
        
           
        


        public void FiyatHesapla()
        {
            double fiyat = 0;

            if (File.Exists("room_cost.txt") == true)
            {
                FileStream fs = new FileStream("room_cost.txt", FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(fs);

                double kat_sayi = Convert.ToDouble(sr.ReadLine());

                fiyat = oda_sayısı * kat_sayi;
                
                fs.Close();
                sr.Close();

            }

            else
            {
                fiyat = oda_sayısı * 200;
            }

            this.kira = fiyat; ;


        }


        



    }
}
