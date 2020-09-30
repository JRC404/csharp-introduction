using System;

namespace inheritance
{
    class CodeNation
    {
        public int id;
        public string name, role, location;

        // public CodeNation(int Id, string Name, string Role, string Location)
        // {
        //     id = Id;
        //     name = Name;
        //     role = Role;
        //     location = Location;
        // }

        public void printDetails()
        {
            System.Console.WriteLine(id);
            System.Console.WriteLine(name);
            System.Console.WriteLine(role);
            System.Console.WriteLine(location);
        }

    }
}