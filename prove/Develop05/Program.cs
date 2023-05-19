using System;

class Program
{
    static void Main(string[] args)
    {
        string filename = "myFile.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

        string firstName = parts[0];
        string lastName = parts[1];
    }
        Console.WriteLine("Hello Develop05 World!");
    }
}