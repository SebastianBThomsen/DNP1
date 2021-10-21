using System;
using System.Collections.Generic;

namespace Ex5_CarAndPredicates
{
    public class Car
    {
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public double FuelEconomy { get; set; }
        public bool IsManualShift { get; set; }
        public int Odometer { get; set; }

        public Car(string color, double engineSize, double fuelEconomy, bool isManualShift, int odometer)
        {
            Color = color;
            EngineSize = engineSize;
            FuelEconomy = fuelEconomy;
            IsManualShift = isManualShift;
            Odometer = odometer;
        }

        public override string ToString()
        {
            return $"Colour of the car: {Color}" +
                   $"\nEngine size: {EngineSize}" +
                   $"\nFuelEconomy: {FuelEconomy}" +
                   $"\nIsManualShift: {IsManualShift}" +
                   $"\nOdometer: {Odometer}";
        }

        public List<Car> PrintCarsOfColor(List<Car> cars, string colour)
        {
            List<Car> cars2 = cars.FindAll(car => car.Color.Equals(colour));
            
            foreach (Car car in cars2)
            {
                Console.WriteLine(car.Odometer);
            }
            Console.WriteLine(cars.FindAll(car => car.Color.Equals(colour)).ToString());
            return cars.FindAll(car => car.Color.Equals(colour));
            /*
            foreach (Car car in cars)
            {
                if(car.Color.Equals(colour))
                    properCars.Add(car);
            }

            return properCars;
            */
        }
    }
}