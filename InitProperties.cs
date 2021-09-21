// demo of init only properties - can be set using object initialiser

using System;

// this is an exmaple of an immutable class - cannot change state once constructed

public class Person
{
    // init only auto property
    public string Name { get; init; }

    private DateTime dob;
    public DateTime Dob
    {
        get => this.dob;
        init
        {
            if (DateTime.Now.Year >= value.Year + 120)
            {
                throw new ArgumentException("too old");
            }
            else
            {
                this.dob = value;
            }
        }
    }

    public override string ToString()
    {
        return $"{Name} {Dob.ToShortDateString()}";
    }

}

public static class Test
{
    static void Main()
    {
        Person p1 = new Person() { Name = "Gary", Dob = new DateTime(1980, 1, 1) };
        Console.WriteLine(p1);
    }
}