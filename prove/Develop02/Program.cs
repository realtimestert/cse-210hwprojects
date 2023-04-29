using System;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\evans\Documents";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }
}