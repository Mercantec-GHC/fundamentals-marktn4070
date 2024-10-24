//_____ // C# program to illustrate the
//_____ // Capacity Property of List<T>
//_____ using System;
//_____ using System.Collections.Generic;
//_____ 
//_____ class Geeks
//_____ {
//_____ 
//_____     // Main Method
//_____     public static void Main(String[] args)
//_____     {
//_____ 
//_____         // Creating a List of integers
//_____         // Here we are not setting
//_____         // Capacity explicitly
//_____         List<int> firstlist = new List<int>();
//_____ 
//_____         // adding elements in firstlist
//_____         firstlist.Add(1);
//_____         firstlist.Add(2);
//_____         firstlist.Add(3);
//_____         firstlist.Add(4);
//_____ 
//_____         // Printing the Capacity of firstlist
//_____         Console.WriteLine("Capacity Is: " + firstlist.Capacity);
//_____ 
//_____         // Printing the Count of firstlist
//_____         Console.WriteLine("Count Is: " + firstlist.Count);
//_____ 
//_____         // Adding some more
//_____         // elements in firstlist
//_____         firstlist.Add(5);
//_____         firstlist.Add(6);
//_____ 
//_____         // Printing the Capacity of firstlist
//_____         // It will give output 8 as internally
//_____         // List is resized
//_____         Console.WriteLine("Capacity Is: " + firstlist.Capacity);
//_____ 
//_____         // Printing the Count of firstlist
//_____         Console.WriteLine("Count Is: " + firstlist.Count);
//_____     }
//_____ }
//_____ 

class Program
{
    static void Main()
    {
        Console.Clear();

        List<string> list = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Please enter a number");
            list.Add(Console.ReadLine()); // HERE !!
        }

    }
}