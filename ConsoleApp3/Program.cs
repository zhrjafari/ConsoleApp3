using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace project
{
    class test1
    {
        public static void Main()
        {
            Console.WriteLine("enter x");
            int x = Convert.ToInt32(Console.ReadLine());
            Calc(x);
        }//end main

        private static void Calc(int x)
        {
            double Result = Math.Pow(x, 2) + (2 * x) - 4;
            Console.WriteLine(Result);
        }
    }
}