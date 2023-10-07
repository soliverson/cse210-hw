public class ReflectionActivity : Activity
{
    // Define private attributes
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};

    // Constructors

    public ReflectionActivity() : base()
    {
        SetName("Reflection Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    // Methods

    public void DoReflection()
    // Function that does the primary work of this activity (used as callback function for menu option)
    {
        // Show the common opening, from the parent Activity class
        DisplayOpening();

        // Display the random activity prompt and tell the user to continue when ready
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {_prompts[GetRandomListIndex(_prompts)]} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now, ponder on the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        CountDown(10);

        // Create timed operation to loop until the activity duration expires
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        DateTime now = DateTime.Now;

        Console.Clear();

        // Loop for the specified activity duration
        while (now < endTime)
        {
            // Display a random question
            Console.Write($"> {_questions[GetRandomListIndex(_questions)]}");

            // Pause, with spinner
            PauseSpinner(15);

            // Update the current time variable
            now = DateTime.Now;
        }

        // Display the common closing, from the parent Activity class
        DisplayClosing();

    }

}