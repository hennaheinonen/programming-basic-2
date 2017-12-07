using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0-50");

			Random rnd = new Random();

			for (int i = 1; i <= 4; i++)
			{
				Console.Write($"Rivi {i}: ");
				for (int y = 1; y <= 5; y++)
				{
					if (y < 5)
						Console.Write($"{rnd.Next(50)},");
					else
						Console.Write($"{rnd.Next(50)} \n");
				}
			}
			
        }
    }
}
