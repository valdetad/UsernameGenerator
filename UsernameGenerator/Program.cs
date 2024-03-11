using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your surname: ");
        string surname = Console.ReadLine();

        var generatedUsername = UsernameGenerator(name, surname);


        Console.WriteLine("This is your username based on your name and surname: " + generatedUsername);

        Console.WriteLine("Do you like the suggested username? (Y/N)");

        string confirmation = Console.ReadLine();

        // Check something ....
        if (confirmation == "Y")
        {
            Console.WriteLine("Welcome to our platform, " + generatedUsername);
        }
        else if(confirmation == "N")
        {
            Console.WriteLine("Here is the new username suggestion: " + );
            
        }

        // does something 
        static string UsernameGenerator(string name, string surname)
        {
            Random rmd = new Random();

            string random = rmd.Next(1000, 9999).ToString();

            string username = name + surname + random;

            return username;
        }
    }
}