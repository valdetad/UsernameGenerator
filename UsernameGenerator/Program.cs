using System;
using UsernameGenerator;

public class Program : ApplicationConstants
{


    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = UserGenValidator.LettersOnlyInput();

        Console.WriteLine("Enter your surname: ");
        string surname = UserGenValidator.LettersOnlyInput();

        var generatedUsername = UsernameGenHelper.UsernameGenerator(name, surname);

        Console.WriteLine($"This is your username based on your name and surname: {generatedUsername}");
        Console.WriteLine("Do you like the suggested username? (Y/N)");
        UsernameGenHelper.GetUserConfirmation(generatedUsername, name, surname);
    }

}