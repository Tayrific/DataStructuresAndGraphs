namespace Linked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a linkedlist
            // Using LinkedList class
            LinkedList<int> my_list = new LinkedList<int>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast(1);
            my_list.AddLast(2);
            my_list.AddLast(3);
            my_list.AddLast(4);
            my_list.AddLast(5);
            my_list.AddLast(6);

            Console.Write("Numbers in list are: ");

            // Accessing the elements of 
            // LinkedList Using foreach loop
           
            foreach (int item in my_list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");

            // remove first node
            Console.Write("Numbers in list after removing first node: ");
            my_list.Remove(my_list.First);
            foreach (int item in my_list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");

            Console.Write("Numbers in list after adding to front: ");
            my_list.AddFirst(0);
            foreach (int item in my_list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");

            Console.Write("Numbers in list after adding to end: ");
            my_list.AddLast(9);
            foreach (int item in my_list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");

            Console.Write("Checking if list contains the number 4 (true): ");

            if (my_list.Contains(4) == true)
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("----------------------------------------------------------------------");

            Console.Write("Checking if list contains the number 8 (false): ");

            if (my_list.Contains(8) == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("----------------------------------------------------------------------");

            
            Console.Write("Finding the number 8 in the list: ");

            LinkedListNode<int> foundNode = my_list.Find(8);

            if (foundNode != null)
            {
                Console.WriteLine( foundNode.Value);
            }
            else
            {
                Console.WriteLine("Number 8 is not found in the list.");
            }

            Console.WriteLine("----------------------------------------------------------------------");

            Console.Write("Get type: ");
            var type = my_list.GetType();
            Console.WriteLine(type);

            Console.WriteLine("----------------------------------------------------------------------");

            Console.Write("Numbers in list after removing the first number: ");
            my_list.RemoveFirst();
            foreach (int item in my_list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------");

            Console.Write("Numbers in list after removing the last number: ");
            my_list.RemoveLast();
            foreach (int item in my_list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------");

            Console.Write("Numbers in list after Clearing: ");
            my_list.Clear();
            if (my_list.Count == 0)
            {
                Console.Write("List is empty!");
            }
            else
            {
                foreach (int item in my_list)
                {
                    Console.Write(item + ", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");


            Console.ReadLine();
        }
    }
}
