using System;

namespace greeting
{
    class SayHello
    {
        string firstName = "Jacob";
        int age = 55;
        public void hello()
        {
            Console.WriteLine("My name is " + firstName + " and I am " + age + " years old."); // old way
            Console.WriteLine("My name is {0} and I am {1} years old.", firstName, age); // semi-new
            Console.WriteLine($"My name is {firstName} and I am {age} years old. "); // new
        }
    }
}