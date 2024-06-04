namespace ShellSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--SHELL SORT--");
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
    }
}
