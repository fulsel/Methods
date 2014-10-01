using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverses_3_4
{
    class Program
    {
        public static int First(int firstint, int middleint, int lastint)
        {
            int transfer = firstint;
            firstint = lastint;
            lastint = transfer;
            return firstint;            
        }

        public static int Last(int firstint, int middleint, int lastint)
        {
            int transfer = firstint;
            firstint = lastint;
            lastint = transfer;
            return lastint;
        }
        
        
        static void Main(string[] args)
        {
            int firstint = 1;
            int middleint = 2;
            int lastint = 3;
            Console.WriteLine("First: {0} Second: {1} Third: {2}", firstint, middleint, lastint);
            First(firstint, middleint, lastint);
            Last(firstint, middleint, lastint);
            int newfirst = First(firstint, middleint, lastint);
            int newlast = Last(firstint, middleint, lastint);
            Console.WriteLine("First: {0} Second: {1} Third: {2}", newfirst, middleint, newlast);

        }
    }
}
