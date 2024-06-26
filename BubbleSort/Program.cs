﻿public class BubbleSort
{
    public void Sort(int[] arr)
    {
        int size = arr.Length;
        int i, j, temp;
        for (i = 0; i < (size - 1); i++)
        {
            for (j = 0; j < size - i - 1; j++)
            {
                if ((arr[j] > arr[j + 1]))
                {
                    /* Swapping */
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Testing code.
    public static void Main(string[] args)
    {
        Console.WriteLine("---BUBBLE SORT---");
        int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
        Console.Write("unsorted List: ");
        for (int i = 0; i<array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        BubbleSort b = new BubbleSort();
        b.Sort(array);
        Console.Write("\nsorted List: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}

