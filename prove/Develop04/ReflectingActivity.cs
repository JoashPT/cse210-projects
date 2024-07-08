public class ReflectingActivity: Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "reflect on times of your life when you showed strength or resilience";

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get Ready...");
        ShowSpinner(3);

        Console.Write("\nConsider the following prompt:\n");
        ShowSpinner(3);

        DisplayPrompt();
        ShowSpinner(5);

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine($"\nNow ponder on each of the following questions as they relate to this "+
        @"experience");
        ShowSpinner(3);

        Console.Write("You may begin in: ");
        ShowCountDown(8);
        Console.Write("\n");

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            Thread.Sleep(100);
            ShowSpinner(6);
            Console.Write("\n");
        }
        DisplayEndingMessage();
        Console.ReadLine();
    }

    public string GetRandomPrompt()
    {
        Random randomNum = new Random();
        int pickNum = randomNum.Next(0, _prompts.Count - 1);

        string randomPrompt = _prompts[pickNum];
        _prompts.RemoveAt(pickNum);

        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        string randomQuery;

        if (_questions.Count - 1 > 0)
        {
            Random randomNum = new Random();
            int pickNum = randomNum.Next(0, _questions.Count - 1);

            randomQuery = _questions[pickNum];
            _questions.RemoveAt(pickNum);
        }
        else
        {
            randomQuery = "None left on the list";
        }
        return randomQuery;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}