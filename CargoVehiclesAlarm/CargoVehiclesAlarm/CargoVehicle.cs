using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoVehiclesAlarm
{
    
    delegate void EventHandler(MyEventArgs args);
    
    class CargoVehicle
    {

        public CargoVehicle(string plaka)
        {
            this.plaka=plaka;
        }

        private string plaka;

        public string Plaka
        {
            get
            {
                return plaka;
            }


            set
            {
                plaka = value;
            }
        }


        public event EventHandler SpeedExceeded;

       private int speed;
        
        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed=value;
               
                if (speed >= 110)
                {
                    if (SpeedExceeded != null)
                    {
                        SpeedExceeded(new MyEventArgs(speed,plaka));
                    }
                }

            }
        }


             
    }
}
