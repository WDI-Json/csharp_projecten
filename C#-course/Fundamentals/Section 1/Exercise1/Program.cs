using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        //Exercise 1:
        /*
         * Build a simple calculator. Read in two integers from the user and add them together. Print the results
         * in a nice output statement.
         * 
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int answer = firstNumber + secondNumber;

            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, answer);

        }
    }
}
