public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "list the good things in certain areas of your life";

        _prompts.Add("Who are people that appreciate you?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }


    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);

        Console.WriteLine("List as many responses you can to the following prompt:");
        ShowSpinner(3);

        GetRandomPrompt();
        ShowSpinner(5);

        Console.Write("You may begin in: ");
        ShowCountDown(8);
        Console.Write("\n");

        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
        Console.ReadLine();
    }

    public void GetRandomPrompt()
    {
        Random randomNum = new Random();
        int pickNum = randomNum.Next(0, _prompts.Count - 1);

        string randomPrompt = _prompts[pickNum];
        _prompts.RemoveAt(pickNum);

        Console.WriteLine($" --- {randomPrompt} --- ");
    }

    public List<string> GetListFromUser()
    {
        List<string> userEntryList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userEntry = Console.ReadLine();
            userEntryList.Add(userEntry);
        }

        return userEntryList;
    }
}