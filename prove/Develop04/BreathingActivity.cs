public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "relax as you breathe in and out for a period of time. Clear your mind as you focus on your breathing";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get Ready...");
        ShowSpinner(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in... ");
            Thread.Sleep(500);
            ShowCountDown(4);

            Console.Write("\nBreathe out... ");
            Thread.Sleep(500);
            ShowCountDown(6);
        }
        DisplayEndingMessage();
        Console.ReadLine();
    }
}