using System.Diagnostics;

namespace SortingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Funkcja pomocnicza do pobierania danych z TextBox i tworzenia tablicy
        private int[] GetArrayFromInput()
        {
            // Pobiera dane z TextBox i tworzy tablic� liczb
            string input = textBoxInput.Text;
            string[] tokens = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = tokens.Select(int.Parse).ToArray();
            return array;
        }

        // Funkcja pomocnicza do wy�wietlania tablicy w ListBox
        private void DisplayArray(int[] array)
        {
            listBoxResults.Items.Clear();
            listBoxResults.Items.AddRange(array.Select(x => x.ToString()).ToArray());
        }

        // Bubble Sort
        private void BubbleSort(int[] array)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            time.Stop();
            label1.Text = "Time: " + time.ElapsedTicks;
        }

        // Quick Sort
        private void QuickSort(int[] array, int left, int right)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
            label1.Text = "Time: " + time.ElapsedTicks;
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int swapTemp = array[i + 1];
            array[i + 1] = array[right];
            array[right] = swapTemp;

            return i + 1;
        }

        // Merge Sort
        private void MergeSort(int[] array, int left, int right)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
            label1.Text = "Time: " + time.ElapsedTicks;
        }

        private void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[middle + 1 + j];

            int iIndex = 0, jIndex = 0;
            int k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    array[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    array[k] = rightArray[jIndex];
                    jIndex++;
                }
                k++;
            }

            while (iIndex < n1)
            {
                array[k] = leftArray[iIndex];
                iIndex++;
                k++;
            }

            while (jIndex < n2)
            {
                array[k] = rightArray[jIndex];
                jIndex++;
                k++;
            }
        }

        // Insertion Sort
        private void InsertionSort(int[] array)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            label1.Text = "Time: " + time.ElapsedTicks;
        }

        // Counting Sort
        private void CountingSort(int[] array)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            int max = array.Max();
            int min = array.Min();
            int range = max - min + 1;

            int[] count = new int[range];
            int[] output = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
                count[array[i] - min]++;

            for (int i = 1; i < count.Length; i++)
                count[i] += count[i - 1];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[count[array[i] - min] - 1] = array[i];
                count[array[i] - min]--;
            }

            for (int i = 0; i < array.Length; i++)
                array[i] = output[i];
            label1.Text = "Time: " + time.ElapsedTicks;
        }

        // Selection Sort
        private void SelectionSort(int[] array)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            label1.Text = "Time: " + time.ElapsedTicks;
        }

        // Wywo�anie sortowania po klikni�ciu przycisk�w

        // Wywo�anie Bubble Sort
        private void buttonBubbleSort_Click(object sender, EventArgs e)
        {
            int[] array = GetArrayFromInput();
            BubbleSort(array);
            DisplayArray(array);
        }

        private void buttonQuickSort_Click(object sender, EventArgs e)
        {
            int[] array = GetArrayFromInput();
            QuickSort(array, 0, array.Length - 1);
            DisplayArray(array);
        }

        private void buttonMergeSort_Click(object sender, EventArgs e)
        {
            int[] array = GetArrayFromInput();
            MergeSort(array, 0, array.Length - 1);
            DisplayArray(array);
        }

        private void buttonInsertionSort_Click(object sender, EventArgs e)
        {
            int[] array = GetArrayFromInput();
            InsertionSort(array);
            DisplayArray(array);
        }

        private void buttonCountingSort_Click(object sender, EventArgs e)
        {
            int[] array = GetArrayFromInput();
            CountingSort(array);
            DisplayArray(array);
        }

        private void buttonSelectionSort_Click(object sender, EventArgs e)
        {
            int[] array = GetArrayFromInput();
            SelectionSort(array);
            DisplayArray(array);
        }
    }
}
