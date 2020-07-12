using System; 

namespace Sorting
{
    public class SelectionSort : SortingAlgorithm
    {
        public override void Sort(int[] items)
        {
            int sortedRangeEnd = 0;

            while (sortedRangeEnd < items.Length)
            {
                int nextIndex = FindIndexOfSmallestFromIndex(items, sortedRangeEnd);
                Swap(ref items[sortedRangeEnd], ref items[nextIndex]);
                sortedRangeEnd++;
            }
        }

        private int FindIndexOfSmallestFromIndex(int[] items, int sortedRangeEnd)
        {
            int currentSmallest = items[sortedRangeEnd];
            int currentSmallestIndex = sortedRangeEnd;
            for (int i = sortedRangeEnd + 1; i < items.Length; i++)
            {
                if (Compare(currentSmallest, items[i]) > 0)
                {
                    currentSmallest = items[i];
                    currentSmallestIndex = i;
                }
            }

            return currentSmallestIndex;
        }
    }
}
