namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--SELECTION SORT--");
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };

            Console.Write("unsorted List: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            SelectionSort(array);

            Console.Write("\nsorted List: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++) 
            {
                int min = i;// setting the min val

                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[min] > array[j]) //switching the sign decides if its in ascending or descending order
                    {
                        min = j; // if j is smaller than min then min becomes j
                    }
                }
                //swapping values as min is the smallest so it should be where i is
                int temp = array[i]; 
                array[i] = array[min];
                array[min] = temp;

            }
        }
    }
}
