using System;

namespace Foundation4

{

class Program
{
    static void Main(string[] args)
    {
        List <Activity> list = new List<Activity> ();
        Running run = new Running ();
        run.SetDate("18 Oct 2023");
        run.SetLengthOfActivity(60);
        run.SetActivity();
        run.CalculateDistance(115);
        list.Add(run);

        Swimming swim = new Swimming ();
        swim.SetDate("19 Oct 2023");
        swim.SetActivity();
        swim.CalculateDistance(20);  // in laps
        swim.SetLengthOfActivity(30);
        list.Add(swim);

        StationaryBicycle cyc = new StationaryBicycle ();
        cyc.SetDate("20 Oct 2023");
        cyc.SetActivity();
        cyc.CalculateDistance(400);  // in km
        cyc.SetLengthOfActivity(40);
        list.Add(cyc);

        foreach (Activity a in list)
        {
            string summary = a.GetSummary();
            Console.WriteLine(summary);
        }
        
    }
}
}