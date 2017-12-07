using System;

namespace merkkijono4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa onko käyttäjältä kysytty sana tai luku palintromi");
            Console.WriteLine("Syötä sana");

            string userInput = Console.ReadLine();
            string reverse = "";
            int i = userInput.Length;

            for (int j = i - 1; j >= 0; j--) 
            {
                reverse = reverse + userInput[j];
            }

            if (reverse == userInput) 
            {
                Console.WriteLine($"Sana {userInput} on palintromi");
            }
            else 
            {
                Console.WriteLine($"Sana {userInput} ei ole palintromi");
            }
        }
    }
}
