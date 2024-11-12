/// Homework No.10, Exercise 1
/// File Name: Program.cs
/// @author: Parker Verran
/// Date: Nov. 12, 2024
///
/// Problem Statement: Rewrite an existing program in order to make better use of the ideas of inheritance
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create a couple of instances of aliens
/// 2. Create an alienpack and put them together
/// 3. Print out the aliens name and health
/// 4. Calculate the damage that they do total
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Program - Holds the main program which tests the code
/// Alien - Base class for the rest of the aliens
/// AlienPack - Defines interactions when multiple Aliens come together
/// MarshmallowManAlien - Is an extension of the Alien 
/// SnakeAlien - Extension of the Alien with different damage
/// OgreAlien - Extension of regular alien adding damage functionality
using System;

namespace Homework10_Part1;

class Program
{
    public static void Main(string[] args)
    {
        //create aliens
        MarshmallowManAlien bob = new MarshmallowManAlien(100, "Bob");
        SnakeAlien jim = new SnakeAlien(75, "Jim");
        OgreAlien tim = new OgreAlien(90, "Tim");

        //create alien pack and put the aliens into it
        AlienPack pack1 = new AlienPack(3);
        pack1.AddAlien(bob, 0);
        pack1.AddAlien(jim, 1);
        pack1.AddAlien(tim, 2);

        //Print the aliens name and health
        Alien[] aliens = pack1.GetAliens();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"This aliens name is {aliens[i].Name} and has {aliens[i].Health} health");
        }

        //Calculate the damage and print it
        Console.WriteLine($"This alien pack can do combined damage of {pack1.CalculateDamage()}");
    }
}