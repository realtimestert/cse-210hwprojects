using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello there!");
        
        //This is a constructor
        Person p = new Person();
        p.SetFirstName("Peter");

        Console.WriteLine(p.GetFirstName());

        Person p1 = new Person();
        Person p2 = new Person("Stuart", "Evans");
        Person p3 = new Person("Mr.", "Stuart", "Evans");
    }
}