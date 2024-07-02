using System;

class Program
{
    static void Main(string[] args)
    {
        string filepath = "scriptureVerse.txt";
        string userAction;

        SourceFile sourceFile = new SourceFile(filepath);
        Reference reference = new Reference(sourceFile.GetLine());
        Scripture scripture = new Scripture(reference, reference.GetGospel());

        Console.WriteLine($"{scripture.GetDisplayText()}");
        
        do
        {
            Console.WriteLine("Press 'enter' to continue.");
            Console.WriteLine("Type 'show' to see the full verse.");
            Console.WriteLine("Type 'quit' to exit the program:");
            userAction = Console.ReadLine();

            switch (userAction)
            {
                case "":
                    scripture.HideRandomWords(3);
                    Console.WriteLine(scripture.GetDisplayText());
                    break;

                case "show":
                    Console.WriteLine(reference.GetOriginalText());
                    break;
                
                case "quit":
                    break;
                
                default:
                    Console.WriteLine("Please choose between the three options.");
                    break;
            }
        } while(scripture.IsCompletelyHIdden() == false && userAction != "quit");
    }
}