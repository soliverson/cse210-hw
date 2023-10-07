public class BreathingActivity : Activity
{
    private string _breatheInMsg = "Breathe in...";
    private string _breatheOutMsg = "Now breathe out...";
    private int _breatheSeconds = 10;

    public BreathingActivity() : base()
    {
        SetName("Breating Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public void BreatheIn()
    {
        Console.Write($"\n{_breatheInMsg}");

        for (int i = 1; i <= _breatheSeconds; i++)
        {
            DisplayCount(i, '>');
        }

        Console.WriteLine();
    }
    public void BreatheOut()
    {
        Console.Write($"{_breatheOutMsg}");

        for (int i = _breatheSeconds; i > 0; i--)
        {
            DisplayCount(i, '<');
        }
        Console.WriteLine("\n");
    }

    public void DisplayCount(int i, char indicator)
    {
        string countStr = new string(indicator, i) + i;

        string clearStr = new string('\b', countStr.Length);
        clearStr += new string(' ', countStr.Length);
        clearStr += new string('\b', countStr.Length);

        Console.Write(countStr);
        Thread.Sleep(1000);
        Console.Write(clearStr);
    }

    public void DoBreathing()
    {
        DisplayOpening();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        DateTime now = DateTime.Now;

        while (now < endTime)
        {
            BreatheIn();

            BreatheOut();

            now = DateTime.Now;
        } 

        DisplayClosing();
    }
}