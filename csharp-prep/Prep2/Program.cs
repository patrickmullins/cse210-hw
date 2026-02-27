using System;
// Write a program that determines the letter grade for a course.

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade percentage? ");
        //intializing grade as a string to pass the int into a string to output the letter grade
        string grade = Console.ReadLine();
        // initializing grade number as an int for future grade processing
        int gradeNumber = int.Parse(grade);
        

        string letter = "";
        if (gradeNumber >= 93)
        {
            letter = "A";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: " + letter);
    }
}