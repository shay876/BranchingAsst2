﻿using System;

namespace BranchingAsst2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("What is the package weight?");

            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            }
            Console.ReadLine();

            Console.WriteLine("What is the package width?");

            int width = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("What is the package height?");

            int height = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("What is the package length?");

            int length = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            if ((width + height + length) > 50)
            { Console.WriteLine("Package too big to be shipped via Package Express"); }

            else
            {
                Console.WriteLine("Your estimated total for shipping is $" + ((height * width * length) * weight) / 100 + ". Thank you!");
            }
            Console.ReadLine();







        }
    }
}

