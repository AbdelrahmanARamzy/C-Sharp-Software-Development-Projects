using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommonElementsInArray
{
    class FindCommonElementsInArray
    {
        /* SUMMARY
        We can first sort the array and then iterate over it to find duplicates. 
        This will get us O(nlogn) time complexity.
        First, We check for sign of array element
        if positive then make it negative
        else means that the element is negative
        which means it's repeated.
        */
        static void printRepeating(int[] array, int arraySize)
        {
            int i;
            Console.Write("Repeated elements of the given array are :");

            for (i = 0; i < arraySize; i++)
            {
                if (array[Math.Abs(array[i])] >= 0)
                {
                    array[Math.Abs(array[i])] = -array[Math.Abs(array[i])];
                }
                else {
                    Console.Write(Math.Abs(array[i]) + " ");
                }
            }
            Console.ReadKey();
        }
        public static void Main()
        {
            int[] array = { 1, 2, 3, 1, 3, 6, 6 };
            int arraySize = array.Length;

            printRepeating(array, arraySize);
        }
    }
}
