using System;

namespace dotnet_tests
{
    public class Car : Vehicle
    {
        private string model;

        public new void doStuff()
        {
            Console.WriteLine("This is from the Car class!");
        }

        public Car(string brand, string model) : base(brand)
        {
            this.model = model;
            Console.WriteLine("My car's model is: {0}", model);
        }

    }
}