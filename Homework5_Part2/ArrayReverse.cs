/// Homework No.5 Exercise No.2
/// File Name: ArrayReverse.cs
/// @author: Parker Verran
/// Date: Sept. 29, 2024
///
/// Problem Statement: Generate an array filled with random integers, and then reverse the array
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Initialize an integer array of size 10 and fill it with random numbers from 0-99
/// 2. Print out the original array by looping through each item and printing it
/// 3. Reset the array to its reversed version by assigning each item in the array to a new output array in reverse order
/// 4. Loop through this new reversed array and print every item out again
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Main Class - ArrayReverse, holds the entirety of the program including all three methods

using System;
using System.Globalization;

namespace std;

class ArrayReverse
{
    static void Main(string[] args)
    {
        //get an array with 10 random numbers
        int[] numbers = GenerateNumArray();
        //print the original array
        Console.WriteLine("Original Array:");
        PrintNumbers(numbers);
        //flip the entire array around
        numbers = Reverse(numbers);
        //print out all of the numbers that are now reversed
        Console.WriteLine("Reversed Array:");
        PrintNumbers(numbers);
    }

    static int[] GenerateNumArray()
    {
        //create a random number generator
        var generator = new Random();

        //for every position in the array fill it with a random number
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = generator.Next(0, 100);
        }

        return array;
    }

    static void PrintNumbers(int[] nums)
    {
        //print every item i nthe array
        foreach (int num in nums)
        {
            Console.WriteLine($"{num}");
        }
    }

    static int[] Reverse(int[] array)
    {
        //initialize an empty array
        int[] output = new int[array.Length];

        //for every item in the input array, swap its position in the output array
        for (int i = 0; i < array.Length; i++)
        {
            output[i] = array[(array.Length - 1) - i];
        }

        return output;
    }
}