using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Area
    {

        public static int Int(int length, int width)
        {
            int areaint = length * width;
            return areaint;
        }

        public static double Intdouble(int length, double Width)
        {
            double areaintdouble = length * Width;
            return areaintdouble;
        }

        public static double Double(double Length, double Width)
        {
            double areadouble = Length * Width;
            return areadouble;
        }
        
        
        static void Main(string[] args)
        {
            int length = 5;
            int width = 10;
            double Length = 7;
            double Width = 12;
            int areaint = Int(length, width);
            double areaintdouble = Intdouble(length, Width);
            double areadouble = Double(Length, Width);
            Console.WriteLine(areaint);
            Console.WriteLine(areaintdouble);
            Console.WriteLine(areadouble);
            
        }
    }
}
