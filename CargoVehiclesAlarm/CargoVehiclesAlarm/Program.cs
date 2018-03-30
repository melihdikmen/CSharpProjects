using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CargoVehiclesAlarm
{
    class Program
    {
        static void Main(string[] args)
        {
            CargoVehicle kargo_aracı1 = new CargoVehicle("42SU1975"); 
             kargo_aracı1.SpeedExceeded += new EventHandler( kargo_aracı_SpeedExceeded);
            

             CargoVehicle kargo_aracı2 = new CargoVehicle("06CD456");
             kargo_aracı2.SpeedExceeded += new EventHandler(kargo_aracı_SpeedExceeded);
            
             int j = 0;
           for (byte i = 80; i < 130; i += 5) 
           {
                
               kargo_aracı1.Speed = i;
              
               kargo_aracı2.Speed = (byte)(i+j);
              

               Console.WriteLine(kargo_aracı1.Plaka + " plakalı aracın hızı = " + kargo_aracı1.Speed);
               Console.WriteLine(kargo_aracı2.Plaka + " plakalı aracın hızı = " + kargo_aracı2.Speed+"\n");
               
               j += 3;
               Thread.Sleep(1000); 
           }

           Console.ReadLine();
           
    
    
        }

       
        
        public static void kargo_aracı_SpeedExceeded(MyEventArgs args)
        {
            Console.WriteLine("Alarm: "+args.Plaka+" plakalı "+args.marka+ " marka kargo aracı hız limitini aştı."+DateTime.Now+ " anındaki hızı: " +args.Speed); 
            
         
        }

    }
}

