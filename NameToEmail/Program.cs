

using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NameToEmail
{
    //“Design a method that formats a list of full names into email-friendly usernames.”

    //You’re given a list of full names.Each name is a string in the format:
    //"First Last" (e.g., "John Smith", "Samantha Lee")

    //You need to convert each name into a username string:

    //Format: first.last @company.com(all lowercase)

    //Remove any extra whitespace

    //Skip names that are invalid(e.g., only one word)

    class Program
    {
        private static string Preformat(string name)
        {
            // format 
            var formattedName = Regex.Split(name.Trim(), @"\s+");
            return String.Join("", formattedName).ToLower();
        }

        private static bool IsValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            var parts = Regex.Split(name.Trim(), @"\s+");
            return parts.Length == 2;
        }

        private static string AddEmail(string name)
        {
            return $"{name}@company.com";
        }

        private static List<string> GetResult(List<string> inputNames)
        {
            List<string> formattedEmail = new List<string>();
            foreach (string name in inputNames)
            {
                var formattedName = Preformat(name);
                if (IsValid(formattedName))
                {
                    // add email
                    formattedEmail.Add(AddEmail(formattedName));
                }

            }
            return formattedEmail;
        }

        public static readonly List<string> inputNames = new List<string> {
        " John   Smith ",
        "Samantha Lee",
        "InvalidName",
        "   Alice   ",
        "Bob Lee Swagger"
        };

        // method
        // preformat
        // return bool -> valid or not

        // remove extra whitespace
        // lower case
        // put @company.com at the end
        static void Main(string[] args)
        {
            var result = GetResult(inputNames);
            foreach(string email in result)
            {
                Console.WriteLine(email);
            }
        }
    }
}

