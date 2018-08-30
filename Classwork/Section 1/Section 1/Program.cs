using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_1
{
    class Program
    {
        static void Main( string[] args )
        {
            bool notQuit;
            do
            {
               notQuit = DisplayMenu();
            } while (notQuit);
                           
                
                
                
            //PlayWithStrings();
        }

        private static void PlayWithStrings()
        {

            string hoursString = "10A";
            // int hours = Int32.Parse(hoursString);//must be proper primitive
            //int hours;
            //bool result = Int32.TryParse(hoursString, out hours); //out parameter HOW YOU PARSE STRINGS
            //bool result = Int32.TryParse(hoursString, out int hours); //^ previous 2 lines can be combined for clarity and maintenance using local declarations 
            //TryParse is used to validate user input

            //ToString
            // hoursString = hours.ToString();// works on any expression; converts any expression to its string equivalent
            //4.75.ToString();
            //457.ToString
            //Console.ReadLine().ToSTring();

            string message = "Hello\tworld";
            string filePath = @"C:\\Temp\\Test"; // \\maps to one character = used to make filepath valid
            //verbatim strings
            filePath = @"C:\\Temp\\Test";

            //Concat
            string firstName = "Bob";
            string lastName = "Smith";
            string name = firstName + " " + lastName;

            // strings are immutable - this produces a new string
            name = "Hello" + name;
            Console.WriteLine("hello" + name);//just want to print it to the console - 6 max per program when using +  Approach 1
            Console.WriteLine("Hello {0} {1}", firstName, lastName); //alternative to +.  No maximum. approach 2
            string str = String.Format("Hello {0} {1}, firstName, lastName");  // approach 3
            Console.WriteLine(str);

            //Approach 4
            Console.WriteLine($"Hello {firstName} {lastName}");//interpreted string - language limitations compiler will tell you, stick with identifiers and integers
                                                               //String is more readable, can't screw it up?, 

            //Null vs empty
            string missing = null;
            string empty = " ";
            string empty2 = String.Empty;

            //Checking for empty strings
            //if (firstName.Length ==0)
            if (firstName != null && firstName != "")
                Console.WriteLine(firstName);

            //Preferred checking for empty strings
            if (!String.IsNullOrEmpty(firstName))
                Console.WriteLine(firstName);

            //Other stuff
            string upperName = firstName.ToUpper();
            string lowerName = firstName.ToLower();

            //string comparison
            bool areEqual = firstName == lastName; //case matters
            areEqual = firstName.ToLower() == lastName.ToLower(); //use ToLower if culture is a concern
            areEqual = String.Compare(firstName, lastName) == 0; // return type int.  if it returns a 0 it is true. less than 0 means left is greater than right etc
            areEqual = String.Compare(firstName, lastName, true) == 0; // case insensitive 

            bool startsWithA = firstName.StartsWith("A");
            bool endsWithA = firstName.EndsWith("A");
            bool hasA = firstName.IndexOf("A") >= 0;
            string subset = firstName.Substring(4);

            //Clean up functions
            string cleanMe = firstName.Trim(); //removes whitespace on either end- also - TrimStart, TrimEnd
            string makeLonger = firstName.PadLeft(20); //PadRight 

        }


        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("E)dit Movie");
                Console.WriteLine("D)elete Movie");
                Console.WriteLine("V)iew Movies");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                switch (input[0])//(input[0]) searches for a character in a string - strings are not arrays in C#
                {
                    case 'a':
                    case 'A': AddMovie(); return true;

                    case 'e':
                    case 'E': EditMovie(); return true;

                    case 'd':
                    case 'D': DeleteMovie(); return true;

                    case 'v':
                    case 'V': ViewMovies(); return true;

                    case 'q':
                    case 'Q': return false;

                    default:
                    Console.WriteLine("Please enter a valid value.");
                    break; //required in C# - every case statement requires a break or return from expression - *one case of fall through - empty case statement
                };
            };
        }

        private static void AddMovie()
        {
            Console.WriteLine("DeleteMovie");
        }

        private static void EditMovie()
        {
            Console.WriteLine("EditMovie");
        }

        private static void ViewMovies()
        {
            Console.WriteLine("ViewMovies");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("DeleteMovie");
        }
    }
}
