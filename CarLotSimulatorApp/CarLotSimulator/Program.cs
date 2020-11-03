using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program
            // and as you create a car add the car to the list.
            var list = new CarLot();

            //TODO

            // DONE - Create a seperate class file called Car
            // DONE -Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            // DONE - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            // DONE - The methods should take one string parameter: the respective noise property


            // DONE - Now that the Car class is created we can instanciate 3 new cars
            // DONE - Set the properties for each of the cars
            // DONE - Call each of the methods for each car

            // Car #1 - Instantiation using dot notation
            var car1 = new Car();
            car1.Year = 2012;
            car1.Make = "Subaru";
            car1.Model = "Outback";
            car1.EngineNoise = "Purr";
            car1.HonkNoise = "Beep!";
            car1.isDriveable = true;

            list.LotList.Add(car1);

            // Car #2 - Instantiation with Object Initializer Syntax
            var car2 = new Car()
            {
                Year = 2004,
                Make = "Chevrolet",
                Model = "Suburban",
                EngineNoise = "Rumble",
                HonkNoise = "Honk!",
                isDriveable = true
            };

            list.LotList.Add(car2);

            // Car #3 - Instantiation with Constructor to allow values inside
            var car3 = new Car(1997, "Toyota", "Camry", "Sputter", "Peep", false);

            // Add car to list
            list.LotList.Add(car3);

            Console.WriteLine($"The first vehicle is a {car1.Year} {car1.Make} {car1.Model}");
            Console.Write("Listen to it run: ");
            
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            if (car1.isDriveable)
            {
                Console.WriteLine("Drive this one home today!");
            }
            else
            {
                Console.WriteLine($"Needs some work. Got a tow?");
            }
            Console.WriteLine();

            Console.WriteLine($"The second vehicle is a {car2.Year} {car2.Make} {car2.Model}");
            Console.Write("Listen to it run: ");

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            if (car2.isDriveable)
            {
                Console.WriteLine("Drive this one home today!");
            }
            else
            {
                Console.WriteLine($"Needs some work. Got a tow?");
            }
            Console.WriteLine();

            Console.WriteLine($"The third vehicle is a {car3.Year} {car3.Make} {car3.Model}");
            Console.Write("Listen to it run: ");

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            if (car3.isDriveable)
            {
                Console.WriteLine("Drive this one home today!");
            }
            else
            {
                Console.WriteLine($"Needs some work. Got a tow?");
            }
            Console.WriteLine();



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            // DONE
            // Car #1 - Default constructor
            // Car #2 - Default constructor with property values passed
            // Car #3 - Custom constructor, property values passes as arguments for parameters

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in list.LotList)

            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
