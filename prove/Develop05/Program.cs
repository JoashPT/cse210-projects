using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string userChoice;
        GoalManager goalManager = new GoalManager();
        
        do
        {
            goalManager.DisplayPlayerInfo();
            goalManager.Start();

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;

                case "2":
                    goalManager.ListGoalDetails();
                    break;

                case "3":
                    goalManager.ListGoalNames();
                    goalManager.RecordEvent();
                    break;

                case "4":
                    goalManager.SaveGoals();
                    break;
                
                case "5":
                    goalManager.LoadGoals();
                    break;
                
                case "6":
                    Console.WriteLine("Thank you for using this program!");
                    break;
                
                default:
                    Console.WriteLine("Please choose an option from 1 to 6.");
                    break;
            }
            Console.Write("\nYour input has been recorded. Press \"enter\" to continue.");
            Console.ReadLine();
            Console.Clear();

        } while (userChoice != "6");
        
    }
}