/// Homework No.7 Lab 1
/// File Name: Driver.cs
/// @author: Parker Verran
/// Date: Oct. 21st, 2024
///
/// Problem Statement: Create an pizza class to track information about a given pizza
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Initialize a new instance of the Pizza class
/// 2. Provide options for the user to select via text input to test the Pizza
/// 3. After each change reprint the information about the class for the user
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Driver Class - The driver program allows the user to test the class
/// Pizza Class - Creates the class which holds all of the methods and objects

using System;
using System.Diagnostics.Metrics;

namespace Homework7_Lab1;

class Driver
{
    static void Main(string[] args)
    {
        Pizza pizza = new Pizza();
        Console.WriteLine("A new pizza has been created");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("1) Print Pizza");
            Console.WriteLine("2) Change Cheese Toppings");
            Console.WriteLine("3) Change Pepperoni Toppings");
            Console.WriteLine("4) Change Ham Toppings");
            Console.WriteLine("5) Change Size");
            Console.WriteLine("6) Calculate Cost");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(pizza.ToString());
                    break;
                case "2":
                    Console.WriteLine("Cheese to add: ");
                    int cheese = Convert.ToInt32(Console.ReadLine());
                    pizza.Cheesenum = cheese;
                    break;
                case "3":
                    Console.WriteLine("Pepperoni to add: ");
                    int pepperoni = Convert.ToInt32(Console.ReadLine());
                    pizza.Pepperoninum = pepperoni;
                    break;
                case "4":
                    Console.WriteLine("Ham to add: ");
                    int ham = Convert.ToInt32(Console.ReadLine());
                    pizza.Hamnum = ham;
                    break;
                case "5":
                    Console.WriteLine("Size to change to: ");
                    string size = Console.ReadLine();
                    pizza.Size = size;
                    break;
                case "6":
                    Console.WriteLine($"The cost of the pizza is ${(pizza.CalculateCost()).ToString()}");
                    break;
            }
        }
    }
}