namespace ConsoleApp83;

public class Management : IUser
{
    private List<Gym> _users = new List<Gym>();


    public void AddUser(string name, int age, int gender)
    {
        if (gender==2)
        {
            var user = new MenGym(name, age);
            user.Setgender(Gender.female);
            _users.Add(user);
        }

        if (gender==1)
        {
            var user = new MenGym(name, age);
            user.Setgender(Gender.male);
            _users.Add(user);
        }

        if (gender>2 || gender<1)
        {
            throw new Exception("wrong number for gender");
        }
    }

    public void RemoveUser(string name)
    {
        var user = _users.Find(_ => _.Name == name);
        if (user is null)
        {
            throw new Exception("user not found");
        }

        _users.Remove(user);

    }

    public void ShowUsers()
    {
        foreach (var user in _users)
        {
                        Console.WriteLine($"name : {user.Name} - age{user.Age} - gender:{user.Gender}");
        }   
    }

    
}