using System;
using System.Collections.Generic;

namespace Ex5_CarAndPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Red", 3.5, 15, true, 100000);
            Car car2 = new Car("Blue", 2.1, 14, true, 50000);
            Car car3 = new Car("Purple", 2.0, 30, false, 0);
            Car car4 = new Car("Yellow", 3.0, 7, true, 1530);
            Car car5 = new Car("Red", 1.5, 25, false, 13522);

            List<Car> cars = new();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);

            car1.PrintCarsOfColor(cars, "Red");

        }
    }
}