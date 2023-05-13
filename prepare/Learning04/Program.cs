using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Stuart Evans", "CSE210");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Stuart Evans", "Calculus", "1.2", "1-2" );
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}