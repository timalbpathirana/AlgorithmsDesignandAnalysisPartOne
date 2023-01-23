using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Algorithms__Design_and_Analysis__Part_One.Properties.Algorithms
{
    public class MergeSortAlgorithm : IAlgorithmsStrategy
    {
        public void SortNumbers(int [] arrayToSort)
        {
            int[] f = { 1, 2, 7,4,56 };
            var last = MergeSort(arrayToSort, 0, arrayToSort.Length - 1);
            foreach (var i in last)
            {
                Console.WriteLine(i);
            }

        }

        private static int[] MergeSort(int[] array, int start, int end)
        {
            // to terminate the recursive loop, we need the termination check,
            // in here; when one element in list, the starting ele and end ele is same.

            if (start >= end)
            {
                return new int[] { array[end]};
            }
            var middlePoint = (start + end) / 2; // Getting the mid point of the array
            var leftArray = MergeSort(array, start, middlePoint);
            var rightArray = MergeSort(array, middlePoint + 1, end);
            var toReturn = Sort(rightArray, leftArray);
            return toReturn;
        }
        
        // Sort method 
        private static int[] Sort(IReadOnlyList<int> fArray, IReadOnlyList<int> sArray) // this is taking 2 SORTED Arrays and returns the merged array
        {
            int fIndex = 0;
            int sIndex = 0;
            int oIndex = 0;
            var outArray = new int[fArray.Count + sArray.Count];


            while (fIndex < fArray.Count && sIndex < sArray.Count)
            {
                if (fArray[fIndex] < sArray[sIndex])
                {
                    outArray[oIndex] = fArray[fIndex];
                    fIndex++;
                }
                else
                {
                    outArray[oIndex] = sArray[sIndex];
                    sIndex++;
                }
                oIndex++;
            }

            while (fIndex < fArray.Count)
            {
                outArray[oIndex] = fArray[fIndex];
                fIndex++;
                oIndex++;
            }
            
            while (sIndex < sArray.Count)
            {
                outArray[oIndex] = sArray[sIndex];
                sIndex++;
                oIndex++;
            }

            return outArray;

        }
    }
}