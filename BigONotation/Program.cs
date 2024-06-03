using System.Diagnostics;
namespace BigONotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Stopwatch t = new Stopwatch();
            t.Start();
            int m = fun1(10000);
            t.Stop();
            TimeSpan ts = t.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"elapsed time = {elapsedTime}");
            Console.ReadLine();
        }
        public static int fun1(int n)
        {
            int i, j, m = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    m = m + 1;
                }
            }
            return m;
        }
    }
}
