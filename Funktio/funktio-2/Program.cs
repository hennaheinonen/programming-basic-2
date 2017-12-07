using System;

namespace funktio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma palauttaa arvonaan kahdesta annetusta luvusta pienemmän.");
            Console.WriteLine("Anna luku 1.");

            string userInput = Console.ReadLine();
            // funktion esittely
            int x= int.Parse(userInput);
			Console.WriteLine("Anna luku 2.");
            userInput = Console.ReadLine();
            int y=int.Parse(userInput);

			// funktion kutsu
			int smallerNumber = Minimi(x,y);

               

            
           

            Console.WriteLine($"Pienempi luku on {smallerNumber}");

            // itse funktio
        }
        static int Minimi(int a, int b) 
        {
            if (a < b)
                return a;
            else
                return b;
        }
    }
}
