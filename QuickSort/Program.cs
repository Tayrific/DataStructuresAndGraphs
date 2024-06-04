namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---QUICK SORT---");
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };

            Console.Write("unsorted List: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }         
            QuickSort(array, 0, array.Length-1);

            Console.Write("\nsorted List: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void Swap(int[] array, int swap1, int swap2) //method to swap elements
        {
            int temp = swap1;
            array[swap1] = array[swap2];
            array[swap2] = temp;

        }

        private static int Partition(int[] array, int left, int right) // selecting pivot and swapping values with it
        {
            int ind = left;
            int pivot = array[ind];

            for (int i = left + 1; i <=right; i++)
            {
                if (array[i] <= pivot)
                {
                    ind++;
                    Swap(array, ind, i);
                }

            }

            Swap(array, ind, left);
            return ind;
        }

        private static void QuickSort(int[] array, int left, int right) //called recursively with different boundaries
        {
            if (left < right) //if left < right it means we have an array with atleast 2 elements
            {
                var pi = Partition(array, left, right);
                QuickSort(array, left, pi - 1); //recursively calling quicksort on left array
                QuickSort(array, pi + 1, right); //on right array
            }
        }
    }
}
