using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string shortName, string description, int points) 
    : base (shortName, description, points)
    {
    }    
    public SimpleGoal (string shortName, string description, int points, bool isComplete) 
    : base (shortName, description, points)
    {
        _isComplete = isComplete;
    }    
    public SimpleGoal ()
    {
    }  

    public override void RecordEvent ()
    {
        _isComplete = true;
    }  

    public override bool IsComplete ()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation ()
    {
        return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }
}