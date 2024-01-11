// See https://aka.ms/new-console-template for more information

using ConsoleApp83;

IUser user = new Management();
while (true)
{
    try
    {
        Run();

    }
    catch (Exception exception)
    {
        ShowError(exception.Message);
    }
}


void Run()
{var Option = GetNumberFromUser("choose:\n" +
                                "1.Add user\n" +
                                "2.Remove user\n" +
                                "3.Show users" );
    switch (Option)
    {
        case 1:
        {
            var name = GetValidStringFromUser("enter name ");
            var age = GetNumberFromUser("enter age");
            var gender = GetNumberFromUser("choose :\n" +
                                           "1. male\n" +
                                           "2. female");
            user.AddUser(name,age,gender);
            
            break;
        }
        case 2:
        {
            var name = GetValidStringFromUser("enter name");
            user.RemoveUser(name);
            break;
        }
        case 3:
        {
            user.ShowUsers();
            break;
        }
    }
    
}


static string GetValidStringFromUser(string message)
{
    bool tryparse = false;
    string? value;
    do
    {
        Console.WriteLine(message);
        value = Console.ReadLine();
          
    } while ( string.IsNullOrWhiteSpace(value)   );
 
    return value;
}

static int GetNumberFromUser(string message)
{
    var resultTryParseFirstNumber = false;
    int number;
    do
    {
        Console.WriteLine(message);
        resultTryParseFirstNumber =
            int.TryParse(Console.ReadLine(), out number);
    } while (!resultTryParseFirstNumber );

    return number;
}

static void ShowError(string error)
{
    Console.WriteLine("*********");
    Console.WriteLine(error);
    Console.WriteLine("*********");
}