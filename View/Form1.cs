using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using uni.home_work.parallel_distributed_computing.sorting_project.Sorting;

namespace uni.home_work.parallel_distributed_computing.sorting_project
{
    public partial class Form1 : Form
    {
        private int[] elements;
        private List<Sorter> sorters = new List<Sorter>(3);
        private List<RichTextBox> fields = new List<RichTextBox>(3);
        private List<Thread> threads = new List<Thread>(3);
        private List<Label> labelsForSwitches = new List<Label>(3);
        private List<Label> labelsForCompares = new List<Label>(3);
        private List<Label> labelsForTimers = new List<Label>(3);

        private delegate void SetRichTextBox(Form form, Control control, Sorter sorter);

        public Form1()
        {
            InitializeComponent();
        }

        private void executeSortingButton_Click(object sender, EventArgs e)
        {
            int itemCount = Convert.ToInt32(inputSizeOfArrayBox.Text);
            initSorters(itemCount);
            fillSorterItems(singletonGetItems(itemCount));


            if (changeToSuccessivelySortingRadio.Checked)
                successivelyExecution();
            else
                parallelyExecution();

        }
        private void fillAllLabels()
        {
            fillLabelForBubbleSorter();
            fillLabelForShellSorter();
            fillLabelForQSSorter();
        }
        private void fillLabelForShellSorter()
        {
            labelForComShell.Text += sorters[1].Compares.ToString();
            labelForSwShell.Text += sorters[1].Swaps.ToString();
            labelForTimeShell.Text += sorters[1].Time.TotalSeconds.ToString();
        }
        private void fillLabelForBubbleSorter()
        {
            labelForComBubble.Text += sorters[0].Compares.ToString();
            labelForSwBubble.Text += sorters[0].Swaps.ToString();
            labelForTimeBubble.Text += sorters[0].Time.TotalSeconds.ToString();
        }
        private void fillLabelForQSSorter()
        {
            labelForComQuick.Text += sorters[2].Compares.ToString();
            labelForSwQuick.Text += sorters[2].Swaps.ToString();
            labelForTimeQuick.Text += sorters[2].Time.TotalSeconds.ToString();
        }
        private void successivelyExecution()
        {
            sortSorters();
            //sortersToView();
            fillAllLabels();
        }
        private void initThreadPool()
        {
            threads.Add(new Thread(bubbleSortExecution));
            threads.Add(new Thread(shellSortExecution));
            threads.Add(new Thread(qsSortExecution));
        }
        private void parallelyExecution()
        {
            initThreadPool();

            foreach (Thread thread in threads)
            {
                thread.Start();
            }
        }
        private int[] singletonGetItems(int itemCount)
        {
            if (elements != null)
                return elements;

            elements = new int[itemCount];
            Random rnd = new Random(); ;
            for (int i = 0; i < elements.Length; i++)
                elements[i] = rnd.Next(0, 50);
            return elements;
        }
        private void initSorters(int itemCount)
        {
            sorters.Add(new BubbleSorter(itemCount));
            sorters.Add(new ShellSorter(itemCount));
            sorters.Add(new QuickSorter(itemCount));
        }
        private void fillSorterItems(int[] items)
        {
            foreach(Sorter sorter in sorters)
                sorter.Items = (int[])items.Clone();
        }
        private void sortSorters()
        {
            DateTime start = DateTime.Now;

            foreach (Sorter sorter in sorters)
                sorter.sort();

            DateTime end = DateTime.Now;

            TimeSpan ts = (end - start);

            statusLabel.Text += ts.TotalSeconds.ToString();
        }
        private void setTextBox(Form form, Control control, Sorter sorter)
        {
            if(control.InvokeRequired)
                form.Invoke(new SetRichTextBox(setTextBox), new object[] {form, control, sorter});
            else
            {
                for (int i = 0; i < sorter.Items.Length;i++)
                    control.Text += $"{sorter.Items[i]}\n";
            }
        }
        private void setLabelComparesText(Form form, Control control, Sorter sorter)
        {
            if (control.InvokeRequired)
                form.Invoke(new SetRichTextBox(setLabelComparesText), new object[] { form, control, sorter });
            else
                control.Text += sorter.Compares.ToString();
        }
        private void setLabelTimeText(Form form, Control control, Sorter sorter)
        {
            if (control.InvokeRequired)
                form.Invoke(new SetRichTextBox(setLabelTimeText), new object[] { form, control, sorter });
            else
                control.Text += sorter.Time.TotalSeconds.ToString();

        }
        private void setLabelSwapsText(Form form, Control control, Sorter sorter)
        {
            if (control.InvokeRequired)
                form.Invoke(new SetRichTextBox(setLabelSwapsText), new object[] { form, control, sorter });
            else
                control.Text += sorter.Swaps.ToString();
        }

        private void bubbleSortExecution()
        {
            sorters[0].sort();
            //setTextBox(this, fields[0], sorters[0]);

            setLabelTimeText(this, labelsForTimers[0], sorters[0]);
            setLabelComparesText(this, labelsForCompares[0], sorters[0]);
            setLabelSwapsText(this, labelsForSwitches[0], sorters[0]);
        }
        private void shellSortExecution()
        {
            sorters[1].sort();
            //setTextBox(this, fields[1], sorters[1]);

            setLabelTimeText(this, labelsForTimers[1], sorters[1]);
            setLabelComparesText(this, labelsForCompares[1], sorters[1]);
            setLabelSwapsText(this, labelsForSwitches[1], sorters[1]);
        }
        private void qsSortExecution()
        {
            sorters[2].sort();
            //setTextBox(this, fields[2], sorters[2]);

            setLabelTimeText(this, labelsForTimers[2], sorters[2]);
            setLabelComparesText(this, labelsForCompares[2], sorters[2]);
            setLabelSwapsText(this, labelsForSwitches[2], sorters[2]);
        }
        private void sortersToView()
        {
            for (int i = 0; i < fields.Count; i++)
                for(int j = 0; j < sorters[i].ItemCount; j++)
                    fields[i].Text += $"{sorters[i].Items[j]}\n";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fields.Add(bubbleSortElementsToViewTextBox);
            fields.Add(shellSortElementsToViewTextBox);
            fields.Add(quickSortElementsToViewTextBox);

            labelsForCompares.Add(labelForComBubble);
            labelsForCompares.Add(labelForComShell);
            labelsForCompares.Add(labelForComQuick);

            labelsForSwitches.Add(labelForSwBubble);
            labelsForSwitches.Add(labelForSwShell);
            labelsForSwitches.Add(labelForSwQuick);

            labelsForTimers.Add(labelForTimeBubble);
            labelsForTimers.Add(labelForTimeShell);
            labelsForTimers.Add(labelForTimeQuick);
        }
    }
}
