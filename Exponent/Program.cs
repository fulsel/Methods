using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent
{
    class Exponent
    {
        public static int Square(int num)
        {

            int square = num * num;
            return square;
        }

        public static int Cube(int num)
        {

            int cube = num * num * num;
            return cube;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an interger: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Square(num);
            int square = Square(num);
            Cube(num);
            int cube = Cube(num);
            Console.WriteLine("The square is {0}.", square);
            Console.WriteLine("The cube is {0}. ", cube);
        }
    }
}
