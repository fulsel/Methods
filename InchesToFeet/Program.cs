using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet
{
    class InchesToFeet
    {

        public static void InchesToF(int inches)
        {
            
            int feet = inches / 12;
            int remainder = inches % 12;
            Console.WriteLine("{0} feet and {1} inches.", feet, remainder);

        }

        public static void InchesToYards(int inches)
        {

            int feet = inches / 12;
            int yards = feet / 3;
            int feetremainder = feet - (yards*3);

            int remainderinches =  inches % 12;
            Console.WriteLine("{0} yards, {1} feet and {2} inches.", yards, feetremainder, remainderinches);

        }

        
        static void Main(string[] args)
        {
            int inches = 71;
            InchesToYards(inches);
        }
    }
}
