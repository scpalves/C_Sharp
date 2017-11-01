using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "X";
            string str2 = "O";

            const int limit = 8;

            for(int outer = 1; outer <= limit; outer++)
            {
                for(int inner = 1; inner <= limit; inner++)
                {
                    if(outer % 2 != 0 && inner % 2 != 0 || outer % 2 == 0 & inner % 2 == 0)
                    {
                        Console.Write(str1);
                    }
                    else
                    {
                        Console.Write(str2);
                    }
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
