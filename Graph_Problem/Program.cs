namespace Graph_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graphs graphs = new MatrixGraph(7);
            graphs.Connect(0, 2);

            graphs.Connect(1, 2);

            graphs.Connect(2, 0);
            graphs.Connect(2, 1);

            graphs.Connect(3, 5);

            graphs.Connect(4, 6);

            graphs.Connect(5, 3);

            graphs.Connect(6, 4);


            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{i}노드 : ");
                for (int j = 0; j < 7; j++)
                {
                    if (graphs.IsConnect(i,j))
                    {
                        Console.WriteLine($"{j} 정점");
                    }
                }
                Console.WriteLine();
            }
        }
        public abstract class Graphs
        {
            public abstract void Connect(int from, int to);
            public abstract bool IsConnect(int from, int to);
        }
        public class MatrixGraph : Graphs
        {
            private bool[,] graph;

            public MatrixGraph(int vertex)
            {
                graph = new bool[vertex, vertex];
            }

            public override void Connect(int from, int to)
            {
                graph[from, to] = true;
            }
            public override bool IsConnect(int from, int to)
            {
                return graph[from, to];
            }
        }
    }
}
