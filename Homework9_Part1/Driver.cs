/// Homework No.9 Exercise No.1
/// File Name: Driver.cs
/// @author: Parker Verran
/// Date: Nov. 5, 2024
///
/// Problem Statement: 
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Initialize a new instance of the Truck and Vehicle class
/// 2. Test the equals method for all of the different objects and print the results
/// 3. Test the ToString method and print the results
///
/// Classes needed and Purpose (Input, Processing, Output)
/// Driver - This program runs all of the main code and tests all methods and fields that were created
/// Vehicle - Creates a class that represents different types of vehicles holding infomration about them
/// Truck - Extends the vehicle class by adding some more specific information to it
/// 

using System;

namespace Homework9_Part1;

class Driver
{
    static void Main(string[] args)
    {
        Person bill = new Person("Bill");
        Person charlie = new Person("Charlie");
        Vehicle vehicle = new Vehicle(Vehicle.Manufacturers.Lexus, 6, bill);
        Vehicle vehicle2 = new Vehicle(Vehicle.Manufacturers.Toyota, 4, charlie);
        Truck truck = new Truck(Vehicle.Manufacturers.Ford, 8, charlie, 54.5, 40);
        Truck truck2 = new Truck(Vehicle.Manufacturers.Ram, 6, bill, 70, 90);

        Console.WriteLine($"Bill's vehicle: {vehicle.ToString()}");
        Console.WriteLine($"Bill's Truck: {truck2.ToString()}");
        Console.WriteLine($"Charlie's vehicle: {vehicle2.ToString()}");
        Console.WriteLine($"Charlie's truck: {truck.ToString()}");
        Console.WriteLine($"Is Bill's vehicle the same as Charlie's vehicle: {vehicle.Equals(vehicle2).ToString()}");
        Console.WriteLine($"Is Charlie's truck the same as Charlie's truck: {truck.Equals(truck2).ToString()}");
    }
}