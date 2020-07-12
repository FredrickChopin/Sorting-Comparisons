using System;


namespace Sorting
{
    public class InsertionSort : SortingAlgorithm
    {
        public override void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1; 
                while (j >= 0 && Compare(arr[j], key) > 0)
                {
                    Swaps++;
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
    }
}
