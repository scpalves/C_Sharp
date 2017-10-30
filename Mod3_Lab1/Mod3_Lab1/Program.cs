using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(20, 40);
            
            int result = Total(30, 70);
            Console.WriteLine($"The sum of 30 and 70 is {result}");

            Product(out int first,out int second, out int third);
            int res = Sum(first, second, third);
            Console.WriteLine($"The sum of {first} ,{second} and {third} is {res}");

            Console.ReadKey();
        }

        // Sum() method that takes two integer arguments and sums them
        // The method returns no value which is why we use void
        // We also need to use static in the method signature because Main is static
        // and you cannot call a non-static method from a static method

        static void Sum(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine($"The sum of {first} and {second} is: {sum}");
        }

        static int Sum(int first, int second, int third)
        {
            return first + second + third;
        }

        static int Total (int first, int second)
        {
            return first + second;
        }

        static void Product(out int first, out int second, out int third)
        {
            first = 30;
            second = 40;
            third = 50;
        }
    }
}
