using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Format resimFormat = new Format("png");

            try
            {
                resimFormat.form = "jpg";
            }

            catch(FormatHata hata)
            {
                Console.WriteLine(hata.Message) ;
            }


            Console.ReadLine();
        }
    }
}
