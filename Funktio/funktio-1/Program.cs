using System;

namespace funktio1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Anna luku");
            int numStars = int.Parse(Console.ReadLine());

            Console.WriteLine($"{GetStars(numStars)}");
        }

        static string GetStars(int numStars)
        {
            string printStars = "";

            do
            {
                if (numStars <= 0)
                {
                    Console.WriteLine("Luku on virheellinen. Anna uusi luku.");
                    numStars = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }

            } while (true);

            for (int i = 0; i < numStars; i++)
            {
                printStars += "*"; 
            }
            return printStars;

        }
    }
}
