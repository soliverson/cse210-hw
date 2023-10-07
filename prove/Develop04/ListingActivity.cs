public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heros?"};
    private List<string> responses = new List<string>{}; 


    public ListingActivity() : base()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }


    public void DoListing()
    {
        DisplayOpening();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[GetRandomListIndex(_prompts)]} ---");
        Console.Write("You may begin in: ");
        CountDown(10); 
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        DateTime now = DateTime.Now;

        while (now < endTime)
        {
            Console.Write("> ");

            responses.Add(Console.ReadLine());

            now = DateTime.Now;
        }

        DisplayClosing();
    }
}