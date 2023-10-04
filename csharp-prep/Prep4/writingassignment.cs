using System;

public class WritingAssignment: Assignment
{
    // create attribute 
    private string _title;
    
    // create constructor with all the parameters.

    public WritingAssignment(string studentName, string topic, string title): base(studentName, topic)
    {
        _title = title;
    }

    // create method to get writing information.

    public string GetWritingInformation()
    {
       return _title + " " + base.GetStudentName();
    }

}