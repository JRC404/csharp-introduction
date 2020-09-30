using System;

namespace polymorphism
{
    class Display
    {
        // public void DisplayMe(short data)
        // {
        //     Console.WriteLine($"Your data type is a short: {data}");
        // }
        public void DisplayMe(int data)
        {
            Console.WriteLine($"Your data type is an int: {data}");
        }
        public void DisplayMe(double data)
        {
            Console.WriteLine($"Your data type is a double: {data}");
        }
        public void DisplayMe(string data)
        {
            Console.WriteLine($"Your data type is a string: {data}");
        }

        public void phoneNumber(string phoneNo)
        {
            Console.WriteLine($"Thank you for inputting your phone number: {phoneNo}");
        }
        public void phoneNumber(double phoneNo)
        {
            string newValue = Convert.ToString(phoneNo);
            Console.WriteLine($"Your value was converted: {newValue}");
        }
        public void phoneNumber(bool phoneNo)
        {
            Console.WriteLine($"You're an idiot.");
        }

    }
}