using System;

namespace memoryLane
{
    class Program
    {
        static void Main(string[] args)
        {
            // int age = 55;
            // bool value = true;
            double random = 456.49;
            // float height = 182.5f;
            int newRandom = Convert.ToInt32(random);
            Console.WriteLine(newRandom);
            // Console.WriteLine(age.ToString());
            // Console.WriteLine(value.ToString());
            // Console.WriteLine(random.ToString());
            // Console.WriteLine(height.ToString());
            Console.ReadKey();
        }
    }
}

// Console.Write("Please tell me your name: ");
// // write displays the text and does nothing else
// // Console.WriteLine("Please tell me your name: ");
// // writeLine displays the text then pressed enter
// string firstName = Console.ReadLine();
// Console.WriteLine($"Oh, hello {firstName}");
// Console.Write("Please tell me your age: ");
// int age = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine(age + 5);
// for (; ; ) infinite loop
// for (int i = 0; i < 10; i++)
// // for (int i = 0; i < something; i++)
// // for (initialisation; condition; increment / decrement)
// {
//     Console.WriteLine(i);
// }
// int age = 0;
// while (age < 30)
// {
//     Console.WriteLine($"Age value is {age}");
//     age++;
// }
// if (true)
// {
//     Console.WriteLine("Oh, true?");
// }
// else {
//     Console.WriteLine("Oh, false?");
// }