using System;

namespace funktio4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int maxIndex = 0;
			Console.WriteLine($"Suurin luku oli {numbers(ref maxIndex)} ja se oli {maxIndex}. syöte");
			Console.ReadKey();



		}
		static int numbers(ref int xxx)
		{
			int number = 0;
			int max = 0;

			bool isNumber;
			string output = "";
			Console.WriteLine("Syötä 10 positiivista kokonaislukua. Ohjelma palauttaa niistä suurimman");
			for (int i = 0; i < 10; i++)
			{
				Console.Write($"{i + 1}. ");
				isNumber = int.TryParse(Console.ReadLine(), out number);
				if (isNumber && number > 0)
				{
                    output += $"{number} "; // luodaan palaute esim 5 10 7 22 6 5 10 8 3 2
					if (max < number)
					{
						max = number;
						xxx = i + 1;
					}
				}
				else
				{
					Console.WriteLine("Väärä syöte, syötä positiivinen luku!");
					i--;
				}


			}
            Console.WriteLine($"Syötit seuraavat luvut:\n{output}\n");
			return max;
		}

    }
}
