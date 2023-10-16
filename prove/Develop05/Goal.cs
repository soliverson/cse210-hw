using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal (string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }    
    public Goal ()
    {
    }  

    public abstract void RecordEvent ();

    public abstract bool IsComplete ();

    public virtual string GetDetailsString ()
    {
        bool decide = IsComplete ();
        if (decide == true)
        {
            return $"[x] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public abstract string GetStringRepresentation ();

    public string GetShortName ()
    {
        return _shortName;
    }

    public string GetDescription ()
    {
        return _description;
    }

    public int GetPoints ()
    {
        return _points;
    }

    public virtual int GetBonus ()
    {
        return 0;
    }
}