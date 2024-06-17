using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favNum = Console.ReadLine();
            int favNumConv = int.Parse(favNum);
            return favNumConv;
        }

        static int SquareNumber(int num)
        {
            return num * num;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squareNum = SquareNumber(userNum);
        DisplayResult(userName, squareNum);
    }
}