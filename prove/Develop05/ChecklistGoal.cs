using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string shortName, string description, int points) 
    : base (shortName, description, points)
    {
    }    
    public ChecklistGoal ()
    {
    }  
    public ChecklistGoal (int amountCompleted, int target, int bonus)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }  
    public ChecklistGoal (string shortName, string description, int points, int amountCompleted, int target, int bonus)
    : base (shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }  

    public override void RecordEvent ()
    {
        _amountCompleted += 1;
    }  

    public override bool IsComplete ()
    {
        bool iC = false;
        if (_amountCompleted >= _target)
        {
            iC = true;
        }
        return iC;
    }

    public override string GetDetailsString ()
    {
        if (_amountCompleted == _target)
        {
            return $"[x] {GetShortName()} ({GetDescription()}) -- Currently completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {GetShortName()} ({GetDescription()}) -- Currently completed {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation ()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }

    public override int GetBonus ()
    {
        if (_amountCompleted == _target)
        {
            return _bonus;
        }
        else 
        {
            return 0;
        }
    }
}