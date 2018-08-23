using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main( string[] args )
        {
            //string name;
            //name = "Bob"  *Below is more efficient
         
               string name = "Bob"; // lvalue rvalue IS (id = E sub T)
            //string Name;  not the same as above 

            double payRate = 4.5;

            Console.WriteLine(name);

            double y = 4.65;
            int x = 10; //10 is an "integer literal" 'literal = nonchanging values 10 is always 10' value of int is 10 expression = value statement = command
            Console.WriteLine("Hello world");//string literal value = "Hello world" 'Console.WriteLine is a statement'
        }
    }
}
