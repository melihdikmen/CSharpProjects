using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandling
{
    public class Format
    {
        public string form
        {
            get
            {
                return form;
            }

            set
            {
                if (value == "png")
                {
                    Console.WriteLine("format doğru");
                }
                else
                {
                    throw new FormatHata();
                }
            
            }
        }
        public Format(string format)
        {
                                
                form = format;
                                             
        }
    }
}
