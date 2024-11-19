/// Homework No.10, Lab 1
/// File Name: Program.cs
/// @author: Parker Verran
/// Date: Nov. 12, 2024
///
/// Problem Statement: Read text from input files into a dictionary for further processing, then allow the user to look up names and how popular they are
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Open a SteamReader
/// 2. Parse each line from the files into a dictionary of separate boys and girls names with the values being their rank or popularity
/// 3. Get user input on what name they want to look up
/// 4. Search the dictionary for that name and its popularity
/// 5. Print out this info to the user
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Program - Runs almost the entirety of the program, including the main loop for user input
/// Rank - Holds a name's rank and use count in one object
/// 

using System;

namespace Homework11_Part1;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, Rank> boys_names = new Dictionary<string, Rank>();
        Dictionary<string, Rank> girls_names = new Dictionary<string, Rank>();

        //parse the boys names
        using (StreamReader sr = new StreamReader("C:\\Users\\parke\\Desktop\\School\\MiraCosta Fall 2024 - CS155\\CS155 - MiraCosta\\Homework11_Part1\\boynames.txt"))
        {
            int counter = 0;
            string line = null;
            char[] delimiters = { ' ' };

            while ((line = sr.ReadLine()) != null)
            {
                counter++;
                string[] line_data = line.Split(delimiters);
                Rank ranking = new Rank(line_data[1], counter);
                boys_names.Add(line_data[0], ranking);
            }
        }

        //parse the girls names
        using (StreamReader sr = new StreamReader("C:\\Users\\parke\\Desktop\\School\\MiraCosta Fall 2024 - CS155\\CS155 - MiraCosta\\Homework11_Part1\\girlnames.txt"))
        {
            int counter = 0;
            string line = null;
            char[] delimiters = { ' ' };

            while ((line = sr.ReadLine()) != null)
            {
                counter++;
                string[] line_data = line.Split(delimiters);
                Rank ranking = new Rank(line_data[1], counter);
                girls_names.Add(line_data[0], ranking);
            }
        }

        //loop to ask user for input
        while (true)
        {
            Console.WriteLine("What name do you want to search for?");
            string name = Console.ReadLine();
            Console.WriteLine();

            //search for the name in the boys dictionary
            if (boys_names.ContainsKey(name))
            {
                Console.WriteLine($"{name} is the {Convert.ToString(boys_names[name].Ranking)} most popular name with {boys_names[name].Count} uses");
            }
            else
            {
                Console.WriteLine("This name was not one of the most popular boys names in the US in 2003");
            }

            //search for the name in the girls dictionary
            if (girls_names.ContainsKey(name))
            {
                Console.WriteLine($"{name} is the {Convert.ToString(girls_names[name].Ranking)} most popular name with {girls_names[name].Count} uses");
            }
            else
            {
                Console.WriteLine("This name was not one of the most popular girls names in the US in 2003");
            }

            Console.WriteLine();
        }
    }
}