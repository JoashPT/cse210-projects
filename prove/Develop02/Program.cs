using System;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DateTime today = DateTime.Now;
        Journal newRecords = new Journal();
        Journal oldRecords = new Journal();
        PromptGenerator prompts = new PromptGenerator();
        prompts.ListPrompt();
        string fileName;

        Console.WriteLine("Journal Program");
        string response = "";
        do
        {
            Console.WriteLine("Select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Read Logs");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");
            response = Console.ReadLine();

            switch (response) 
            {
                case "1":
                    string prompt = prompts.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    Console.Write("- ");

                    Entry userLog = new Entry();
                    userLog._entryText = Console.ReadLine();
                    userLog._date = today.ToShortDateString();
                    userLog._promptText = prompt;

                    newRecords.AddEntry(userLog);
                    break;
                
                case "2":
                    oldRecords.DisplayAll();
                    newRecords.DisplayAll();
                    break;

                case "3":
                    Console.Write("Please Enter the Journal File Name: ");
                    fileName = Console.ReadLine();

                    oldRecords.LoadFromFile(fileName);
                    break;

                case "4":
                    Console.Write("Please Enter the Journal File Name: ");
                    fileName = Console.ReadLine();
                    newRecords.SaveToFile(fileName);
                    break;

                case "5":
                    break;

                default:
                    Console.WriteLine("Please enter your choice inside the valid number range...");
                    break;
            }

        } while (response != "5");
    }
}