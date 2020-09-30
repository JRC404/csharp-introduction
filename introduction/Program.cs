using System; // importing the System librabry

namespace introduction // storage place for our classes
// > inside of introduction, Program exists

{
    class Program
    {
        static void Main(string[] args)
        {
            CodeNation codenation = new CodeNation();
            Console.WriteLine(codenation.companyName);
            logic.Mathematics maths = new logic.Mathematics();
            int addition = maths.Addition(10, 40);
            int subraction = maths.Subtraction(40, 10);
            Console.WriteLine(addition);
            Console.WriteLine(subraction);

            // string interpolation
        }
    }
}

// string firstName = "Jacob"; // string of text
// int age = 55; // whole numbers, no decimal allowed
// bool really = true; // same as always, true or false!
// double height = 182.5d; // decimal placed number, floating point number
// float favouriteNumber = 4.00f; // floating point number
// decimal shoeSize = 9.01m;
// Console.WriteLine(age);
// Console.WriteLine(favouriteNumber);
// Console.WriteLine(shoeSize);