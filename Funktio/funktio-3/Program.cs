using System;

namespace funktio3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkistaa luvun kelpoisuuden.");

            // funktion kutsu
            int retNumber = NumberFromRange(-5,20);
            Console.WriteLine($"Oikea luku lukualueelta on: {retNumber}");


        }

        static int NumberFromRange(int lowerBound, int upperBound)
        {
            while(true)
            {
				Console.WriteLine($"Anna luku väliltä {lowerBound} - {upperBound}");
				string userInput = Console.ReadLine();
				bool isNumber = int.TryParse(userInput, out int userNumber);

                if (!isNumber)
                    Console.WriteLine("Väärä syöte!");

				  else if (userNumber > lowerBound && userNumber < upperBound)
					return userNumber;
				else
					Console.WriteLine("Luku ei ole lukualueella!");
			}
		}
    }
}
