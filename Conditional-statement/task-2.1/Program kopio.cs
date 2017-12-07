using System;

namespace silmukka
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Ohjema laskee kertoma. Anna luku, jonka kertoma lasketaan");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            long f = 1;
            if
            {
                (i < 0)
            }
            else (Console.WriteLine("Luku on määrittelemätön");
            do
            {
                i = i + 1;
                f = f * i;
				Console.WriteLine($"{i}!={f}"); // 5!=120
            } while (i < number);

            Console.WriteLine($"Syotit {number}\n vastaus {f}"); // 5!=120
            Console.ReadKey();
        }
    }
}
