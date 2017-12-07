using System;

namespace Conditionalstatement
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Define instructions
            Console.WriteLine("Ohjemlma tulostaa positiivinen, negatiivinen tai nolla");
            bool isNumber;
            do
            {

                Console.WriteLine("Syötä luku: ");
                string userInput;
                userInput = Console.ReadLine();

                int.TryParse(userInput, out int evaluatedNumber);
                isNumber = int.TryParse(userInput, out evaluatedNumber);


                // program logic
                if (isNumber == true)
                {
                    if (evaluatedNumber < 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
                    }
                    else if (evaluatedNumber > 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on nolla");
                    }

                    Console.WriteLine($"Syötit arvon {userInput}");



            }

                else
                {
                    Console.WriteLine("Syötit muuta kuin numeroita");
                }
            } while (isNumber == true);
             Console.ReadKey();
        }
    }
}
