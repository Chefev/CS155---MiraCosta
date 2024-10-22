/// Homework No.7 Exercise No.1
/// File Name: Main.cs
/// @author: Parker Verran
/// Date: Oct. 21st, 2024
///
/// Problem Statement: Create an odometer class to track fuel usage and miles per gallon
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Initialize a new instance of the Odometer class
/// 2. Provide options for the user to select via text input to test the Odometer
/// 3. After each change reprint the information about the class for the user
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Driver Class - The driver program allows the user to test the class
/// Odometer Class - Creates the class which holds all of the methods and objects

using System;
using System.Diagnostics.Metrics;

namespace Homework7_Part1;

class Driver
{
    static void Main(string[] args)
    {
        Odometer odometer = new Odometer();
        Console.WriteLine("A new odometer has been created");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("1) Reset miles and fuel");
            Console.WriteLine("2) Increase miles and fuel");
            Console.WriteLine("3) Print miles per gallon");
            Console.WriteLine("4) Print miles and fuel");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    odometer.reset();
                    break;
                case "2":
                    Console.WriteLine("Miles to add: ");
                    int miles = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fuel to add: ");
                    int fuel = Convert.ToInt32(Console.ReadLine());
                    odometer.add(miles, fuel);
                    break;
                case "3":
                    Console.WriteLine($"Current MPG is {odometer.getMPG()}");
                    break;
                case "4":
                    Console.WriteLine($"Current miles: {odometer.getMiles()}, current fuel: {odometer.getFuel()} gallons");
                    break;
            }
        }
    }
}