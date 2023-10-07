using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration = 60;
    private string _prepMsg = "Get ready...";
    private string _doneMsg = "Well done!!";
    private string[] spinner = {"|", "/", "-", "\\"}; 

    public Activity(string name, string description)
    {
        SetName(name); 
        SetDescription(description);
    }

    public Activity()
    {
        _name = "Activity";
        _description = "Perform some activity, such as meditation.";
    }


    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void AskDuration()
    {
        int duration;

        Console.Write($"How long, in seconds, would you like for your session (default {_duration})? ");

        do
        {
            string temp = Console.ReadLine();

            if (temp == "")
            {
                duration = _duration;
            }
            else
            {
                Int32.TryParse(temp, out duration);
            }

            if (duration <= 0)
            {
                Console.Write("Please enter a valid number of seconds (positive integer). ");
            }

        } while (duration <= 0);

        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetPrepMsg(string prepMsg)
    {
        _prepMsg = prepMsg;
    }

    public string GetPrepMsg()
    {
        return _prepMsg;
    }

    public void SetDoneMsg(string doneMsg)
    {
        _doneMsg = doneMsg;
    }

    public string GetDoneMsg()
    {
        return _doneMsg;
    }

    public void PauseSpinner(int timer)
    {
        int index = 0; 

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timer);
        DateTime now = DateTime.Now;

        Console.Write("   ");

        while (now < endTime)
        {
            Console.Write($"\b\b\b   \b\b\b {spinner[index]} ");

            index = ++index % 4;

            Thread.Sleep(200);

            now = DateTime.Now;
        }

        Console.WriteLine("\b\b\b   \b\b\b");
    }

    public void DisplayOpening()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");

        AskDuration();

        Console.Clear();
        Console.WriteLine(_prepMsg);

        PauseSpinner(6);
    }

    public void DisplayClosing()
    {
        Console.WriteLine($"\n{_doneMsg}");
        Console.WriteLine($"\nYou have completed {GetDuration()} seconds of the {GetName()}.");

        PauseSpinner(6);
    }

    public int GetRandomListIndex(List<string> list)
    {
        Random rand = new Random();
        int index = rand.Next(list.Count);
        return index;
    }

    public void CountDown(int counter)
    {
        string clearString;
        string indexString; 

        for (int i = counter; i > 0; i--)
        {
            indexString = i.ToString();

            Console.Write(i);

            Thread.Sleep(1000);

            clearString = new string('\b', indexString.Length);
            clearString += new string(' ', indexString.Length);
            clearString += new string('\b', indexString.Length);

            Console.Write(clearString);
        }
    }
}