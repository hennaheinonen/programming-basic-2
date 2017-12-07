using System;
using System.Linq;

namespace taulukko2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lotto-ohjelma. Ohjelma arpoo 7 eri lukua (loton oikearivi), sekä lisänumeron ja tuplausnumeron väliltä 1-40 ja tulostaa luvut pienimmästä suurimpaan.");

            // taulukon määrittely 
            int[] numbers = new int[7];
            int rndExtraNumber = 0;
            string printLotteryNumbers = "";

            //Array lotto = numbers;
            Random rnd = new Random();

            for (int i = 0; i < 7; i++) 
            {
                int rndLottoNumber = rnd.Next(1,41);
                if (numbers.Contains(rndLottoNumber))  // tarkastaa olemassa olevista luvuista löytyykö lukua jo
                    i--;
                else 
                    numbers[i] = rndLottoNumber;

            }

            while (true) //ikisilmukka
            {
			    rndExtraNumber = rnd.Next(1, 41);
                if (!numbers.Contains(rndExtraNumber))  // tarkastaa olemassa olevista luvuista löytyykö lukua jo
                    break;
			}

            Array.Sort(numbers);

            // Lottonumeroiden tulostus muuttujaan
            for (int i = 0; i < 7;i++) 
            {
                printLotteryNumbers += $"{numbers[i]} ";   
            }

            Console.WriteLine($"Loton oikearivi on {printLotteryNumbers}");
            Console.WriteLine($"Lisänumeo on {rndExtraNumber}");
            Console.WriteLine($"Tuplaus numero on {rnd.Next(1,41)}");



        }

    }
}