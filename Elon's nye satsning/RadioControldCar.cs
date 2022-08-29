using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elon_s_nye_satsning
{
    internal class RadioControldCar
    {
        //instans variable for the RadioControldCar class

        private string _color;

        private double _battery;

        private double _batteryProcentPerMeter;

        private int _distanceDriven;

        //encapsulation 

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public double Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }

        public double BatteryProcentPerMeter
        {
            get { return _batteryProcentPerMeter; }
            set { _batteryProcentPerMeter = value; }
        }

        public int DistanceDriven
        {
            get { return _distanceDriven; }
            set { _distanceDriven = value; }
        }

        //methood used for the class
        //a bool methood, whit the bool canDrive variable inside
        //if the car has more than 0% power, it will drive
        //for every meters driven the battery lowers 0.05%
        //will round the number to 2 digits
        //the thread.sleep is to make it feel like the car is using the batery
        //when the battery reaching 10% power, a low power warning is issued
        //if the battery comes down to 0, the forloop brakes, and tell the user the no power, cant drive!
        public bool Drive()
        {
            bool canDrive = true;
            if (Battery > 0)
            {
                for (int i = 0; i < DistanceDriven; i++)
                {
                    ShowDisplay(i);
                    Battery -= 0.05;
                    Battery = Math.Round(Battery, 2);
                    Thread.Sleep(10);
                    if (Battery <= 10.0)
                    {
                        Console.WriteLine("Low power");
                    }
                    if (Battery == 0.0)
                    {
                        canDrive = false;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No power");
                Console.WriteLine("Cant drive!");
                canDrive = false;
            }
            return canDrive;
        }

        //private methood to show the display, gets called inside the forloop
        private void ShowDisplay(int distance)
        {
            Console.WriteLine($"||Battery on {Battery}% || driven {distance + 1} meters ||");
        }

        //methood to charge the car to 100%
        public void Charge()
        {
            Battery = 100;
        }

    }
}
