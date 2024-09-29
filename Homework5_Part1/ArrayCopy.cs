/// Homework No.5 Exercise No.1
/// File Name: ArrayCopy.cs
/// @author: Parker Verran
/// Date: Sept. 29, 2024
///
/// Problem Statement: Create an array and copy it to another array
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Initialize an array of size 10 and fill it with numbers 0-9
/// 2. Loop through every item in the array and print out the item
/// 3. Initialize a second array of the same size
/// 4. Loop through every item in the first array, and set the corresponding slot in the second array to the same value, essentially copying it
/// 5. Loop through the second array and print out every value
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Main Class - ArrayCopy, it runs the program through its Main() method

using System;

namespace std;

class ArrayCopy
{
    static void Main(string[] args)
    {
        //declare a new array and fill it with ten numbers
        int[] numbers = new int[10];
        Console.WriteLine("First Array:");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
            //print out the first array
            Console.WriteLine(numbers[i]);
        }

        //create second array and copy the first array into it
        int[] numbers2 = new int[numbers.Length];
        Console.WriteLine("");
        Console.WriteLine("Second Array:");

        for (int i = 0; i < numbers2.Length; i++)
        {
            numbers2[i] = numbers[i];
            //print out the second array
            Console.WriteLine(numbers2[i]);
        }
    }
}