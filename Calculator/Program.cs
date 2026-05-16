using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Hello, welcome to the calculator program!");
            
            Console.WriteLine("Please enter the first number");
            num1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
