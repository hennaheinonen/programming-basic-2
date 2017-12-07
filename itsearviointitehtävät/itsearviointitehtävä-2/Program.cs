using System;

namespace itsearviointitehtävä2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy käyttäjältä sanan tai lauseen ja tulostaa sen niin monta kertaa näytölle kuin sanassa on kirjaimia.");
            Console.WriteLine("Söytä sana tai lause");

            string userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++) 
            {
                Console.WriteLine($"{i}. {userInput}");
            }
        }
    }
}
