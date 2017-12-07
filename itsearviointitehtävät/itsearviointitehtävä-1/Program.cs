using System;

namespace itsearviointitehtävä1
{


    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy käyttäjältä sanan tai lauseen ja tulostaa sen 5 kertaa näytölle");
            Console.Write("Syötä sana: ");
            string userInput = Console.ReadLine();


            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }

        }
    }
}