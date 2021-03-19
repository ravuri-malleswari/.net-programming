using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("enter the first number");
                int x = int.Parse(Console.ReadLine());
                Console.Write("enter the second number");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("the result is :" + z);
            }
            catch(DivideByZeroException ex1)
            {
                Console.Write(ex1.Message);
            }
            catch(FormatException ex2)
            {
                Console.Write("input must be a numeric");
            }
            catch(Exception ex)
            {
                Console.Write("ex.message");
            }
            Console.WriteLine("end of the program");
            Console.ReadLine();
        }
    }
}
