using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi rahan heittoa");
            Random rnd = new Random();
            string UserInput = Console.ReadLine();
            int numero = int.Parse(UserInput);
            int kruuna = 0;
            int klaava = 0;

            Console.WriteLine($"Rahaa on heitetty {numero} kertaa");

            for (int i = 0; i < numero; i++)
            {
                if (rnd.Next(2) == 0)
                    kruuna++;
                else
                    klaava++;
            }    

            Console.WriteLine($"Klaavoja tuli {klaava} ja kruunia {kruuna}");

            Console.ReadKey();
        }   
    }
}
