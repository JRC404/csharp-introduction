using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneNumber addressBook = new PhoneNumber();
            addressBook.enterDetails("Jacob", "0777777777");
            addressBook.enterDetails("Jacob", "0777777777", "01708540653");
            addressBook.enterDetails("Jacob", "Dave", "0777777777", "01708540653");
            addressBook.enterDetails("Jacob");

            MainPizza alex = new MainPizza();
            alex.Pizza();
            SecondaryPizza dean = new SecondaryPizza();
            dean.Pizza();
            GoodPizza danny = new GoodPizza();
            danny.Pizza();
            Console.WriteLine(alex.pizzaName);

        }
    }
}

            // Display display = new Display();
            // // display.DisplayMe("07777777777");
            // // display.DisplayMe(-320); // -32,768 +32,767
            // // display.DisplayMe(33000);
            // display.phoneNumber("0777777777");
            // display.phoneNumber(0777777777);
            // display.phoneNumber(true);
            // // display.DisplayMe();