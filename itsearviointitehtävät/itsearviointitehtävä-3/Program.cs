using System;

namespace itsearviointitehtävä3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Syötä lukuja: ");

			int sum = 0;
			int number = 0;

			do
			{
				string userInput = Console.ReadLine();
				number = int.Parse(userInput);

				if (number != -1)
				{
					sum = sum + number;
				}
				else
				{
					break;
				}

			} while (true);

			Console.WriteLine($"Lukujen summa on {sum}.");

        }
    }
}
