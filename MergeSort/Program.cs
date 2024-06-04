namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };

            Console.Write("unsorted List: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            int mid = (array.Length/2);
            MergeSort(array, 0, array.Length - 1);

            Console.Write("\nsorted List: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void MergeSort(int[] array, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                MergeSort(array, l, m);
                MergeSort(array, m + 1, r);
                Merge(array, l, m, r);
            }
        }
        private static void Merge(int[] array, int l, int m, int r)
        {
            int leftArrayLength = m - l + 1;
            int rightArrayLength = r - m;

            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];

            for (int i = 0; i < leftArrayLength; i++)
            {
                leftArray[i] = array[l + i];
            }

            for (int j = 0; j < rightArrayLength; j++)
            {
                rightArray[j] = array[m + 1 + j];
            }

            int k = l;
            int leftIndex = 0, rightIndex = 0;

            while (leftIndex < leftArrayLength && rightIndex < rightArrayLength)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    array[k] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[k] = rightArray[rightIndex];
                    rightIndex++;
                }
                k++;
            }

            while (leftIndex < leftArrayLength)
            {
                array[k] = leftArray[leftIndex];
                leftIndex++;
                k++;
            }

            while (rightIndex < rightArrayLength)
            {
                array[k] = rightArray[rightIndex];
                rightIndex++;
                k++;
            }
        }
    }
}
