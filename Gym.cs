namespace ConsoleApp83;

public class Gym
{
    protected Gym(string name, int age)
    {
        Name = name;
        Age = age;
        
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; private set; }

    public void Setgender(Gender gender)
    {
        Gender = gender;
    }
}

public enum Gender
{
    male,
    female
}