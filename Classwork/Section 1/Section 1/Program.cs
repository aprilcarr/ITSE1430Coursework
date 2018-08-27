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
            //DisplayMenu();
            PlayWithStrings();
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
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("A)dd Movie");
            Console.WriteLine("E)dit Movie");
            Console.WriteLine("D)elete Movie");
            Console.WriteLine("V)iew Movies");
            Console.WriteLine("Q)uit");

            string input = Console.ReadLine();
            switch (input[0])//(input[0]) searches for a character in a string - strings are not arrays in C#
            {
                case 'A': AddMovie(); break; //required in C# - every case statement requires a break 
                case 'E': EditMovie(); break;
                case 'D': DeleteMovie(); break;
                case 'V': ViewMovies(); break;
                case 'Q':; break;

                default: Console.WriteLine("Please enter a valid value."); break;
            };
        }

        private static void AddMovie()
        {
            throw new NotImplementedException();
        }

        private static void EditMovie()
        {
            throw new NotImplementedException();
        }

        private static void ViewMovies()
        {
            throw new NotImplementedException();
        }

        private static void DeleteMovie()
        {
            throw new NotImplementedException();
        }
    }
}
