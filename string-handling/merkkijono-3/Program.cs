using System;

namespace merkkijono3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syöttämästä syötteestä L-kirjainten lukumäärän");
            Console.WriteLine("Syötä sana tai lause");

            string userInput = Console.ReadLine();

            int count = 0;

            foreach (char ch in userInput) 
            {
                if (ch == 'l' || ch == 'L')
                {
                    count++;
                }
            }

            Console.WriteLine($"Syötteessä oli L-kirjaimia {count} määrä.");


        }
    }
}
