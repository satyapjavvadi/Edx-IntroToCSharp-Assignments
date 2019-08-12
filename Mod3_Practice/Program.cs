using System;

namespace Mod3_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            string sValue;
            ReturnMultiOut(out first, out sValue);
            Console.WriteLine($"{first}, {sValue}");


            void ReturnMultiOut(out int i, out string s)
            {
                i = 25;
                s = "Using out";
            }


            string tValue = "";
            int second = 0;
            ReturnMultiRef(ref second, ref tValue);
            Console.WriteLine($"{second}, {tValue}");

            void ReturnMultiRef(ref int i, ref string s1)
            {
                i = 50;
                s1 = "using ref";
            }
        }
    }
}
