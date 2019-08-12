using System;

namespace Mod2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int LeftOver = 0;
            for (int i = 0; i < 8; i++)
            { 
                LeftOver = i % 2 == 0 ?  1 :  0;

                for (int j = 0; j < 8; j++)
                {
                        if ( j % 2 == LeftOver)
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write("X");
                        }   
                }
                Console.WriteLine();
            }
        }
    }
}
