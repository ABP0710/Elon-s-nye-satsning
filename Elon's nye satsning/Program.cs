using System;

namespace Elon_s_nye_satsning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //school assignment on classes 
            //make 2 new objects from the RadioControldCar class, and sets the colors to a green car and a blue car
            RadioControldCar greenCar = new RadioControldCar();
            RadioControldCar blueCar = new RadioControldCar();

            greenCar.Color = "Green";
            blueCar.Color = "Blue";

            //charge the green car and sets the distance to drive
            greenCar.Charge();
            greenCar.DistanceDriven = 80;


            //make the start visual in the console
            Console.WriteLine("xxxxxxxxxxxxxxxxxx");
            Console.WriteLine();
            Console.WriteLine("Green car GOOOOOO!");
            Console.WriteLine();
            Console.WriteLine("xxxxxxxxxxxxxxxxxx");

            //run the bool method drive on the green car
            if(!greenCar.Drive())
            {

            }


            //charge the blue car and sets the distance to drive
            blueCar.Charge();
            blueCar.DistanceDriven = 200;

            //make the start visual in the console
            Console.WriteLine("xxxxxxxxxxxxxxxxxx");
            Console.WriteLine();
            Console.WriteLine("Blue car GOOOOOO!");
            Console.WriteLine();
            Console.WriteLine("xxxxxxxxxxxxxxxxxx");
            if (!blueCar.Drive())
            {

            }
        }
    }
}
