using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello there!");
    }
}
public abstract class Employee
{
    private string _employeeName;
    public abstract float CalculatePay();

    static void DisplayPayCheck(Employee e)
    {
        float pay = e.CalculatePay();
    }
}

public class SalaryEmployee : Employee
{
    private float salary = 100f;
    public override float CalculatePay()
    {
        return salary;
    }
}

public class HourlyEmployee : Employee
{
    private float rate = 9f;
    private float hours = 100f;

    public override float CalculatePay()
    {
        return rate * hours;
    }
}