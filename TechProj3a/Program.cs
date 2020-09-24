// Author: T. Jarrett Hopple
// Class: ISM 4300
// Assignment: Tech Project 3a
using System;

namespace TechProj3a
{
    class Program
    {
        static void Main(string[] args)
        {
            // when opened, program shows "Please enter your name"
            Console.WriteLine("Please enter your name. ");

            // allows user to type name in 
            string name;
            name = Console.ReadLine();
            // after typing in name, message appears as "Hello (Name typed)
            Console.WriteLine("\r\nHello " + name + " - Go Bulls");

            // ends and exits the program
            Console.WriteLine("\r\nPress any key to exit");
            Console.ReadKey(true);
        } // static end
    } // class end
} // namespace end

// This code never shows up when a publish it to github from VS
