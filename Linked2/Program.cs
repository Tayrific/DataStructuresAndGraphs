namespace Linked2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList LList = new LinkedList();
            LList.AddHead(1);
            LList.AddHead(2);
            LList.AddHead(3);
            LList.AddHead(4);
            LList.AddHead(5);
            LList.AddHead(6); 

            LList.Print();
            Console.WriteLine($"Size : {LList.Size()}");
            Console.WriteLine($"Size : {LList.FindLength()}");
            Console.WriteLine($"Is empty : {LList.IsEmpty()}");
            Console.WriteLine($"Peek : {LList.Peek()}");
            Console.Write("Adding to the end: ");
            LList.AddTail(7);
            LList.Print();
            Console.Write("Reversing list: ");
            LList.Reverse();
            LList.Print();
            Console.Write("Adding a duplicate: ");
            LList.AddHead(6);
            LList.Print();
            Console.Write("Removing the duplicate: ");
            LList.RemoveDuplicate();
            LList.Print();
            Console.Write("Sorting the list: ");
            LList.BubbleSort();
            LList.Print();
            LList.NthNodeFromBeginning(5);
           
            Console.ReadLine();

        }
    }
}
