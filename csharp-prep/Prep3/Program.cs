using System;
using System.Net;

string response;
int userNumber;
do
{
    Random randomNumber = new Random();
    int number = randomNumber.Next(1, 100);

    Console.WriteLine($"What is the magic number? {number}");
    int counter = 0;
    
    do
    {
        Console.Write($"What is your guess? ");
        string userGuess = Console.ReadLine();
        userNumber = int.Parse(userGuess);
        counter += 1;

        if (userNumber > number)
        {
            Console.WriteLine("Lower");
        }
        else if (userNumber < number)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed the number!");
            Console.WriteLine($"You have guessed {counter} times.");
        }
    } while (userNumber != number);

    Console.Write("Would you like to continue (yes/no)? ");
    response = Console.ReadLine();

} while (response == "yes");
Console.WriteLine("Thank you for playing!");
