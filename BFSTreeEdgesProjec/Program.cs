namespace BFSTreeEdgesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DirectedGraph g = new DirectedGraph();

            g.InsertVertex("Zero");
            g.InsertVertex("One");
            g.InsertVertex("Two");
            g.InsertVertex("Three");
            g.InsertVertex("Four");
            g.InsertVertex("Five");
            g.InsertVertex("Six");
            g.InsertVertex("Seven");
            g.InsertVertex("Eight");
            g.InsertVertex("Nine");

            g.InsertEdge("Zero", "One");
            g.InsertEdge("One", "Four");
            g.InsertEdge("Two", "Three");
            g.InsertEdge("Two", "Five");
            g.InsertEdge("Three", "Six");
            g.InsertEdge("Four", "Seven");
            g.InsertEdge("Five", "Eight");
            g.InsertEdge("Six", "Nine");

  

            g.BfsTreeEdges();
            Console.ReadLine();
        }
    }
}

