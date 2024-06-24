public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void ListPrompt()
    {
        _prompts.Add("Best experience you had today.");
        _prompts.Add("Strongest emotion you felt today.");
        _prompts.Add("Anything out of the ordinary this day.");
        _prompts.Add("Something slightly different today.");
        _prompts.Add("A brief summary of your morning, afternoon, and evening.");
        _prompts.Add("Something you want to do again.");
        _prompts.Add("Things you did different today.");
        _prompts.Add("Something you learned today.");
        _prompts.Add("Unforgettable event you experienced today.");
        _prompts.Add("Things I tried to improve today.");
    }

    public string GetRandomPrompt()
    {
        string promptReturn;
        if (_prompts.Count != 0)
        {
            Random randomNumber = new Random();
            int pickNumber = randomNumber.Next(0, _prompts.Count - 1);

            promptReturn = _prompts[pickNumber];
            _prompts.RemoveAt(pickNumber);
        }
        else
        {
            promptReturn = "Anything else you have in mind for today?";
        }

        return promptReturn;
    }
}