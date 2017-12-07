using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9.");
            int summa;

            for (int i = 1; i <= 9; i++)
            {
                for (int y = 1; y <= 9;y++)
                {
                    summa = i * y;
                    Console.WriteLine($"{i} * {y} = {summa} ");
                }    
            }

        }
    }
}
