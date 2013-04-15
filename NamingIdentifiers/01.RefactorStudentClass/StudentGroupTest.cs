using System;
using System.Text;

public class StudentGroup
{
    private const int MAX_COUNT_STUDENT_GROUPS = 6;

    public static void Main()
    {
        StudentGroup.CurrentGroup instance = new StudentGroup.CurrentGroup();
        instance.PrintOneGroupExists(true);
    }

    public class CurrentGroup
    {
        public void PrintOneGroupExists(bool exists)
        {
            string existsAsString = exists.ToString();
            Console.WriteLine(existsAsString);
        }
    }
}