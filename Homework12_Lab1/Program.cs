/// Homework No.12, Lab 1
/// File Name: Program.cs
/// @author: Parker Verran
/// Date: Nov. 20, 2024
///
/// Problem Statement: Create a class that has two methods and use them through a delegate
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create a new Rectnagular Prism delegate
/// 2. Add the volume function to it
/// 3. Add the perimeter function to it
/// 4. Call the delegate to run the two methods
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Program - Creates and calls the delegate as well as establishes the delegate and the methods

using System;

namespace Homework12_Lab1;

class Program
{
    public static void Main(string[] args)
    {
        //Create an instance of the object
        RectPrism prism = new RectPrism();
        //Establish the delegate
        RectPrism.RectPrismD rectprismdele = new RectPrism.RectPrismD(prism.area);
        rectprismdele += prism.perimeter;
        //Call the delegate
        rectprismdele(4, 5, 3);
    }

}
public class RectPrism
{
    //create the delegate method
    public delegate void RectPrismD(int a, int b, int c);

    public void area(int a, int b, int c)
    {
        Console.WriteLine($"The area of the rectangular prism is {a * b * c}");
    }

    public void perimeter(int a, int b, int c)
    {
        Console.WriteLine($"The perimeter of the rectangular prism is {4 * a + 4 * b + 4 * c}");
    }
}
