using System;

class Program
{
    static void Main(string[] args)
    {
        
        Lecture event1 = new Lecture();
        event1.SetEvent("Lecture", "Programming with Classes - Q3 2023","Learn how to program with C#","20 October, 2023","9:00-12:00pm", "BYU Idaho, Rexburg, Idaho, United States");
        event1.SetSpeaker("Alex Christensen");
        event1.SetCapacity(150);

        Reception event2 = new Reception();
        event2.SetEvent("Reception","Wedding:Stacy and Garrett Oliverson", "Save the Date","26 May, 2023", "6:00-9:00pm", "500 W. 800 S, Idaho Falls, Idaho, United States");
        event2.SetEmail("Please let us know if you can make it. We would love to see you there!");

        OutdoorGathering event3 = new OutdoorGathering();
        event3.SetEvent("Outdoor Gathering", "Class of 2003 20 Year Reunion", "Come see what everyone has been up to for the last 20 years!", "10 September, 2023", "1:00-4:00pm", "500 E 900 S, Sandy, Utah, United States");
        event3.SetWeatherForecastStatement("The weather is looking nice and warm!");

        /* call the event, call the method to generate the market messages and output to the screen */

        
        List <Event> elist = new List <Event> ();
        elist.Add(event1);
        elist.Add(event2);
        elist.Add(event3);
        
        foreach (Event vent in elist)
        {
            Console.WriteLine("\n--------Short Message: -----------");
            vent.ShortDescription();
            Console.WriteLine("--------Stardard Message:---------");
            vent.ListStandardDetails();
            Console.WriteLine("--------Full Message:-------------");
            vent.FullDetails();
            Console.WriteLine();
    
        }
        
    }
}