using System;

class Program
{

    const string confirmationMsgYES = "Welcome to our platform ";
    const string confirmationMsgNO = "New username suggestion is ";
    const string Approved = "Y";
    const string Declined = "N";

   
  
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = LettersOnlyInput();

        Console.WriteLine("Enter your surname: ");
        string surname = LettersOnlyInput();

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

    static string LettersOnlyInput()
    {
        string? input;
        while (true)
        {
            input = Console.ReadLine();
            if (IsAllLetters(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter only letters.");
            }
        }
    }

    static bool IsAllLetters(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        }
        return true;
    }

    static string UsernameGenerator(string name, string surname)
    {
        Random rmd = new Random();
        string random = rmd.Next(1000, 9999).ToString();
        string username = name + surname + random;
        return username;
    }
}
