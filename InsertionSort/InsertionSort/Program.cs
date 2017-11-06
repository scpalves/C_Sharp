using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an integer array that is not sorted
            int[] arr = { 7, 8, 4, 6, 2, 1 };

            Console.Write("Array before sort: ");

            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            int newValue;

            for(int i = 1; i < arr.Length; i++)
            {
                newValue = arr[i];

                int j = i;
                while(j > 0 && arr[j-1] > newValue)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = newValue;
            }
            Console.Write("Array after sort: ");
            foreach (int val in arr)
            {
                Console.Write(val + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
