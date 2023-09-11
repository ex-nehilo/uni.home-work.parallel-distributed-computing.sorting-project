using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni.home_work.parallel_distributed_computing.sorting_project.Sorting
{
    internal class ShellSorter : Sorter
    {
        public ShellSorter(int itemCount) : base(itemCount) {}

        public ShellSorter(int itemCount, Random rnd) : base(itemCount, rnd) {}

        public override void sort()
        {
            DateTime start = DateTime.Now;
            int shellLength = ItemCount / 2;
            while(shellLength >= 1)
            {
                for (int i = shellLength; i < ItemCount; i++)
                {
                    int j = i;
                    while ((j >= shellLength) && (Items[j-shellLength] > Items[j]))
                    {
                        Compares++;

                        Swap(ref Items[j], ref Items[j-shellLength]);
                        j -= shellLength;
                    }
                    Compares++;
                }
                shellLength /= 2;
            }
            DateTime end = DateTime.Now;

            Time = (end - start);
        }
        private void Swap(ref int a, ref int b)
        {
            Swaps++;
            (b, a) = (a, b);
        }
    }
}
