using System;

namespace dotnet_tests
{
    public class Vehicle
    {
        private string brand;

        public void doStuff()
        {
            Console.WriteLine("This is from the Vehicle class!");
        }
        public Vehicle(string brand)
        {
            this.brand = brand;
            Console.WriteLine("I've got a {0} vehicle :)", brand);
        }
    }
}