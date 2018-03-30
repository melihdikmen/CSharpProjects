using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
  public   class SatılıkEv:Ev
    {

      public SatılıkEv(int oda_sayisi, int kat_numarasi, string semt, double alan, DateTime yapım_tarihi)
          : base(oda_sayisi, kat_numarasi, semt, alan, yapım_tarihi)
       {
           this.oda_sayısı = oda_sayisi;
           this.kat_numarası = kat_numarasi;
           this.semt = semt;
           this.alan = alan;
           this.yapım_tarihi = yapım_tarihi;
         

       }


      public override string EvBilgileri()
      {
          string bilgi = string.Format("Evin oda sayısı:{0}, kat:{1}, Semti:{2}, Alanı:{3}, Yapım Tarihi:{4:d},Aktif:{5}, Emlak  Numarası:{6}, Fiyatı:{7}, Tür:{8},Yaş:{9}  ", oda_sayısı, kat_numarası, semt, alan, yapım_tarihi, aktif, emlak_numarası, fiyat, tur, yas);

          return bilgi;
      }


    }
}
