using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni.home_work.parallel_distributed_computing.sorting_project.Sorting
{
    internal class QuickSorter : Sorter
    {
        public QuickSorter(int itemCount) : base(itemCount) {}

        public QuickSorter(int itemCount, Random rnd) : base(itemCount, rnd) {}

        public override void sort()
        {
            DateTime start = DateTime.Now;

            qs(Items, 0, ItemCount - 1);

            DateTime end = DateTime.Now;

            Time = (end - start);
        }
        private int[] qs(int[] array, int minIndex, int maxIndex)
        {
            if(minIndex >= maxIndex)
                return array;
            var pivotIndex = partition(array, minIndex, maxIndex);
            qs(array, minIndex, pivotIndex - 1);
            qs(array, pivotIndex + 1, maxIndex);
            return array;

        }
        private void Swap(ref int x, ref int y)
        {
            Swaps++;
            (y, x) = (x, y);
        }
        private int partition(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    Compares++;
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
    }
}
