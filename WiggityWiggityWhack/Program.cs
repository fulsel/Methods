using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WiggityWiggityWhack
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 2; a <= 14; a++)
            {
                for (int b = 2; b <= 14; b++)
                {
                    if (a * b > 14 && a + b < 14 && a + b > 0)
                        {

                          


                                Console.WriteLine("{0}, {1}", a, b);

                            
                        }
                }

            }
        }
    }



}
