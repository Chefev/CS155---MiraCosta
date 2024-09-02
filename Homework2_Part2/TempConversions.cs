/// Homework No. 2
/// File Name: TempConversions.cs
/// @author: Parker Verran
/// Date:  September 1, 2024
///
/// Problem Statement: Develop a program to convert degrees Fahrenheit to degrees Celsius
/// 
/// 
/// Overall Plan:
/// 1) Retrieve user input for the temperature in fahrenheit
/// 2) Convert this temperature to celsius using the formula C = 5(F - 32)/9
/// 3) Round this result to one decimal place
/// 4) Print the result to the console

namespace std;

using System;

class TempCoversions
{
    static void Main(string[] args)
    {
        //Get user input
        Console.WriteLine("Input a Whole Number Temperature in Degrees Fahrenheit: ");
        string input = Console.ReadLine();
        int degrees_F = Int32.Parse(input);

        //Convert fahrenheit to celsius
        double degrees_C = Math.Round((5 * (degrees_F - 32) / 9.0), 1);

        //Print the result to the console
        Console.WriteLine("\n{0} degrees Fahrenheit = {1} degrees Celsius", degrees_F, degrees_C);
    }
}