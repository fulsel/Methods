using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse4
{
    class Program
    {
        public static void Reverse(ref int a, ref int b, ref int c, ref int d)
        {
            a = 4;
            b = 3;
            c = 2;
            d = 1;
        }

        
        static void Main(string[] args)
        {
            int firstint = 1;
            int middleinta = 2;
            int middleintb = 3;
            int lastint = 4;

            Reverse(ref firstint, ref middleinta, ref middleintb, ref lastint);


            Console.WriteLine("First: {0} Second: {1} Third: {2} Fourth: {3}", firstint, middleinta, middleintb, lastint);

        }
    }
}
