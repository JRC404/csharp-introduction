using System;

namespace structures
{

    struct Staff {
        public int staffID;
        public string name;
        public string jobRole;
        public string location;
        public double salary;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Staff Staff1;
            Staff Staff2;
            Staff Staff3;
            
            Staff1.staffID = 1; // userInputted value
            Staff1.name = "Alex Arditti"; // userInputted value
            Console.WriteLine(Staff1.staffID);
            Console.WriteLine(Staff1.name);

            /* 

            Structures can have methods, properties, fields
            Strucutres cannot inherit from other structures
            Structures cannot be protected
            Structures, unlike classes, create a copy of itself, not a new instance

            */
        }
    }
}
