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

        var generatedUsername = UsernameGenerator(name, surname);

        Console.WriteLine($"This is your username based on your name and surname: {generatedUsername}");
        Console.WriteLine("Do you like the suggested username? (Y/N)");
        GetUserConfirmation(generatedUsername, name, surname);
    }


    static void GetUserConfirmation(string generatedUsername, string name, string surname)
    {
        string? confirmation = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(confirmation))
        {
            if (confirmation.ToUpper() == Approved)
            {
                Console.WriteLine($"{confirmationMsgYES}{generatedUsername}");
            }
            else if (confirmation.ToUpper() == Declined)
            {
                Console.WriteLine("Generating new username .... ");
                Console.WriteLine(confirmationMsgNO + UsernameGenerator(name, surname));
            }
            else
            {
                Console.WriteLine("Invalid confiration choosen!");
            }
        }
        else
        {
            Console.WriteLine("Please enter valid confirmation!");
        }
    }

    static string UsernameGenerator(string name, string surname)
    {
        Random rmd = new Random();
        string random = rmd.Next(1000, 9999).ToString();
        string username = name + surname + random;
        return username;
    }
}
