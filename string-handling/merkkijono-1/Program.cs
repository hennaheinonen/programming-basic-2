using System;

namespace merkkijono1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma ilmoittaa syötetystä syötteestä merkkien lukumäärän.");
            Console.WriteLine("Syötä sana tai lause");

            string userInput = Console.ReadLine();

            Console.WriteLine($"Syötteessä oli {userInput.Length} merkkiä.");
        }
    }
}
