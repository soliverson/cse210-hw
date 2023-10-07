using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        bool exit = false;

        BreathingActivity opt1 = new BreathingActivity();
        ReflectionActivity opt2 = new ReflectionActivity();
        ListingActivity opt3 = new ListingActivity();

        void Quit()
        {
            Console.WriteLine($"Thank yourself for taking time for your own mindfulness.");
            exit = true;
        }

        MenuOptionsCallback breathingCallback = new MenuOptionsCallback(opt1.DoBreathing);
        MenuOptionsCallback reflectionCallback = new MenuOptionsCallback(opt2.DoReflection);
        MenuOptionsCallback listingCallback = new MenuOptionsCallback(opt3.DoListing);
        MenuOptionsCallback quitCallback = new MenuOptionsCallback(Quit);

        Menu menu = new Menu();
        menu.SetHeader("Menu Options:");
        menu.AddOption("1", "Start breathing activity", breathingCallback);
        menu.AddOption("2", "Start reflection activity", reflectionCallback);
        menu.AddOption("3", "Start listing activity", listingCallback);
        menu.AddOption("4", "Quit", quitCallback);
        menu.SetPrompt("Select a choice from the menu: ");

        while (!exit)
        {
            menu.DisplayMenu();
        }

    }
}