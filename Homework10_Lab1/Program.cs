/// Homework No.10, Lab 1
/// File Name: Program.cs
/// @author: Parker Verran
/// Date: Nov. 12, 2024
///
/// Problem Statement: Create a program that represents a phone book and allow the user to lookup phone numbers
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. 
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Program - 
/// 

using System;

namespace Homework10_Lab1;

class Program
{
    public static void Main(string[] args)
    {
        //Create a phone book and add three numbers into it
        Phonebook book = new Phonebook();
        book.AddNumber("Bob", 7603458395);
        book.AddNumber("Mark", 6194573849);
        book.AddNumber("Parker", 7602394567);

        //create a loop for the user to choose what they want to do with the phonebook
        do
        {
            string name;
            long number;

            //Print the phone book
            Console.WriteLine();
            Console.WriteLine("Phonebook:");
            book.Print();
            //Prompt the user with the three options
            Console.WriteLine();
            Console.WriteLine("1) Add number 2) Remove number 3) Find number | Please enter your choice:");
            string choice = Console.ReadLine();

            //parse the input accordingly
            switch (choice)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Number:");
                    number = (long)Convert.ToDouble(Console.ReadLine());
                    book.AddNumber(name, number);
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Name:");
                    name = Console.ReadLine();        
                    book.RemoveNumber(name);
                    break;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine("Name:");
                    name = Console.ReadLine();
                    Console.WriteLine($"{name}'s phone number is {book.FindNumber(name)}");
                    break;
            }
        }
        while (true);
    }
}