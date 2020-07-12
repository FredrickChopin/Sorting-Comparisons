using System;  

namespace Sorting
{
    public class MergeSort : SortingAlgorithm
    {
        public override void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1, new int[array.Length]);
        }

        public void Sort(int[] array, int left, int right, int[] temp)
        {
            if (left >= right) return;
            int mid = (right + left) / 2;
            Sort(array, left, mid, temp);
            Sort(array, mid + 1, right, temp);
            Merge(array, left, right, mid, temp);
        }

        public void Merge(int[] array, int leftStart, int rightEnd, int mid, int[] temp)
        {
            int left = leftStart;
            int right = mid + 1;
            int curr = leftStart;
            while (left <= mid && right <= rightEnd)
            {
                int comparison = Compare(array[left], array[right]);
                if (comparison < 1)
                {
                    temp[curr] = array[left++];
                }
                else
                {
                    temp[curr] = array[right++];
                }
                curr++;
            }
            Array.Copy(array, left, temp, curr, mid - left + 1);
            Array.Copy(array, right, temp, curr, rightEnd - right + 1);
            Array.Copy(temp, leftStart, array, leftStart, rightEnd - leftStart + 1);
            Swaps += rightEnd - leftStart + 1;
        }
    }
}
