namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            Console.WriteLine("The sequence of moves involved in the Tower of Hanoi are:\n");
            towerOfHanoi(num, 'A', 'C', 'B');
            Console.ReadLine();
        }

        public static void towerOfHanoi(int num, char src, char dst, char temp)
        {
            if (num == 1)
            {
                Console.WriteLine("Move disk {0} from rod {1} to rod {2}",num, src,dst);
                return;
            }

            towerOfHanoi(num - 1, src, temp, dst); // Move num-1 disks from src to temp
            Console.WriteLine("Move disk {0} from rod {1} to rod {2}", num, src, dst); // Move the nth disk from src to dst
            towerOfHanoi(num - 1, temp, dst, src); // Move num-1 disks from temp to dst
        }
    
    }
}

