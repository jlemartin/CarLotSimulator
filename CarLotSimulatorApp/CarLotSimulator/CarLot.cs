using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        //Create a CarLot class
        //It should have at least one property: a List of cars

        public CarLot()
        {
        }

        public List<Car> LotList = new List<Car>();

        public static int numberOfCars = 0;
    }
}
