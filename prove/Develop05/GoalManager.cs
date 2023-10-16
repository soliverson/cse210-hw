using System;
using System.Diagnostics;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal> ();
    private int _scores;

    public GoalManager (int scores, Goal goals)
    {
        _scores = scores;
        _goals.Add(goals);
    }    
        public GoalManager ()
    {
    }    

    public void Start ()
    {
        Console.WriteLine ($"\nYou have {_scores} points");
        List<String> menu = new List<string>
        {
            "",
            "Create New Goal",
            "List Goals",
            "Save Goals",
            "Load Goals",
            "Record Event",
            "Quit"
        };

        Console.WriteLine("\nMenu Options:");
        for (int i = 1; i < menu.Count; i++)
        {
            Console.WriteLine($"  {i}. {menu[i]}");
        }
        Console.Write("Select a choice from your menu: ");
    }
    public void DisplayPlayerInfo ()
    {
  
    }
    public void ListGoalNames ()
    {
        List<String> menuGoal = new List<string>
        {
            "",
            "Simple Goal",
            "Eternal Goals",
            "Checklist Goals",
        };

        Console.WriteLine("The types of Goals are:");
        for (int i = 1; i < menuGoal.Count; i++)
        {
            Console.WriteLine($"  {i}. {menuGoal[i]}");
        }
        Console.Write("Which type of goal would you like to create? ");
    }
    public void ListGoalDetails ()
    {
        foreach (Goal list in _goals)
        {
            Console.WriteLine(list.GetDetailsString ());
        }
    }
    public void CreateGoal ()
    {
        Console.Write ("");
        int userInput1 = int.Parse(Console.ReadLine ());

        if (userInput1 == 1)
        {
            //SimpleGoal simpleGoal = new SimpleGoal ()
            Console.Write("What is the name of your goal? ");
            string inputName = Console.ReadLine ();

            Console.Write("What is a short description of it? ");
            string inputDescription = Console.ReadLine ();

            Console.Write("What is the amount of points associated with this goal? ");
            string inputPoints = Console.ReadLine ();

            SimpleGoal simpleGoal = new SimpleGoal (inputName, inputDescription, int.Parse(inputPoints));
            _goals.Add (simpleGoal);
        }
        else if (userInput1 == 2)
        {
            //SimpleGoal simpleGoal = new SimpleGoal ()
            Console.Write("What is the name of your goal? ");
            string inputName = Console.ReadLine ();

            Console.Write("What is a short description of it? ");
            string inputDescription = Console.ReadLine ();

            Console.Write("What is the amount of points associated with this goal? ");
            string inputPoints = Console.ReadLine ();

            EternalGoal eternalGoal = new EternalGoal (inputName, inputDescription, int.Parse(inputPoints));
            _goals.Add (eternalGoal);
        }
        else if (userInput1 == 3)
        {
            //SimpleGoal simpleGoal = new SimpleGoal ()
            Console.Write("What is the name of your goal? ");
            string inputName = Console.ReadLine ();

            Console.Write("What is a short description of it? ");
            string inputDescription = Console.ReadLine ();

            Console.Write("What is the amount of points associated with this goal? ");
            string inputPoints = Console.ReadLine ();

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string inputTarget = Console.ReadLine ();

            Console.Write("What is the bonus points for accomplishing it that many times? ");
            string inputBonus = Console.ReadLine ();

            ChecklistGoal checklistGoal = new ChecklistGoal (inputName, inputDescription, int.Parse(inputPoints), 0, int.Parse(inputTarget), int.Parse(inputBonus));
            _goals.Add (checklistGoal);
        };
    }

    public void RecordEvent ()
    {
        List<String> menuGoal = new List<string>
        {
            "",
            "Simple Goal",
            "Eternal Goals",
            "Checklist Goals",
        };

        Console.WriteLine("The types of Goals are:");
        for (int i = 1; i < menuGoal.Count; i++)
        {
            Console.WriteLine($"  {i}. {menuGoal[i]}");
        }
    
        Console.Write("Which goal did you accomplish? ");
        int userInput1 = int.Parse(Console.ReadLine ());

        if (userInput1 == 1)
        {
            foreach (Goal goal in _goals)
            {
                if (goal.ToString() == "SimpleGoal")
                {
                    Goal simpleGoals = goal;
    
                    simpleGoals.RecordEvent();
                    Console.WriteLine($"Congratulations! you earned {simpleGoals.GetPoints()} points!");
                    int number = simpleGoals.GetPoints();
                    _scores += number;

                    if (simpleGoals.GetPoints() > 0)
                        {
                            int numLines = 7;

                            for (int i = 1; i <= numLines; i++)
                            {
                                string stars = new string('♥', i * 2 - 1);
                                Console.WriteLine(stars.PadLeft(numLines + i - 1));
                            }
                            Console.WriteLine($"Congratulations! you've accomplished one more goal in your life, it's a reson to celebrate!");

                            DateTime startTime = DateTime.Now;
                            DateTime futuretime = startTime.AddSeconds(8);

                            while (futuretime >= DateTime.Now)
                            {
                                List<string> symbols = new List<string> {
                                    "☺",
                                    " ☻",
                                    "  ♥",
                                    "   ♫"
                                };

                                foreach (string symbol in symbols)
                                {
                                    Console.Write (symbol);

                                    Thread.Sleep (250);

                                    Console.Write ("-");
                                }
                            }
                            Console.Clear();

                            DateTime startTime2 = DateTime.Now;
                            DateTime futuretime2 = startTime.AddSeconds(12);
                            while (futuretime2 >= DateTime.Now)
                            {
                                List<string> symbols1 = new List<string> {
                                    "▲",
                                    "►",
                                    "◄"
                                };

                                foreach (string symbol in symbols1)
                                {
                                    Console.Write (symbol);

                                    Thread.Sleep (500);

                                    Console.Write ("\b \b");
                                }
                            }
                        }
                        
                }
            }  
        }
        if (userInput1 == 2)
        {
            foreach (Goal goal2 in _goals)
            {
                if (goal2.ToString() == "EternalGoal")
                {
                    Goal eternalGoals = goal2;
     
                    eternalGoals.RecordEvent();
                    Console.WriteLine($"Congratulations! you earned {eternalGoals.GetPoints()} points!");
                    int number = eternalGoals.GetPoints();
                    _scores += number;
                }
            }
        }
        if (userInput1 == 3)
        {
            foreach (Goal goal3 in _goals)
            {
                if (goal3.ToString() == "ChecklistGoal")
                {
                    Goal checklistGoals = goal3;
        
                    checklistGoals.RecordEvent();
                    Console.WriteLine($"Congratulations! you earned {checklistGoals.GetPoints()} points!");
                    int number = checklistGoals.GetPoints();
                    _scores += number;
                    _scores += checklistGoals.GetBonus ();
                    
                    if (checklistGoals.GetBonus() > 0)
                    {
                        Console.Clear();
                        int numLines = 7;

                        for (int i = 1; i <= numLines; i++)
                        {
                            string stars = new string('♥', i * 2 - 1);
                            Console.WriteLine(stars.PadLeft(numLines + i - 1));
                        }
                        Console.WriteLine($"Congratulations! you've accomplished one more goal in your life, it's a reson to celebrate!");

                        DateTime startTime = DateTime.Now;
                        DateTime futuretime = startTime.AddSeconds(8);

                        while (futuretime >= DateTime.Now)
                        {
                            List<string> symbols = new List<string> {
                                "☺",
                                " ☻",
                                "  ♥",
                                "   ♫"
                            };

                            foreach (string symbol in symbols)
                            {
                                Console.Write (symbol);

                                Thread.Sleep (250);

                                Console.Write ("-");
                            }
                        }
                        Console.Clear();

                        DateTime startTime2 = DateTime.Now;
                        DateTime futuretime2 = startTime.AddSeconds(12);
                        while (futuretime2 >= DateTime.Now)
                        {
                            List<string> symbols1 = new List<string> {
                                "▲",
                                "►",
                                "◄"
                            };

                            foreach (string symbol in symbols1)
                            {
                                Console.Write (symbol);

                                Thread.Sleep (500);

                                Console.Write ("\b \b");
                            }
                        }
                    }
                }
            }
        }
    }

    public void SaveGoals ()
    {
        Console.Write ("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter (fileName))
        {
            outputFile.WriteLine ($"{_scores}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine ($"{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals ()
    {
        List<string> linesTo = new List<string> ();
        
        Console.Write ("What is the filename for the goal file? ");
        string fileName1 = Console.ReadLine();
        
        using (StreamReader reader = new StreamReader (fileName1))
        {
            int lineIndex = 0;
            int targetLineIndex = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (lineIndex == targetLineIndex)
                {
                    linesTo.Add($"{line}");
                }
                lineIndex ++;
                targetLineIndex ++; 
            }
        }
        foreach (string item in linesTo)
        {   
            string[] mother = item.Split(":");

            if (mother.Count() == 2)
            {
                string goalName = mother[0];
                
                string part2 = mother[1];

                if (goalName == "SimpleGoal")
                {
                    string[] elements = part2.Split (",");
                    string element1 = elements[0];
                    string element2 = elements[1];
                    int element3 = int.Parse(elements[2]);
                    bool element4 = bool.Parse(elements[3]);

                    SimpleGoal simpleGoal = new SimpleGoal (element1, element2, element3, element4);
                    _goals.Add (simpleGoal);
                }
                else if (goalName == "EternalGoal")
                {
                    string[] elements = part2.Split (",");
                    string element1 = elements[0];
                    string element2 = elements[1];
                    int element3 = int.Parse(elements[2]);

                    EternalGoal eternalGoal = new EternalGoal (element1, element2, element3);
                    _goals.Add (eternalGoal);
                }
                else if (goalName == "ChecklistGoal")
                {
                    string[] elements = part2.Split (",");
                    string element1 = elements[0];
                    string element2 = elements[1];
                    int element3 = int.Parse(elements[2]);
                    int element4 = int.Parse(elements[3]);
                    int element5 = int.Parse(elements[4]);
                    int element6 = int.Parse(elements[5]);

                    ChecklistGoal checklistGoal = new ChecklistGoal (element1, element2, element3, element6, element5, element4);
                    _goals.Add (checklistGoal);
                }
            }
            else if (mother.Count() == 1)
            {
                _scores = int.Parse(linesTo[0]);
            }
        }
    }
}