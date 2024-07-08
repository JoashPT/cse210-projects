using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a number from the given options: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;

                case "2":
                    ReflectingActivity reflectingActivity = new  ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;

                case "4":
                    Console.WriteLine("Thank you for using this program!");
                    break;
                
                default:
                    Console.WriteLine("Please choose a number from the give options\n");
                    Console.Write("Press enter to continue: ");
                    Console.ReadLine();
                    break;
            }
        } while(userChoice != "4");
    }
}