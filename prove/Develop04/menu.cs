using System.Runtime.InteropServices;

public class Menu
{
    private Dictionary<string, MenuOptions> _options = new Dictionary<string, MenuOptions>{};
    private string _header = "Menu Options; ";
    private string _prompt = "Select an option: ";

    public void AddOption(string key, string text, MenuOptionsCallback callback)
    {
        _options.Add(key, new MenuOptions(key, text, callback));
    }

    public void SetOption(string key, string text, MenuOptionsCallback callback)
    {
        if (_options.ContainsKey(key))
        {
            _options[key].SetMenuOptionsText(text);
            _options[key].SetMenuOptionsCallback(callback);
        }    
    }

    public string GetOption(string key)
    {
        if (_options.ContainsKey(key))
        {
            return _options[key].GetMenuOptionsText();
        }
        else
        {
            return "";
        }    
    }

    public void SetHeader(string header)
    {
        _header = header;
    }

    public string GetHeader()
    {
        return _header;
    }

    public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetMenu()
    {
        string menu = $"\n{_header}";

        foreach (KeyValuePair<string, MenuOptions> kvp in _options)
        {
            MenuOptions option = kvp.Value;
            menu += $"{kvp.Key}. {option.GetMenuOptionsText()}";
        }

        menu += $"\n{_prompt}";

        return menu;
    }   

    public void DisplayMenu()
    {
        string choice = "";

        Console.Clear();
        Console.WriteLine($"\n{_header}");
        foreach (KeyValuePair<string, MenuOptions> kvp in _options)
        {
            MenuOptions option = kvp.Value;
            Console.WriteLine($"{kvp.Key}. {option.GetMenuOptionsText()}");
        }
        Console.WriteLine();

        while (!_options.ContainsKey(choice))
        {
            Console.Write($"{_prompt}");

            choice = Console.ReadLine();
        }

        if (_options.ContainsKey(choice))
        {
            _options[choice].RunMenuOptions();
        }
    }   
}