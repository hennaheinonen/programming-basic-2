using System;

namespace taulukko3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo yksiulotteiseen kokonaisluku (koko 10) taulukkoon arvot 0-20");

            //taulukon määrittely

            int[] numbers = new int[10];
            int rndNumber = 0;
            Console.WriteLine("[X] = Arvo");

            Random rnd = new Random();

            for (int i = 0; i < 10; i++) 
            {
                rndNumber = rnd.Next(0,20);
                if(rndNumber < 10)
                {
                    numbers[i] = rndNumber;
                    Console.WriteLine($"[{i}] = 0{numbers[i]}");
                }
                else
                {
                    numbers[i] = rndNumber;
                    Console.WriteLine($"[{i}] = {numbers[i]}");
                }

            }


        }
    }
}
