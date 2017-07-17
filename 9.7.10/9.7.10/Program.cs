using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7._10
{
    class Program
    {
        public static int[][] splitArray(int[] array)
        {
            int first = 0;
            int last = array.Length - 1;
            int mid = (first + last) / 2;
            int[] array2 = new int[mid];
            int[] array3 = new int[last - mid];
            int[][] arrayArray = new int[2][];
            if (array.Length > 2)
            {
                mid = (first + last)/ 2;
            }
            for (int i = first; i < mid; i++)
            {
                array2[i] = array[i]; 
            }
            for (int h = mid; h < array.Length; h++)
            {
                array3[first] = array[h];
            }
            arrayArray[0] = array2;
            arrayArray[1] = array3;
            return arrayArray;
        }

        public static int[] mergeSort(int[][] arrays)
        {
            int[] array = arrays[0];
            int[] array2 = arrays[1];
            int[] mergedArray = new int[array.Length + array2.Length];
            int lLow = 0;
            int rLow = 0;
            int high = array2.Length;
            int mid = array.Length;
            int index = 0;

            while (lLow < mid && rLow < high)
            {
                if (array[lLow] < array2[rLow])
                {
                    mergedArray[index] = array[lLow];
                    lLow++;
                    index++;
                }
                else if (array[lLow] > array2[rLow])
                {
                    mergedArray[index] = array2[rLow];
                    rLow++;
                    index++;
                }
            }
            return mergedArray;
        }

        static void Main(string[] args)
        {
            //initialize array
            int[] array = new int[10] {1, 2, 4, 5, 8, 2, 3, 4, 5, 6};
            //split the array to sort individually
            int[][] split = splitArray(array);
            //sort and merge array by comparint the indexes of each array
            int[] merged = mergeSort(split);

            for (int i = 0; i < merged.Length; i++)
            {
                Console.WriteLine(merged[i]);
            }
        }
    }
}
