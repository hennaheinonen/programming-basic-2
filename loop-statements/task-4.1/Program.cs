using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Ohjelma tulostaa kokonaislukujen 1-10 neliöjuuret");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} {Math.Sqrt(i)}");
            }      

        }
    }
}
