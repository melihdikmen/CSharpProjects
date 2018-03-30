using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoVehiclesAlarm
{
    public class MyEventArgs
    {
        private int speed;
        private string plaka;
        public string marka;
        public MyEventArgs(int speed, string plaka)
        {
            this.speed = speed;
            this.plaka = plaka;
        }

        public int Speed
        {
            get
            {
                return speed;
             }

            set
            {
                speed = value;
            }
            
        }


        public string Plaka
        {
            get
            {
                return plaka;
            }

            set
            {
                plaka = value;

                if (plaka == "42AC123")
                {
                    marka = "Fiat";
                }

                else
                    marka = "Peugeout";

            }
        }
    }
}
