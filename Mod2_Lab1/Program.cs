﻿using System;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer value and press enter.");
            int input = Int32.Parse(Console.ReadLine());

            if(input % 2 == 0)
            {
                Console.WriteLine("The entered number was an even number");
            }
            else
            {
                Console.WriteLine("The entered number was not an even number");
            }
        }
    }
}
