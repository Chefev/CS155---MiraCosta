/// Homework No.6 Exercise No.1
/// File Name: Main.cs
/// @author: Parker Verran
/// Date: Oct. 4th, 2024
///
/// Problem Statement: Create a counter class with various methods and objects and write a driver program to test it
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Initialize a new instance of the Counter class
/// 2. Provide options for the user to select via text input to test the Counter
/// 3. After each change reprint the information about the class for the user
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Main Class - Acts as the driver program allowing the user to test the class
/// Counter Class - Creates the class which holds all of the methods and objects

using Homework6_Part1;
using System;

namespace std;

class Driver
{
    static void Main(string[] args)
    {
        Counter counter = new Counter();
        Console.WriteLine("A new counter has been created");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine($"The value of the counter is currently {counter.get()}");
            Console.WriteLine("1) Reset Counter");
            Console.WriteLine("2) Increase Counter");
            Console.WriteLine("3) Decrease Counter");
            Console.WriteLine("4) Print Counter");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    counter.reset();
                    break;
                case "2":
                    counter.add();
                    break;
                case "3":
                    counter.subtract();
                    break;
                case "4":
                    counter.print();
                    break;
            }
        }
    }
}