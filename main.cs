// Created by: Zaida Hammel
// Created on: April 2022
//
// This program accepts user input;

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double radius;
        double volume;
        //input
        Console.WriteLine("This program finds the volume of a sphere.");
        Console.WriteLine("");
        Console.WriteLine("Formula = 4/3 πr³");
        Console.WriteLine("");
        Console.Write("Enter the radius of the pyramid: ");
        radius = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        //process
        volume = (double)4 / 3 * Math.PI * Math.Pow(radius, 3);
        Console.Write("Volume of the sphere = " + volume.ToString("0.00"));
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}