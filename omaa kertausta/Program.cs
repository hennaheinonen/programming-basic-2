using System;

namespace task1kertaus
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla");
            Console.WriteLine("Syötä luku: ");

            int x = int.Parse(Console.ReadLine()); 

            if (x > 0)
            {
                Console.WriteLine($"Luku {x} on positiivinen");
            }
            else if (x < 0)
            {
                Console.WriteLine($"Luku {x} on negatiivinen");
            }
            else 
            {
                Console.WriteLine($"Luku {x} on nolla");
            }
        } 
    }
}
