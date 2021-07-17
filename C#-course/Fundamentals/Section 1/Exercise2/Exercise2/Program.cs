using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double squared;
            double costs;
            const double price = 14.95;

            Console.WriteLine("What is the length of your room?");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of your room?");
            width = double.Parse(Console.ReadLine());
            squared = length * width;
            costs = squared * price;
            
            Console.WriteLine($"In total the costs per square m2 is {price},-. You gave a length of {length}m and width of {width}m.");
            Console.Write($"Which makes it in total {squared}m2 which we can handle for a total price of {costs},-");
        }
    }
}
