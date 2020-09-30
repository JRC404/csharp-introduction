using System;

namespace polymorphism
{
    class MainPizza
    {

        public string pizzaName =  "A shame";
        public void Pizza()
        {
            Console.WriteLine("Ham & Pineapple pizza has been selected");
        }
        public void Drink()
        {
            Console.WriteLine("You ordered a drink, well done.");
        }
    }

    class SecondaryPizza : MainPizza
    {
        new public void Pizza()
        {
            Console.WriteLine("Ham & Pineapple pizza with BBQ base selected");
        }
    }

    class GoodPizza : MainPizza
    {
        new public string pizzaName =  "American Hot";
        new public void Pizza()
        {
            Console.WriteLine("American Hot pizza selected");
        }
    }
}