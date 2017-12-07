using System;

namespace taulukko3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo kaksiulotteiseen kokonaisluku (koko 10,20) taulukkoon arvot 0-100.");
			Console.WriteLine("[X,Y] = Arvot");

            //taulukon määrittely (taulukon koko)
            int[,] numbers = new int[10, 20];
           
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 20; y++)
                {
                    numbers[i, y] = rnd.Next(0, 100);
                }
            }

            for (int i = 0; i < 20; i++) 
            {
                for (int y = 0; y < 20; y++) 
                {
                    Console.WriteLine($"[{i} , {y}] = {numbers[i,y]:00}");
                }
				
            }
          
        }
    }
}
