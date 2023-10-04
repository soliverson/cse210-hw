using System;

public class MathAssignment: Assignment
{
    //create attributes
    private string _textbookSection;
    private string _problems;

    //create constructor that accepts four parameters

    public MathAssignment(string studentName, string topic, string textbookSection, string problems): base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // create the method to get list of homework.

    public string GetHomeworkList()
    {
        return "Section " + _textbookSection + " Problems " + _problems;
    }
}