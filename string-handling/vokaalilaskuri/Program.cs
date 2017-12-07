using System;

namespace vokaalilaskuri
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syöttämästä tiedosta vokaalien lukumäärän");
            Console.WriteLine("Syötä sana");

            string userInput = Console.ReadLine();

            int count = 0;

            foreach ( char ch in userInput) 
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'y' || ch == 'ä' || ch == 'ö') 
                {
                    count++;
                }
            }

            Console.WriteLine($"Syötteessä oli {count} vokaalia.");
        }
    }
}
