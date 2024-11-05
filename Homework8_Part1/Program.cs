/// Homework No.8 Exercise No.1
/// File Name: Main.cs
/// @author: Parker Verran
/// Date: Nov. 4, 2024
///
/// Problem Statement: Simulate duels between different duelists wo have different probabilities of being able to hit their targets. Determine who is the most likely to win these duels
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Initialize the duelists and set up their corresponding shooting probabilities
/// 2. Loop 10,000 times: Have the duelists shoot in turns to see who gets eliminated
/// 3. Count the number of times that each duelists wins and print the probability
/// 4. Repeat steps 2-3 with the pdated strategy of Aaron purposefully missing the first shot
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Program - Contains the code to run the duels and process the resulting information from them
/// Duelist - Creates the duelist object and the associated information and methods
/// 

using System;

namespace Homework8_Part1;

class Program
{
    static void Main(string[] args)
    {
        //Duel 10,000 times and record the number of wins for each person
        int cycles = 10000;
        int aaron_wins = 0;
        int bob_wins = 0;
        int charlie_wins = 0;

        Duelist aaron = new Duelist("Aaron", 0.333);
        Duelist bob = new Duelist("Bob", 0.5);
        Duelist charlie = new Duelist("Charlie", 0.995);
        Duelist[] order = [aaron, bob, charlie]; 

        for (int i = 0; i < cycles; i++)
        {
            Duelist winner = Duel(order, i);
            if (winner == aaron)
            {
                aaron_wins++;
            }
            else if (winner == bob)
            {
                bob_wins++;
            }
            else if (winner == charlie)
            {
                charlie_wins++;
            }
        }

        double aaron_percentage = (aaron_wins / Convert.ToDouble(cycles)) * 100;
        double bob_percentage = (bob_wins / Convert.ToDouble(cycles)) * 100;
        double charlie_percentage = (charlie_wins / Convert.ToDouble(cycles)) * 100;

        Console.WriteLine($"{cycles.ToString()} duels were run with Aaron's special strategy, here are the results:");
        Console.WriteLine($"Aaron won {aaron_wins.ToString()}/10000 times for a probability of {aaron_percentage.ToString()}%");
        Console.WriteLine($"Bob won {bob_wins.ToString()}/10000 times for a probability of {bob_percentage.ToString()}%");
        Console.WriteLine($"Charlie won {charlie_wins.ToString()}/10000 times for a probability of {charlie_percentage.ToString()}%");
    }

    //Duel method to simulate a duel  between the duelists
    public static Duelist Duel(Duelist[] order, int duel_num)
    {
        //reset lives
        for (int p = 0; p < 3; p++)
        {
            order[p].Alive = true;
        }

        int num_alive = 0;
        for (int k = 0; k < 3; k++)
        {
            if (order[k].Alive == true)
            {
                num_alive++;
            }
        }

        while (num_alive > 1)
        {
            for (int i = 0; i < 3; i++)
            {
                if (order[i].Alive == true)
                {
                    if (duel_num == 0 && i == 0)
                    {
                        continue;
                    }
                    else
                    {
                        int target = 0;
                        double highest_accuracy = 0;
                        for (int j = 0; j < 3; j++)
                        {
                            if (order[j].Accuracy > highest_accuracy && order[j] != order[i] && order[j].Alive == true)
                            {
                                highest_accuracy = order[j].Accuracy;
                                target = j;
                            }
                        }

                        order[i].ShootAtTarget(order[target]);
                    }
                }
            }

            num_alive = 0;
            for (int m = 0; m < 3; m++)
            {
                if (order[m].Alive == true)
                {
                    num_alive++;
                }
            }
        }

        Duelist winner = null;
        for (int l = 0; l < 3; l++)
        {
            if (order[l].Alive == true)
            {
                winner = order[l];
            }
        }
        return winner;
    }
}