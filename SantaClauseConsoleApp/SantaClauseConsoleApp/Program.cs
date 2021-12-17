using System;
using System.Collections.Generic;

namespace SantaClauseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Santa
            var santa = new SantaClause();

            //Create children
            var children = new List<Child>();
            children.Add(new Child(1, "Claudiu", "Tudor", "Cluj Napoca, str. 1 Decembrie, nr 2"));
            children.Add(new Child(2, "Alexandra", "Popa", "Cluj Napoca, str. Parang, nr 14"));

            //Create items
            var item = new List<Item>();
            item.Add(new Item(1, "Kinder egg"));
            item.Add(new Item(2, "Car"));
            item.Add(new Item(3, "Lego"));

            //Create letters



            Console.WriteLine("Let's help " + santa.Name + "!");
            foreach (var child in children)
            {
                Console.WriteLine(child.FirstName);
            }

            Question1();
            Question2();

        }

        static void Question1()
        {

        }

        static void Question2()
        {
            
        }
    }
}
