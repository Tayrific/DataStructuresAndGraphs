using System.ComponentModel.Design;

namespace MoreArrays
{
    internal class Program
    {
        public static int SumArray(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return total;
        }

        public static int SequentialSearch(int[] arr, int size, int value)
        {
            int numFound;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                {
                    numFound = arr[i];
                    Console.WriteLine("value was found!");
                    return numFound;
                }
            }
            Console.WriteLine("Value was not found!");
            return -1;
        }

        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Sum of values in array: {0}", SumArray(arr));
            Console.WriteLine("--------------------------------");

            Console.Write("Enter a number to search for within array: ");
            int searchNum = Convert.ToInt32(Console.ReadLine());
            SequentialSearch(arr, arr.Length, searchNum);

            Console.ReadLine();
        }


    }
}

