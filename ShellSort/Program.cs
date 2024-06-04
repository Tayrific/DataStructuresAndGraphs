using System.Buffers;

namespace ShellSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--SHELL SORT--");
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            Console.Write("Unsorted List:");
            Arr_element(array);
            int size = array.Length;

            ShellSort(array, size);

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

        private static void ShellSort(int[] array, int size)
        {
            int i, j, inc, temp;
            inc = 3;

            while(inc>0)
            {
                for(i = 0; i < size; i++)
                {
                    j = i;
                    temp = array[i];
                    while((j>=inc) && (array[j-inc]> temp)) // checking the values
                    {
                        array[j] = array[j-inc];
                        j = j - inc;

                    }
                    array[j] = temp; //save to array
                }
                if (inc/2 != 0)
                {
                    inc = inc / 2;
                } 
                else if(inc == 1)
                {
                    inc = 0;
                } 
                else
                {
                    inc = 1;
                }
            }
        }
    }
}
