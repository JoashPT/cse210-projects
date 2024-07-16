public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {
        _bonus = bonus;
        _amountCompleted = 0;
        _target = target;
    }

    public ChecklistGoal(string name, string description, int points, int bonus, int amountCompleted, int target) : base(name, description, points)
    {
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        _target = target;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (IsComplete() == true)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string completion;
        if (IsComplete() == true)
        {
            completion = "X";
        }
        else
        {
            completion = " ";
        }
        
        return $"[{completion}] {_shortName}: {_description} -- Progress: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal~||~{_shortName}#^#{_description}#^#{_points}#^#{_bonus}#^#{_amountCompleted}#^#{_target}";;
    }
}