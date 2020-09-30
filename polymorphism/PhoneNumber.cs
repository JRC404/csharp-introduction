using System;

namespace polymorphism
{
    class PhoneNumber
    {
        public void enterDetails(string name, string numberOne)
        {
            Console.WriteLine($"Hello, {name}. You entered 1 number: {numberOne}");
            // query to the database - passing through the name and the number
        }
        public void enterDetails(string name, string numberOne, string numberTwo)
        {
            Console.WriteLine($"Hello, {name}. You entered 2 numbers: {numberOne} & {numberTwo}");
            // query to the database - passing through the name and the two numbers
        }
        public void enterDetails(string name, string nickname, string numberOne, string numberTwo)
        {
            Console.WriteLine($"Hello, {name}. You have asked me to call you {nickname}. You entered 2 numbers: {numberOne} & {numberTwo}");
            // query to the database - passing through the name and the two numbers
        }

        public void enterDetails(string name) 
        {
            Console.WriteLine($"I need more from you, {name}, I've told you before.");
        }
    }
}