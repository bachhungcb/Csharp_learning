﻿using System;

namespace _34.Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //static = modifier to declare a static member, which belongs to the class it self
            //         rather than to any specific object
            Car car1 = new Car("Mustang");
            Car car2 = new Car("Toyota");
            Car car3 = new Car("Ford");

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();

            Console.ReadKey();
        }
    }

    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
