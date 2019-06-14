using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{

    public class Steack<T>
    {
        int Pos = 0;
        public T[] Itens = new T[50];

        public void Push(T item)
        {
            Itens[Pos] = item;
            Pos++;
        }

        public Object Pop()
        {
            Pos--;
            return Itens[Pos];
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Steack<string>();
            s1.Push("Billy");
            s1.Push("Tukija");
            s1.Push("Richard");

            var s2 = new Steack<int>();
            s2.Push(1);
            s2.Push(2);
            s2.Push(3);

            var s3 = new Steack<Product>();
            s3.Push(new Product { Id = 1, Name = "Guaraná", Description = "Bla bla" });
            s3.Push(new Product { Id = 2, Name = "Cowbell", Description = "Bla bla" });
            s3.Push(new Product { Id = 3, Name = "Soja", Description = "Bla bla" });

            foreach (var item in s3.Itens)
            {
                if (item != null)
                    Console.WriteLine("Id : " + item.Id + " - " + "Name : " + item.Name);
            }

            Console.ReadLine();
        }
    }
}
