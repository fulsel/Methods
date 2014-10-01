using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram
{
    class Monogram
    {

        public static void MyInitials(string first, string middle, string last)
        {

            Console.WriteLine("** {0}, {1}, {2} **", first, middle, last);

        }

        public static void FriendInitials(string friendfirst, string friendmiddle, string friendlast)
        {

            Console.WriteLine("** {0}, {1}, {2} **", friendfirst, friendmiddle, friendlast);

        }
        
        
        
        static void Main(string[] args)
        {
            string first = "J";
            string middle = "R";
            string last = "Q,";
            MyInitials(first, middle, last);
            string friendfirst = "L";
            string friendmiddle = "L";
            string friendlast = "F,";
            FriendInitials(friendfirst, friendmiddle, friendlast);


        }
    }
}
