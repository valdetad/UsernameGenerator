using System;

namespace UsernameGenerator
{
    public static class UserGenValidator
    {
        public static string LettersOnlyInput()
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

    }
}
