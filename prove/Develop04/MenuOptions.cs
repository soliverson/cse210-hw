using System.Reflection.Metadata.Ecma335;

public delegate void MenuOptionsCallback();

public class MenuOptions
{
    private string _text = "";
    private string _key = "";
    private MenuOptionsCallback _callback;

    public MenuOptions(string key, string text, MenuOptionsCallback callback)
    {
        SetMenuOptionsKey(key);
        SetMenuOptionsText(text);
        SetMenuOptionsCallback(callback);
    }

    public string GetMenuOptionsText()
    {
        return _text;
    }

    public void SetMenuOptionsText(string text)
    {
        _text = text;
    }

    public string GetMenuOptionsKey()
    {
        return _key;
    }

    public void SetMenuOptionsKey(string key)
    {
        _key = key;
    }

    public void SetMenuOptionsCallback(MenuOptionsCallback callback)
    {
        _callback = callback;
    }

    public void RunMenuOptions()
    {
        _callback();
    }
}