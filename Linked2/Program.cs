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
            LList.AddTail(7);
            LList.Print();
            LList.Reverse();
            LList.Print();
            LList.AddHead(6);
            LList.Print();
            LList.RemoveDuplicate();
            LList.Print();
            LList.BubbleSort();
            LList.Print();
            Console.ReadLine();

        }
    }
}
