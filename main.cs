// Created by: Joanne Santhosh
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
      int age;

      Console.WriteLine("Please enter your age:");
      age = int.Parse(Console.ReadLine());
      if (age > 17) {
      Console.WriteLine("You are eligible to watch an R-rated movie.");  
      }
      else if (age > 13) {
      Console.WriteLine("You're eligible to watch a PG-13 movie."); 
      }
      else if (age > 5) {
      Console.WriteLine("You can see a G or PG movie.");
      }
      else {
      Console.WriteLine("You're too young to watch most things.");
      }
      Console.WriteLine("Done.");
    }
}