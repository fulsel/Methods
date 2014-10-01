using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse4
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
            int middleinta = 2;
            int middleintb = 3;
            int lastint = 4;
            Console.WriteLine("First: {0} Second: {1} Third: {2} Fourth: {3}", firstint, middleinta, middleintb, lastint);
        }
    }
}
