using System;

namespace dotnet_tests
{
    class Program
    {

        public static void doSomething(string str1)
        {
            Console.WriteLine("doSomething1");
            Console.WriteLine(str1);
        }

        public static void doSomething(string str1, string str2)
        {
            Console.WriteLine("doSomething2");
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
        static void Main(string[] args)
        {

            // Using a constructor that sets age
            /* var student = new Student(27, "Tiago");
            student.Name = "Ana";
            Console.WriteLine("This is a new student:");
            Console.WriteLine(student.Name + ' ' + student.Age);
            Console.WriteLine(Student.addTwoNumbers(77, 205)); */
            Vehicle car1 = new Car("Renault", "Zoe");
            car1.doStuff();
            doSomething("Hi!");
            // doSomething("Hi!", "See ya!");
        }
    }
}
