using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGradeInput = Console.ReadLine();
        int userGradeNumber = int.Parse(userGradeInput);
        int finalDigit = userGradeNumber % 10;
        string letter = "";
        string sign = "";

        if (userGradeNumber >= 70)
        {
            Console.WriteLine("Congratulations on passing!");
            if (userGradeNumber >= 90)
            {
                letter = "A";
            }
            else if (userGradeNumber >= 80)
            {
                letter = "B";
            }
            else if (userGradeNumber >= 70)
            {
                letter = "C";
            }
        }
        else
        {
            Console.WriteLine("Never give up! Try again next time!");
            if (userGradeNumber >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
        }

        if (!(letter == "F"))
        {
            if (finalDigit >= 7 && letter != "A")
            {
                sign = "+";
            }
            else if (finalDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else
        {
            sign = "";
        }
        Console.WriteLine($"Your final grade evaluation is {letter}{sign}.");
    }
}