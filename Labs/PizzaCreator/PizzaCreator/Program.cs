using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("N)ew Order");
                Console.WriteLine("M)odify Order");
                Console.WriteLine("D)isplay Order");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'n':
                    case 'N':
                        NewOrder();
                        return true;

                    case 'm':
                    case 'M':
                        ModifyOrder();
                        return true;

                    case 'd':
                    case 'D':
                        DisplayOrder();
                        return true;

                    case 'q':
                    case 'Q':
                        return false;
                        

                };
            }
        }
    }
    /*private static int ReadInt32( string message, int minValue )
    {
        while (true)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (Int32.TryParse(input, out var result))
            {
                if (result >= minValue)
                    return result;
            };
            Console.WriteLine($"You must enter an integer value >= {minValue}");
        };
    }

    private static string ReadString( string message )
    {
        return ReadString(message, false);
    }

    private static string ReadString( string message, bool required )
    {
        while (true)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input) || !required)
                return input;

            Console.WriteLine("You must enter a value");
        };
    }*/
}
