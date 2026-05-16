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
            float num1;
            float num2;

            float result;

            string answer;

            Console.WriteLine("Hello, welcome to the calculator program!");
            
            Console.WriteLine("Please enter the first number");
            num1= float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter A for addition, S for subtraction, M for multiplication or any other key for division");

            answer = Console.ReadLine();

            if (answer == "A")
            {
                result = num1 + num2;
            }

            else if (answer == "S")
            {
                result = num1 - num2;
            }

            else if (answer == "M") 
            {
                result = num1 * num2;
            }

            else
            {
                result = num2 ==0? float.NaN: num1 / num2;
            }

            if (float.IsNaN(result))
            {
                Console.WriteLine("Cannot divide by 0!");
            }

            else
            {
                Console.WriteLine("The result is " + result);
            }
           
            Console.WriteLine("Thank you for using the calculator program!");

            Console.ReadKey();
        }
    }
}
