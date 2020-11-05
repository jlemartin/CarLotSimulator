using System;
namespace CarLotSimulator
{
    public class Car
    {

        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public Car()
        {
            CarLot.numberOfCars++;
        }

        public Car(int year, string make, string model, string engNoise, string honkNoise, bool driveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engNoise;
            HonkNoise = honkNoise;
            isDriveable = driveable;

            CarLot.numberOfCars++;
        }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool isDriveable { get; set; }

        public void MakeEngineNoise(string engNoise)
        {
            Console.WriteLine($"{engNoise} {engNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"{honkNoise} {honkNoise}");
        }
    }
}
