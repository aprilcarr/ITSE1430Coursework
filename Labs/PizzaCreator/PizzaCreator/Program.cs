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
            public List<string> Details = new List<string>();//{ get; set; }
            public bool IsDelivery { get; set; }
        }

        public static Order CustomerOrder { get; set; }

        static void Main(string[] args)
        {
            Program.CustomerOrder = new Order();
            
           bool notQuit;
            do
            {
                notQuit = DisplayMenu();
            } while (notQuit);

        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("N)ew Order");
                Console.WriteLine("M)odify Order");
                Console.WriteLine("D)isplay Order");
                Console.WriteLine("Q)uit");
                Console.WriteLine("        ");

                string input = Console.ReadLine();
                //bool isValidInput = true;

                if (input == "q" || input == "Q")
                {
                    return false;
                }


                if (input == "N" || input == "n")
                {
                    Console.WriteLine("Size (One is Required)");
                    Console.WriteLine("S)mall $5");
                    Console.WriteLine("M)edium $6.25");
                    Console.WriteLine("L)arge $8.75");
                    Console.WriteLine("          ");
                    //Console.WriteLine("Cart total: ");
                    string size = Console.ReadLine();
                    if (size == "s" || size == "S")
                    {
                        Program.CustomerOrder.Details.Add("Small                      $5.00");
                        Program.CustomerOrder.Total += 5.00m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }

                    else if (size == "m" || size == "M")
                    {
                        Program.CustomerOrder.Details.Add("Medium                     $6.25");
                        Program.CustomerOrder.Total += 6.25m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (size == "l" || size == "L")
                    {
                        Program.CustomerOrder.Details.Add("Large                      $8.75");
                        Program.CustomerOrder.Total += 8.75m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }



                    Console.WriteLine("Meats (zero or more)  Each options is $0.75 extra");


                    Console.WriteLine("Bacon?  Y or N");
                    string bacon = Console.ReadLine();
                    if (bacon == "Y" || bacon == "y")
                    {
                        Program.CustomerOrder.Details.Add("Bacon                    + $0.75");
                        Program.CustomerOrder.Total += .75m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (bacon =="N" || bacon == "n")
                    {
                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                    }


                    Console.WriteLine("Ham?  Y or N");
                    string ham = Console.ReadLine();
                    if (ham == "Y" || ham == "y")
                    {
                        Program.CustomerOrder.Details.Add("Ham                      + $0.75");
                        Program.CustomerOrder.Total += .75m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (ham == "N" || ham == "n")
                    {
                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                    }
                

                    Console.WriteLine("Pepperoni?  Y or N");
                    string pepperoni = Console.ReadLine();
                    if (pepperoni == "y" || pepperoni == "Y")
                    {
                        Program.CustomerOrder.Details.Add("Pepperoni                + $0.75");
                        Program.CustomerOrder.Total += .75m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (pepperoni == "N" || pepperoni == "n")
                    {
                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                    }

                    Console.WriteLine("Sausage?  Y or N");
                    string sausage = Console.ReadLine();

                    if (sausage == "y" || sausage == "Y")
                    {
                        Program.CustomerOrder.Details.Add("Sausage                  + $0.75");
                        Program.CustomerOrder.Total += .75m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (sausage == "N" || sausage == "n")
                    {
                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                    }

                    Console.WriteLine("           ");

                    Console.WriteLine("Vegetables (zero or more)  Each options is $0.50 extra");

                    Console.WriteLine("Black olives?  Y or N");
                    string blackOlives = Console.ReadLine();
                    if (blackOlives == "y" || blackOlives == "Y")
                    {
                        Program.CustomerOrder.Details.Add("Black olives             + $0.50");
                        Program.CustomerOrder.Total += .50m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (blackOlives == "N" || blackOlives == "n")
                        {
                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                    }

                    Console.WriteLine("Mushrooms? Y or N");
                    string mushrooms = Console.ReadLine();
                    if (mushrooms == "Y" || mushrooms == "y")
                    {
                        Program.CustomerOrder.Details.Add("Mushrooms                + $0.50");
                        Program.CustomerOrder.Total += .50m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (mushrooms == "N" || mushrooms == "n")
                    {
                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                    }

                    Console.WriteLine("Onions?  Y or N");
                    string onion = Console.ReadLine();
                    if (onion == "Y" || onion == "y")
                    {
                        Program.CustomerOrder.Details.Add("Onion                    + $0.50");
                        Program.CustomerOrder.Total += .50m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (onion == "N" || onion == "n")
                    {
                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                    }

                    Console.WriteLine("Peppers?  Y or N");
                    string peppers = Console.ReadLine();
                    if (peppers == "Y" || peppers == "y")
                    {
                        Program.CustomerOrder.Details.Add("Peppers                  + $0.50");
                        Program.CustomerOrder.Total += .50m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");

                    }
                    else if (peppers == "N" || peppers == "n")
                    {
                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                    }
                    Console.WriteLine("            ");

                    Console.WriteLine("Sauce - T)raditional, G)arlic, or O)regano (limit 1)");

                    string sauce = Console.ReadLine();
                    if (sauce == "t" || sauce == "T")
                    {
                        Program.CustomerOrder.Details.Add("Traditional sauce        + $0.00");
                        Program.CustomerOrder.Total += 0m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (sauce == "g" || sauce == "G")
                    {
                        Program.CustomerOrder.Details.Add("Garlic sauce             + $1.00");
                        Program.CustomerOrder.Total += 1m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (sauce == "O" || sauce == "o")
                    {
                        Program.CustomerOrder.Details.Add("Oregano sauce            + $1.00");
                        Program.CustomerOrder.Total += 1m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    //else if (sauce == null)
                    //{
                    //    Console.WriteLine("Error.  Please choose a sauce.");
                    //}

                    Console.WriteLine("             ");

                    Console.WriteLine("Cheese- R)egular or E)xtra (One is required)");
                    string cheese = Console.ReadLine();
                    if (cheese == "R" || cheese == "r")
                    {
                        Program.CustomerOrder.Details.Add("Regular cheese           + $0.00");
                        Program.CustomerOrder.Total += 0m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (cheese == "e" || cheese == "E")
                    {
                        Program.CustomerOrder.Details.Add("Extra cheese             + $1.25");
                        Program.CustomerOrder.Total += 1.25m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    
                    Console.WriteLine("              ");

                    Console.WriteLine("D)elivery or T)ake out? (One is required)");
                    string delivery = Console.ReadLine();
                    if (delivery == "D" || delivery == "d")
                    {
                        Program.CustomerOrder.Details.Add("Delivery                 + $2.25");
                        Program.CustomerOrder.Total += 2.25m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                    else if (delivery == "t" || delivery == "T")
                    {
                        Program.CustomerOrder.Details.Add("Take Out                 + $0.00");
                        Program.CustomerOrder.Total += 0m;

                        Console.WriteLine("Cart total is $" + CustomerOrder.Total);
                        Console.WriteLine("          ");
                    }
                }
            

            if (input == "d" || input == "D")
            {
                    Console.WriteLine("          ");
                    CustomerOrder.Details.ToList().ForEach(Console.WriteLine);
                    Console.WriteLine("Cart total is              $" + CustomerOrder.Total);
                    Console.WriteLine("                 ");
                }
            };

        }
       

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
