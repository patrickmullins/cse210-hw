using System;
using System.Diagnostics;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        // initializing numbers list
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num = -1;
        while(num != 0)
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }
            
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        
    }
}