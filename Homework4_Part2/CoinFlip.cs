using System;
using System.Net.Sockets;

namespace std;

class CoinFlip
{
    static void Main(string[] args)
    {
        int num_flips = 0;
        string[] flips = new string[8];
        int heads = 0;
        int tails = 0;

        for (int i = 0; i < 8; i++)
        {
            num_flips++;

            string time = "";
            switch (i)
            {
                case 0:
                    time = "1st";
                    break;
                case 1:
                    time = "2nd";
                    break;
                case 2:
                    time = "3rd";
                    break;
                case 3:
                    time = "4th";
                    break;
                case 4:
                    time = "5th";
                    break;
                case 5:
                    time = "6th";
                    break;
                case 6:
                    time = "7th";
                    break;
                case 7:
                    time = "8th";
                    break;
            }

            Console.WriteLine($"{time} flip: ");
            flips[i] = Console.ReadLine();

            if (flips[i] == "h")
            {
                heads++;
            } else if (flips[i] == "t")
            {
                tails++;
            }
        }

        double percent_heads = Math.Round(Convert.ToDouble(heads) / num_flips, 2) * 100;
        double percent_tails = Math.Round(Convert.ToDouble(tails) / num_flips, 2) * 100;

        Console.WriteLine($"Number of heads: {heads}");
        Console.WriteLine($"Number of tails: {tails}");
        Console.WriteLine($"Percent of heads: {percent_heads}%");
        Console.WriteLine($"Percent of tails: {percent_tails}%");
    }
}