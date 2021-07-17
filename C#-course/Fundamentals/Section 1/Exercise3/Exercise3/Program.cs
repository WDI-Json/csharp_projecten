using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int minutes;
            int leftoverminutes;
            double hours;

            Console.WriteLine("Greetings! Welcome to exercise 3. What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What is the total amount of time you have worked today? Give your answer in minutes");
            minutes = int.Parse(Console.ReadLine());
            hours = Math.Round(Convert.ToDouble(minutes) / 60,2);
            leftoverminutes = minutes - (Convert.ToInt32(hours) * 60);

            Console.WriteLine($"Hello {name} \n You have worked {minutes} minutes. This means you have worked {hours} hours and {leftoverminutes} minutes!");
        }
    }
}
