/// Homework No.12, Exercise 1
/// File Name: Program.cs
/// @author: Parker Verran
/// Date: Nov. 20, 2024
///
/// Problem Statement: 
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create a list that holds people
/// 2. Add ten different people to this list
/// 3. Use a LINQ query to find people whose age is 12 and younger
/// 4. Print them out to the console
/// 5. Calculate the average height of all of the people
/// 6. Use a LINQ query to find the people whose height is more than the average
/// 7. Print these out to the console
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Program - Creates the list and runs the LINQ queries
/// Person - Establishes a class to represent a person with their name, age, and height
/// 

using System;
using System.Transactions;

namespace Homework12_Part1;

class Program
{
    public static void Main(string[] args)
    {
        //Create the ten people
        Person bob = new Person(16, "Bob", 5.9);
        Person jesse = new Person(27, "Jesse", 6.4);
        Person samantha = new Person(89, "Samantha", 5.3);
        Person aaron = new Person(10, "Aaron", 5.8);
        Person olivia = new Person(4, "Olivia", 5.5);
        Person hope = new Person(45, "Hope", 5.7);
        Person grace = new Person(36, "Grace", 4.9);
        Person parker = new Person(7, "Parker", 6.3);
        Person jeff = new Person(73, "Jeff", 6.0);
        Person lily = new Person(22, "Lily", 5.11);

        List<Person> people = new List<Person>()
        { 
            bob,
            jesse, 
            samantha, 
            aaron, 
            olivia, 
            hope, 
            grace, 
            parker, 
            jeff, 
            lily
        };

        //find all of those less than 12
        var kids_menu_results = from p in people where p.Age < 12 select p;
        //print them out to the console
        Console.WriteLine("These people are eligible for the kids menu:");
        foreach(var kid in kids_menu_results)
        {
            Console.WriteLine($"{kid.Name} is {kid.Age} years old with a height of {kid.Height} feet");
        }

        //calculate the average height
        double avg_height = 0;
        foreach(Person person in people)
        {
            avg_height += person.Height;
        }
        avg_height = avg_height / 10;

        //select people who are taller than the average
        var height_results = from p in people where p.Height > avg_height select p;
        //print them out to the console
        Console.WriteLine($"These people are taller than the average height of {avg_height} feet:");
        foreach (var person in height_results)
        {
            Console.WriteLine($"{person.Name} is {person.Age} years old with a height of {person.Height} feet");
        }
    }
}
