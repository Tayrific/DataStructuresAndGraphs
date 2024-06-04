using System.ComponentModel.Design;

namespace MoreArrays
{
    internal class Program
    {
        public static int SumArray(int[] arr) //Adds all the numbers within an array together 
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return total;
        }

        public static int SequentialSearch(int[] arr, int size, int value) //Searches an array to see if a value is present using linear search
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

        public static int BinarySearch(int[] arr, int size, int value) //Searches an array to see if a value is present using binary search
        { 
            //only works on a sorted list
            int mid;
            int low = 0;
            int high = size - 1;
            while (low <= high)
            {
                mid = low + (high - low) / 2; //middle of the array
                if (arr[mid] == value) 
                {
                    return (mid+1);//if mid is the value its returned
                } 
                if (arr[mid] < value)
                {
                    low = mid + 1; //if value is bigger than mid then the lowest position it could be is mid + 1
                }
                else
                {
                    high = mid - 1; //if value is smaller than mid then the highest position it could be is mid - 1
                }
            }
            return -1;
        }


        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 20 };
            Console.WriteLine("Sum of values in array: {0}", SumArray(arr));
            Console.WriteLine("--------------------------------");

            Console.Write("Enter a number to search for within array: ");
            int searchNum = Convert.ToInt32(Console.ReadLine());
            SequentialSearch(arr, arr.Length, searchNum);
            Console.WriteLine("--------------------------------");

            Console.Write("Enter a number to find its position within the array: ");
            searchNum = Convert.ToInt32(Console.ReadLine());
            int result = BinarySearch(arr, arr.Length, searchNum);
            if (result == -1)
            {
                Console.WriteLine("does not exist within your array");
            }
            else
            {
                Console.WriteLine("{0} occurs at position :  {1}", searchNum, result);
            }

            Console.ReadLine();
        }


    }
}

