using System;

public class EternalGoal : Goal
{
    public EternalGoal (string shortName, string description, int points) 
    : base (shortName, description, points)
    {
    }    
    public EternalGoal ()
    {
    }  

    public override void RecordEvent ()
    {  
    }  

    public override bool IsComplete ()
    {
        return false;
    }

    public override string GetStringRepresentation ()
    {
        return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}";
    }
}