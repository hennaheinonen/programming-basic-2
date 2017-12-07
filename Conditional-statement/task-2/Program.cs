using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Define instructions
            Console.WriteLine("Ohjelma selvittää onko syötetty luku pariton vai parillinen");
            bool isNumber;
            do
            {
                Console.WriteLine("Syötä luku: ");
                string userInput;
                userInput = Console.ReadLine();

                int.TryParse(userInput, out int evaluatedNumber);
                isNumber = int.TryParse(userInput, out evaluatedNumber);


                // program logic
                if (evaluatedNumber % 2 == 0)
                {
                    Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on parillinen");
                }
                else
                {
                    Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton");
                }

            } while (isNumber == false);
            Console.ReadKey();
    }
    }
}



    

