using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni.home_work.parallel_distributed_computing.sorting_project.Sorting
{
    internal class BubbleSorter : Sorter
    {
        public BubbleSorter(int itemCount) : base(itemCount) {}

        public BubbleSorter(int itemCount, Random rnd) : base(itemCount, rnd) {}

        public override void sort()
        {
            DateTime start = DateTime.Now;
            for (int i = 1; i < ItemCount; i++)
                for (int j = 0; j < ItemCount - i; j++)
                {
                    if (Items[j] > Items[j+1])
                    {
                        Compares++;
                        Swap(ref Items[j], ref Items[j+1]);
                    }
                    else
                        Compares++;
                }
            DateTime finish = DateTime.Now;
            Time = (finish - start);
        }

        private void Swap(ref int elLeft, ref int elRight)
        {
            (elRight, elLeft) = (elLeft, elRight);
            Swaps++;
        }
    }
}
