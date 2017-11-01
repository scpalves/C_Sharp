using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare an array of integers that are not sorted
            int[] nums = { 5, 10, 3, 2, 4 };

            // Output the unsorted array to the console
            Console.WriteLine("Before: 5, 10, 3, 2, 4");

            // Use this to know when to stop the sorting routine
            bool swapped;

            do
            {
                swapped = false;
                for(int i = 0; i < nums.Length - 1;i++)
                {
                    if(nums[i] > nums[i+1])
                    {
                        int temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);

            // output the sorted array to the console
            Console.Write("After: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }

            // Use Console.ReadLine() in the event application was started with debugging.
            Console.ReadLine();
        }
    }
}
