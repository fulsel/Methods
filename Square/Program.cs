using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Square
{
    class Exponent
    {
        public static int Square(int num)
        {

            int square = num * num;
            return square;
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an interger: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Square(num);
            int square = Square(num);
            Console.WriteLine("The square is {0}.", square);
        }
    }
}
