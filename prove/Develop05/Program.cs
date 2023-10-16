using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;

        GoalManager goalManager = new GoalManager ();
 

        while (userInput != 6)
        {
            goalManager.Start ();
            Console.Write ("");
            userInput = int.Parse(Console.ReadLine ());

            if (userInput == 1)
            {
                goalManager.ListGoalNames ();
                goalManager.CreateGoal ();
            }
            else if (userInput == 2)
            {
                goalManager.ListGoalDetails ();
            }
            else if (userInput ==3)
            {
                goalManager.SaveGoals();
            }
            else if (userInput ==4)
            {
                goalManager.LoadGoals ();
            }
            else if (userInput == 5)
            {
                goalManager.RecordEvent ();
            }
        }
    }
}