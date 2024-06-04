namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--INSERTION SORT--");
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            Console.Write("Unsorted List:");
            Arr_element(array);
            int size = array.Length;

            InsertionSort(array);

            Console.Write("Sorted List: ");
            Arr_element(array);

            Console.ReadLine();
        }

        private static void Arr_element(int[] array)
        {
            foreach (var elem in array)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++) //starts at the 2nd value
            {
                int temp; 
                temp = array[i]; //current value that we are sorting stored in temp

                int j = i - 1; //comparing to values before it

                while(j >= 0 && array[j] > temp) 
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j+1] = temp;
            }
        }
    }
}
