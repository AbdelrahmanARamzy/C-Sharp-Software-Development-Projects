using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommonElementsInTwoArrays
{
    /* SUMMARY
    Time Complexity: O(n*n) n^2.
    Using two loops in RepeatedNumbers method. 
    the outer loop picks elements one after another and count 
    the number of occurrences of the picked element in the inner loop.
    */
    class FindCommonElementsInTwoArrays
    {
        static void RepeatedNumbers(int[] array, int arraySize)
        {
            int i, j;

            Console.Write("Repeated elements of the given array are: ");

            //outer loop
            for (i = 0; i < arraySize; i++)
            {
                //inner loop
                for (j = i + 1; j < arraySize; j++)
                {
                    if (array[i] == array[j])
                        Console.Write(array[i] + " ");
                }
            }
            Console.ReadKey();
        }

        public static void Main()
        {
            int[] array = { 5, 3, 9, 8, 7, 6, 5, 3, 2, 6, 4, 8 };
            int arraySize = array.Length;

            RepeatedNumbers(array, arraySize);
        }
    }
}
