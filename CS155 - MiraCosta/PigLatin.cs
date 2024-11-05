/// Homework No.2
/// File Name: PigLatin.cs
/// @author: Parker Verran
/// Date:  September 1, 2024
///
/// Problem Statement: Develop a program to turn a user's full name into pig latin and print it to the console
/// 
/// 
/// Overall Plan:
/// 1) Create a new first name variable that equals the name minus the first letter, plus the first letter at the end, plus "ay"
/// 2) Repeat the above process for the last name
/// 3) Create a new string concatenating the first and last names
/// 4) Print the new pig latin name to the console

using System;
using System.Security.Cryptography.X509Certificates;

namespace std;

class PigLatin
{
    static void Main(string[] args)
    {
        //declare the name variables
        string first = "parker";
        string last = "verran";

        //convert the first name into pig latin
        string first_pig = (Char.ToUpper(first[1]) + first.Substring(2) + first[0] + "ay");
        //convert the last name into pig latin
        string last_pig = (Char.ToUpper(last[1]) + last.Substring(2) + last[0] + "ay");

        //concatenate the two strings into a finalized name
        string pig_latin_name = first_pig + " " + last_pig;
        //print the name to the console
        Console.WriteLine(pig_latin_name);
    }
}