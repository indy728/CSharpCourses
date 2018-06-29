using System;

namespace Inheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initiazlized with registration number {0}", registrationNumber);
        }
    }
}