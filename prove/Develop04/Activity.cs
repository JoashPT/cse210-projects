public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.Write($"Welcome to {_name} program. ");
        ShowSpinner(3);

        Console.Write($"\n\nThis activity will help you {_description}. ");
        ShowSpinner(5);

        Console.Write($"\n\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.Write("\n\nWell done!!! ");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed {_duration} seconds of {_name}.");
        ShowSpinner(3);
        Console.WriteLine("Press enter to continue.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerSymbol = new List<string>();
        spinnerSymbol.Add("|");
        spinnerSymbol.Add("/");
        spinnerSymbol.Add("-");
        spinnerSymbol.Add("\\");

        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string symbol = spinnerSymbol[i];
            Console.Write(symbol);
            Thread.Sleep(100);
            Console.Write("\b \b");
            
            i++;
            
            if (i >= spinnerSymbol.Count)
            {
                i = 0;
            }
        }

        Console.Write("\b \b"); 
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}