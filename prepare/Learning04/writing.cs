using System;

namespace homework;

public class Writing : Assignment
{
    private string _title;

    public Writing(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}