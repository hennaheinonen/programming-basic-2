using System;

namespace taulukko3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma määrittelee kolme kokonaislukutaulukkoa, joista jokaisessa on 10 kokonaislukua.");
            int size = 10;
            //taulukon määrittely (taulukon koko)
            int[] arrT_1 = new int[size];
            int[] arrT_2 = new int[size];
            int[] arrT_3 = new int[size];

            Random rnd = new Random();

            for (int i = 0; i < size;i++)
            {
                arrT_1[i] = rnd.Next(50);
                arrT_2[i] = rnd.Next(50);

                //Console.WriteLine($"[{i}] = {arrT_1[i]:00}");
            }
            for (int i = 0; i < size; i++)
            {
                if (arrT_1[i] < arrT_2[i]) 
                {
                    arrT_3[i] = arrT_2[i];
                }
                else 
                {
                    arrT_3[i] = arrT_1[i];
                }

               // Console.WriteLine($"[{i}] = {arrT_2[i]:00}");
            }
            Console.WriteLine("        01 02 03 04 05 06 07 08 09 10");
            Console.WriteLine("        -----------------------------");
            Console.WriteLine($"arr1_1: {MakePrint(arrT_1)}");
            Console.WriteLine($"arr1_2: {MakePrint(arrT_2)}");
            Console.WriteLine($"arr1_3: {MakePrint(arrT_3)}");

                
        }
        public static string MakePrint (int []arrPrint) 
        {
            string outPut = "";

            for (int i = 0; i < arrPrint.Length; i++)
            {
                outPut += $"{arrPrint[i]:00} ";
            }
            return outPut;
        }
    }
}
