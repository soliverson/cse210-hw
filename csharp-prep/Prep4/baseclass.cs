using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    // create the getter for student's name

    public string GetStudentName()
    {
        return _studentName;
    }

    // create constructor that receives a student name and topic.

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //create method to get the summary to return the student's name and the topic.

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

}