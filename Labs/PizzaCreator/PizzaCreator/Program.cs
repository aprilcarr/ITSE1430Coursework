using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        public class Order
        {
            public decimal Total { get; set; }
            public List<string> Details { get; set; }
            public bool IsDelivery { get; set; }
        }

        public static Order CustomerOrder { get; set; }

        static void Main(string[] args)
        {
            Program.CustomerOrder = new Order();
            
           /* bool notQuit;
            do
            {
                notQuit = DisplayMenu();
            } while (notQuit);*/

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

                if (input == "N" || input == "n")
                {
                    Console.WriteLine("Size (One is Required)");
                    Console.WriteLine("s)mall $5");
                    Console.WriteLine("m)edium $6.25");
                    Console.WriteLine("l)arge $8.75");
                    Console.WriteLine("          ");
                    Console.WriteLine("Cart total: ");
                    string size = Console.ReadLine();
                    if (size == "s" || size == "S")
                    {
                        Program.CustomerOrder.Details.Add("Size - S");
                        Program.CustomerOrder.Total += 5.00m;

                        Console.WriteLine("Cart total is $5");
                    }
                    else  if (size == "m" || size == "M")
                    {
                        Console.WriteLine("Cart total is $6.25");
                    }
                    else if (size == "l"  || size == "L")
                    {
                        Console.WriteLine("Cart total is $8.75");
                    }

                    Console.WriteLine("Meats (zero or more)  Each options is $0.75 extra");
                    Console.WriteLine("b)acon");
                    Console.WriteLine("h)am");
                    Console.WriteLine("p)epperoni");
                    Console.WriteLine("s)ausage");
                    Console.WriteLine("           ");
                    Console.WriteLine("Vegetables (zero or more)  Each options is $0.50 extra");
                    Console.WriteLine("bl)ack olives");
                    Console.WriteLine("mu)shrooms");
                    Console.WriteLine("o)nions");
                    Console.WriteLine("p)eppers");
                    Console.WriteLine("            ");
                    Console.WriteLine("Sauce (One is required");
                    Console.WriteLine("t)raditional  $0");
                    Console.WriteLine("g)arlic  $1");
                    Console.WriteLine("or)egano  $1");
                    Console.WriteLine("             ");
                    Console.WriteLine("Cheese (One is required)");
                    Console.WriteLine("r)egular $0");
                    Console.WriteLine("e)xtra $1.25");
                    Console.WriteLine("              ");
                    Console.WriteLine("Delivery (One is required");
                    Console.WriteLine("t)ake out $0");
                    Console.WriteLine("d)elivery $2.25");


                };

            }
            /*switch (input[0])
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


            };*/
        }


        /*private static void NewOrder()
        {
            string name = ReadString("Enter a name: ", true);
            description = ReadString("Enter a description:  ");
            runLength = ReadInt32("Enter ren length (in minutes):  ", 0);
            Console.WriteLine("AddMovie");
        }*/


        private static int ReadInt32(string message, int minValue)
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

        
        private static string ReadString(string message)
        {
            return ReadString(message, false);
        }

        private static string ReadString(string message, bool required)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("You must enter a value");
            };
        }

    }
}
