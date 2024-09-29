/// Homework No.5 Lab No.1
/// File Name: GuessingGame.cs
/// @author: Parker Verran
/// Date: Sept. 29, 2024
///
/// Problem Statement: Create a game where the user guesses a number between 0 and 100 getting hints on whether the number is high or lower throughout the game
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create a new Random class and generate the random number that represents the correct guess
/// 2. Create a guess variable and repeat until it is the same as the correct number
/// 3. Get user input from the console on what the current guess is
/// 4. If the guess is correct, print out the number of guesses it took
/// 5. Ig the guess is incorrect, tell the user whether they need to guess higher or lower
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Main Class - GuessingGame, it is the only class and holds the entire program in it

using System;

namespace std;

class GuessingGame
{
    static void Main(string[] args)
    {
        //get the random number to guess
        var generator = new Random();
        int answer = generator.Next(0, 101);
        int guess;
        int guessCount = 0;

        Console.WriteLine("Guess a number between 0 and 100:");

        //get the guess from the user
        guess = Convert.ToInt32(Console.ReadLine());
        guessCount++;

        //game loop
        while (guess != answer)
        {
            if (guess > answer)
            {
                Console.WriteLine("The corect number is lower than your previous guess. Try Again:");
            }
            else if (guess < answer)
            {
                Console.WriteLine("The corect number is higher than your previous guess. Try Again:");
            }

            //get the guess from the user
            guess = Convert.ToInt32(Console.ReadLine());
            guessCount++;
        }

        //tell the user their guess count
        Console.WriteLine($"You guessed the correct answer of {answer} after {guessCount} tries!");
    }
}