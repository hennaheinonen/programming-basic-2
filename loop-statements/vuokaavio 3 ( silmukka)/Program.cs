using System;

namespace silmukka
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Éncoding.UTF8;
            Console.Write("Ohjema laskee kertoma. Anna luku, jonka kertoma lasketaan");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            long f = 1;
            if(number > 0)
            {
                
              do
                {
                    i = i + 1;
                    f = f * i;
                    //Console.WriteLine($"{i}!={f}"); // 5!=120
                } while (i < number);
                Console.WriteLine("Syötit: " + number);
                Console.WriteLine($"Vastaus: {f}");
            }
            else 
            {
                Console.WriteLine("Luku on määrittelematon");

            }    



            Console.ReadKey();
        }
    }
}
