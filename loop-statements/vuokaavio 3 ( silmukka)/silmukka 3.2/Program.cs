using System;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write( "Ohjelma laskee ensimmäistä lukua yhteen. Anna luku, jonka yhteenlasku lasketaan");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            long f = 0;
            if (number > 0)
            {
                do
                {
                    i = i + 1;
                    f = f + i;
                    //Console.WriteLine($"Luvun {number} yhteenlaskettu tulos on {f}");
                } while (i < number);
                Console.WriteLine("Syötit: " + number);
                Console.WriteLine($"Vastaus: {f}");
            }
            else
            {
                Console.WriteLine("Luku on määrittelemätön");
            }    




            Console.ReadKey();
        }
    }
}
