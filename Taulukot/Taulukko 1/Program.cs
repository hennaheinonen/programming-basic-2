using System;

namespace taulukko1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 100 lukua väliltä 0-50 ja tallettaa ne taulukkoon.");

            // taulukon määrittely silmukan ulkopuolella
            int[] numbers=new int[100];
            Random rnd = new Random();
            int summa = 0;


            for (int i = 0; i < 100; i++) 
            {
                numbers [i] = rnd.Next(50);
                summa += numbers[i];

            }

			for (int i = 0; i < 100; i++)
			{
                Console.WriteLine($"{i+1}. {numbers[i]}");
			}
                 
            Console.WriteLine($"Lukujen summa on {summa} ja keskiarvo on {summa / 100.0}");
        }
    }
}
