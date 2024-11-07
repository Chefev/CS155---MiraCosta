/// Homework No.9 Lab 1
/// File Name: Program.cs
/// @author: Parker Verran
/// Date: Nov. 6, 2024
///
/// Problem Statement: Create a system of classes that simulate a document, email, and file using extended classes
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create 2 different emails and files
/// 2. Run them through the CheckKeyword method to see if there is a certain word in them
/// 3. Print the results for every single file to ensure that they work properly
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Program - Runs the main testing program for the classes
/// Document - Creates a class that holds information specific to a document
/// Email - Extends the document class and adds some more functionality
/// File - Also extends the document class and adds slightly different specialized functionality

using Homework9_Lab1;
using System;

namespace Homework9_Part1;

class Program
{
    static void Main(string[] args)
    {
        //create the class instances
        Email email1 = new Email("Parker", "Professor Aloka", "Hello", "This is just a message to say hi!");
        Email email2 = new Email("Bob", "Billy", "Transcript Request", "Hello, I need my transcript");
        Homework9_Lab1.File file1 = new Homework9_Lab1.File("//users//parker//desktop", "this is the first file on my computer");
        Homework9_Lab1.File file2 = new Homework9_Lab1.File("//users//parker//desktop//folder", "this is also the other file on my computer");

        Console.WriteLine($"Email 1:");
        Console.WriteLine(email1.ToString());
        Console.WriteLine($"Does email1 contain the word 'hi': {ContainsKeyword(email1, "hi")}");

        Console.WriteLine($"Email 2:");
        Console.WriteLine(email2.ToString());
        Console.WriteLine($"Does email2 contain the word 'hi': {ContainsKeyword(email2, "hi")}");

        Console.WriteLine($"File 1:");
        Console.WriteLine(file1.ToString());
        Console.WriteLine($"Does file1 contain the word 'file': {ContainsKeyword(file1, "file")}");

        Console.WriteLine($"File 2:");
        Console.WriteLine(file2.ToString());
        Console.WriteLine($"Does file2 contain the word 'file': {ContainsKeyword(file2, "file")}");
    }

    public static bool ContainsKeyword(Document docObject, string keyword)
    {
        if (docObject.ToString().IndexOf(keyword, 0) >= 0)
        {
            return true;
        }
        return false;
    }
}