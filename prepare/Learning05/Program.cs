using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World! It's your old pal, Polymorphism III");
    }
}

public abstract class Employee
{
    private string _employeeName;
    public abstract float CalculatePay();
}