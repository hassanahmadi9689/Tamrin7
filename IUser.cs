namespace ConsoleApp83;

public interface IUser
{
    public void AddUser(string name,int age,int gender);
    public void RemoveUser(string name);
    public void ShowUsers();

    
}