namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Arrays");
            int[] numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers.Count());
            // Using the .Append() .Prepend() methods and converting it back to a string array
            numbers = numbers.Append(10).ToArray();
            numbers = numbers.Prepend(0).ToArray();
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write($" {numbers[x]} , ");
            }
            Console.WriteLine("\n--------------------");
            Console.WriteLine("Working with string array");
            string[] dayArray = new string[] { "Mon", "Tue" };
            dayArray = dayArray.Append("Wed").ToArray();
            // Display values
            foreach (var item in dayArray)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine("\n--------------------");
            Console.WriteLine("\nWorking with objects");
            var obj = new object[] { 12, 2.5, 8, 5.5, "monday", "tuesday" };

            var intSum = 0;
            var doubleSum = 0.0;

            foreach (var item in obj)
            {
                Console.Write(item + " , ");
                if (item is int intValue) //checking if int and adding
                {
                    intSum += intValue;
                }
                else if (item is double doubleValue) //checing if double and adding
                {
                    doubleSum += doubleValue;
                }
            }

            //displaying results
            Console.WriteLine("\nSumn of integers: {0}", intSum);
            Console.WriteLine("Sumn of doubles: {0}", doubleSum);
 

            Console.WriteLine("--------------------");
            string stringNumbers;
            int result = 0;

            Console.Write("Enter integer number: ");
            stringNumbers = Console.ReadLine();
            foreach (var num in stringNumbers)
            {
                // Convert the character to an integer
                if (char.IsDigit(num))
                {
                    int intNumber = num - '0';  // Subtracting '0' converts char digit to int

                    result += intNumber;
                }
                else
                {
                    Console.WriteLine("Invalid input: {0} is not a digit.", num);
                    return;
                }
            }

            // Display the result
            Console.WriteLine($"Sum of digits: {result}");


            Console.WriteLine("--------------------");
            Console.WriteLine("reversing order: ");
            int[] rev = new[] { 1, 2, 3, 4, 5, 6 };
            Console.Write("Order: ");
            foreach (var number in rev)
            {
                Console.Write(number + " ");
            }

            int length = rev.Length;
            for (int i = 0; i < length / 2; i++) // swapping elements in pairs till mid of array is reached
            {
                int temp = rev[i];
                rev[i] = rev[length - 1 - i];
                rev[length - 1 - i] = temp;
            }

            Console.Write("\nReversed array:"); // prints final array stored in the original array
            foreach (var number in rev)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
        }
    }
}
