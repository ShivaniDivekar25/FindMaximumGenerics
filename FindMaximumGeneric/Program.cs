﻿namespace FindMaximumGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum using generics");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find maximum integer");
            int option = Convert.ToInt32(Console.ReadLine());
            FindMaximum findMaximum = new FindMaximum();
            switch (option)
            {
                case 1:
                    findMaximum.FindMaxInt(12, 36, 46);
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}