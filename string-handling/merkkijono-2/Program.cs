using System;

namespace merkkijono2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa syötteestä k-kirjaimet @-merkiksi");
            Console.WriteLine("Syötä sana tai lause");

            string userInput = Console.ReadLine();

            userInput = userInput.Replace("e", "@");

            Console.WriteLine($"{userInput}");
        }
    }
}
