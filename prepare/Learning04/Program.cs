using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment01 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine($"{assignment01.GetSummary()}");

        MathAssignment assignment02 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine($"\n{assignment02.GetSummary()}");
        Console.WriteLine($"{assignment02.GetHomeworkList()}");

        WritingAssignment assignment03 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine($"\n{assignment03.GetSummary()}");
        Console.WriteLine($"{assignment03.GetWritingInformation()}");
    }
}