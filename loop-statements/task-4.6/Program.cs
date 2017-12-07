using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Ohjelma simuloi nopanheittoa");
			Random rnd = new Random();
			int sixCounter = 0;

			for (int i = 1; i <= 1000; i++)
			{
				int j = rnd.Next(1,7);

				if (j == 6)
				{
					sixCounter++;
				}
				Console.WriteLine($"{i}.\t{j}");
			}
			Console.WriteLine($"Kuutonen arvottiin {sixCounter} kertaa.");
			Console.ReadKey();
        }
    }
}
