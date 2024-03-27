using System;

namespace UsernameGenerator
{
    public static class UsernameGenHelper
    {
        public static void GetUserConfirmation(string generatedUsername, string name, string surname)
        {
            Console.WriteLine("Enter your confirmation (Approved/Declined): ");
            string confirmation = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(confirmation))
            {
                if (confirmation.ToUpper() == "APPROVED")
                {
                    Console.WriteLine($"Your username is approved: {generatedUsername}");
                }
                else if (confirmation.ToUpper() == "DECLINED")
                {
                    Console.WriteLine("Generating new username .... ");
                    Console.WriteLine($"New username: {UsernameGenerator(name, surname)}");
                }
                else
                {
                    Console.WriteLine("Invalid confirmation chosen!");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid confirmation!");
            }
        }

        public static string UsernameGenerator(string name, string surname)
        {
            Random rmd = new Random();
            string random = rmd.Next(1000, 9999).ToString();
            string username = name + surname + random;
            return username;
        }
    }
}


