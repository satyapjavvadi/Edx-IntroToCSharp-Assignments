using System;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = Divide(10, 0);
            //Console.WriteLine(result);


            int first = 9;
            int second = 0;
            Console.WriteLine("Enter your first number");
            first = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter yoyr second number");
            second = Int32.Parse(Console.ReadLine());

            int result = Divide(first, second);
            Console.WriteLine($"The result is :{result}");
            
        }
        static int Divide(int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot be divide by zero");
            }
            return result;
        }
    }
}
