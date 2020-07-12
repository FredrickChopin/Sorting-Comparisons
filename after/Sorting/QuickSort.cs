using System; 

namespace Sorting
{
    public class QuickSort : SortingAlgorithm
    {
        public override void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        public void Sort(int[] array, int left, int right)
        {
            if (left >= right) return;
            int indexOfSplit = Partition(array, left, right, array[left]);
            Sort(array, left, indexOfSplit - 1);
            Sort(array, indexOfSplit, right);
        }

        public int Partition(int[] array, int left, int right, int pivot)
        {
            while (Compare(left, right) < 1)
            {
                while (Compare(array[left], pivot) < 0)
                {
                    left++;
                }
                while (Compare(array[right], pivot) > 0)
                {
                    right--;
                }
                if (Compare(left, right) < 1)
                {
                    Swap(ref array[left], ref array[right]);
                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
