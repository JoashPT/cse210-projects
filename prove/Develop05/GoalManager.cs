using System.ComponentModel;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        Console.WriteLine($"\nMenu Options:");

        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Quit");

        Console.Write("\nSelect a Choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        int i = 0;
        Console.WriteLine("Your unfinished goals are:");
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete() == false)
            {
                i++;
                Console.WriteLine($"{i}. {goal.GetName()}");
            }
        }
    }

    public void ListGoalDetails()
    {
        int i = 0;
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
        }

        if (_goals.Count == 0)
        {
            Console.WriteLine("The current goals list is empty.");
        }
    }

    public void CreateGoal()
    {
        string name;
        string description;
        int points;
        int target;
        int bonus;

        Console.WriteLine("Choose a type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Type something different to exit selection:");
        Console.Write("Please choose a goal: ");

        string userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                Console.Write("\nCreate a name for this goal: ");
                name = Console.ReadLine();

                Console.Write("\nDescribe this goal: ");
                description = Console.ReadLine();

                Console.Write("\nHow many points would you like to alot for the completion of this goal: ");
                points = int.Parse(Console.ReadLine());

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);

                break;

            case "2":
                Console.Write("\nCreate a name for this goal: ");
                name = Console.ReadLine();

                Console.Write("\nDescribe this goal: ");
                description = Console.ReadLine();

                Console.Write("\nHow many points would you like to alot everytime this goal is done: ");
                points = int.Parse(Console.ReadLine());

                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);

                break;

            case "3":
                Console.Write("\nCreate a name for this goal: ");
                name = Console.ReadLine();

                Console.Write("\nDescribe this goal: ");
                description = Console.ReadLine();

                Console.Write("\nHow many points would you like to alot everytime this goal is done: ");
                points = int.Parse(Console.ReadLine());

                Console.Write("\nHow many times would you like to do this goal before being comleted: ");
                target = int.Parse(Console.ReadLine());

                Console.Write("\nHow many points would you like to alot for the completion of this goal: ");
                bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, target);
                _goals.Add(checklistGoal);

                break;
            
            default:
                Console.WriteLine("Please enter a number from 1 to 3");
                break;
        }
    }

    public void RecordEvent()
    {
        List<Goal> unfinishedGoal = new List<Goal>();
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete() == false)
            {
                unfinishedGoal.Add(goal);
            }
        }

        if (unfinishedGoal.Count != 0)
        {
            Console.Write("\nWhich goal did you accomplish? ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice <= unfinishedGoal.Count && userChoice > 0)
            {
                int gainedScore = unfinishedGoal[userChoice - 1].RecordEvent();
                Console.WriteLine($"You have gained {gainedScore} points!");

                _score += gainedScore;
            }
            else
            {
                Console.WriteLine("Please enter a number inside the range");
            }
        }
        else
        {
            Console.WriteLine("There are no unfinished goals, please create a goal or load a goal from a file.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("\nEnter the filename you wish to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nEnter the filename you wish to load from: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        _score += int.Parse(lines[0]);

        for (int i = 1; i < lines.Count(); i++)
        {
            string[] parts = lines[i].Split("~||~");

            string goalType = parts[0];
            string[] goalDetails = parts[1].Split("#^#");

            string name = goalDetails[0];
            string description = goalDetails[1];
            int points = int.Parse(goalDetails[2]);

            switch (goalType)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(goalDetails[3]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isComplete);
                    _goals.Add(simpleGoal);
                    break;
                
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;

                case "ChecklistGoal":
                    int bonus = int.Parse(goalDetails[3]);
                    int amountCompleted = int.Parse(goalDetails[4]);
                    int target = int.Parse(goalDetails[5]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, amountCompleted, target);
                    _goals.Add(checklistGoal);
                    break;
            }
        }
    }
}