using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool repeat = true;
        do
        {
            Console.Write("Enter number: ");
            string userEntry = Console.ReadLine();
            int userNumber = int.Parse(userEntry);

            if (userNumber != 0)
            {
                numList.Add(userNumber);
            }
            else
            {
                repeat = false;
            }
        } while (repeat == true);

        int sum = 0;
        foreach (int num in numList)
        {
            sum += num;
        }

        int average = sum / numList.Count;

        int largest = numList.Max();

        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {largest}.");

        //Stretch Challenge
        List<int> posNum = new List<int>();
        foreach (int num in numList)
        {
            if (num > 0)
            {
                posNum.Add(num);
            }
            else
            {
                continue;
            }
        }

        int minPosNum = posNum.Min();
        Console.WriteLine($"The smallest positive number is {minPosNum}.");

        Console.WriteLine("The sorted list is:");
        numList.Sort();
        foreach (int num in numList)
        {
            Console.WriteLine(num);
        }
    }
}