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
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Sum of values in array: {0}", SumArray(arr));
            Console.ReadLine();
        }


    }
}

