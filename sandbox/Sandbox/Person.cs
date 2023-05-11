using System;

public class Person
{
    public int _balacne = 0;
    private List<int> _transations = new List<int>();
    private string _title;
    private string _firstName;
    private string _lastName;

    public void Deposit(int amount)
    {
        _balacne = _balacne + amount;
        _transations.Add(amount);
    } 

    public string GetInformalSignature()
    {
        return "Thanks, " + _firstName;
    }
    public string GetFormalSignature()
    {
        return "Sincerly " + _lastName;
    }
    public string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }
    public string GetFirstName()
    {
        return _firstName;
    }
    public string GetLastName()
    {
        return _lastName;
    }
    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }

    public Person()
    {
        _title = "";
        _firstName = "Stuart";
        _lastName = "Evans";
    }
    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }
    public Person(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }
}

    