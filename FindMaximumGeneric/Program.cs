﻿namespace FindMaximumGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum using generics");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find maximum integer\n2:Find maximum float\n3:Find maximum string");
            int option = Convert.ToInt32(Console.ReadLine());
            FindMaximum findMaximum = new FindMaximum();
            switch (option)
            {
                case 1:
                    findMaximum.FindMaxInt(12, 36, 46);
                    break;
                case 2:
                    findMaximum.FindMaxFloat(23.25F, 30.45F, 50.10F);
                    break;
                case 3:
                    findMaximum.FindMaxString("Apple", "Banana", "Pear");
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}