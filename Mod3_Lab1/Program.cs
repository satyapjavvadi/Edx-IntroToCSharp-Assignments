using System;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int result = Sum(20, 40);
            Console.WriteLine($"The sum() with two arguments and the result is : {result}");

            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"Calling sum with 3 argumnets : {result3}");

            double dbresult = Sum(20.5, 30.4);
            Console.WriteLine($"Calling Sum() that takes double result : {dbresult}");
        }
        static int Sum(int first, int second)
        {
            int sum = first + second;
            // Console.WriteLine($"The sum of {first} and {second} is : {sum}");
            return sum;
        }
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }
        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
