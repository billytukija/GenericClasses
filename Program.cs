using System;
using System.Collections.Generic;

namespace GenericClasses
{

    class Program
    {
        static void Main(string[] args)
        {
            var names = new Stack<string>();

            names.Push("Billy");
            names.Push("Tukija");
            names.Push("Grazielly");


            var s2 = new Steack<int>();

            s2.Push(1);
            s2.Push(2);
            s2.Push(3);

            var product = new Steack<Product>();
            product.Push(new Product { Id = 1, Name = "Guarana", Description = "Sucré produit au Brésil, principalement en amazonie" });
            product.Push(new Product { Id = 2, Name = "Cowbell", Description = "Lait produit au Congo (Republique Democratique)" });
            product.Push(new Product { Id = 3, Name = "Fufu", Description = "Aliment d'origine africaine, consomé au Congo (Republique Democratique) et d'autres de la region " });

            foreach (var item in product.Itens)
            {
                if (item != null)
                {
                    Console.WriteLine("Id : " + item.Id + " - " + "Name : " + item.Name);
                    Console.WriteLine("Name : " + item.Description);
                    Console.WriteLine("--------------*******************************---------------------");
                }
            }

            Console.ReadLine();
        }
    }
}
