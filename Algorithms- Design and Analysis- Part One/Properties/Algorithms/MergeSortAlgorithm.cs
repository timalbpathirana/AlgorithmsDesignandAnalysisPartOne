using System;

namespace Algorithms__Design_and_Analysis__Part_One.Properties.Algorithms
{
    public class MergeSortAlgorithm : IAlgorithmsStrategy
    {
        public void SortNumbers(int [] arrayToSort)
        {
            
            MergeSort(arrayToSort);
            Console.WriteLine("Sorted Array: " + string.Join(", ", arrayToSort));

        }
        
        void MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return;
    
            int middle = arr.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[arr.Length - middle];

            for (int i = 0; i < middle; i++)
                left[i] = arr[i];

            for (int i = middle; i < arr.Length; i++)
                right[i - middle] = arr[i];

            MergeSort(left);
            MergeSort(right);

            int leftIndex = 0;
            int rightIndex = 0;
            int arrIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] <= right[rightIndex])
                    arr[arrIndex++] = left[leftIndex++];
                else
                    arr[arrIndex++] = right[rightIndex++];
            }

            while (leftIndex < left.Length)
                arr[arrIndex++] = left[leftIndex++];

            while (rightIndex < right.Length)
                arr[arrIndex++] = right[rightIndex++];

        }
    }
}