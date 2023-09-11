using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uni.home_work.parallel_distributed_computing.sorting_project.Sorting
{
    abstract class Sorter
    {
        private int itemCount; //Количество элементов массива
        private int[] elements; //Массив элементов
        private int comparesCount = 0; //Количество сравнений
        private int swapCount = 0; //Количество перестановок
        private bool terminated = false;
        private TimeSpan time;
        //onTerminate TODO
        private Random rnd;
        public int Compares { get { return comparesCount; } set { comparesCount = value; } }
        public int ItemCount { get { return itemCount; } }
        public int[] Items { get { return elements; } set { elements = value; } }
        public int Swaps { get { return swapCount; } set { swapCount = value; } }
        public bool Terminated { get { return terminated; } set { terminated = value; } }
        public TimeSpan Time { get { return time; } set { time = value; } }
        public Sorter(int itemCount)
        {
            this.itemCount = itemCount;
        }
        public Sorter(int itemCount, Random rnd)
        {
            this.itemCount = itemCount;
            this.rnd = rnd;
        }
        public abstract void sort();
    }
}
