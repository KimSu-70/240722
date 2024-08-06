namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 8, 6, 4, 2, 0 };
            Console.Write("배열 : ");
            foreach (int value in array)
            {
                Console.Write($" {value} ");
            }
            Console.WriteLine();

            int index1 = Util.IndexOf(array, 3);
            int index2 = Array.IndexOf(array, 3);
            Console.WriteLine($"순차탐색 결과 위치 : {index2}");
            Console.WriteLine();

            int index3 = Util.BinarySearch(array, 2);
            Console.WriteLine($"이진탐색 결과 위치 : {index3}");

            Array.Sort(array);
            Console.Write("배열 : ");
            foreach (int value in array)
            {
                Console.Write($" {value} ");
            }
            Console.WriteLine();
            int index4 = Util.BinarySearch(array, 2);
            int index5 = Array.BinarySearch(array, 2);
            Console.WriteLine($"이진탐색 결과 위치 : {index5}");
            Console.WriteLine();


            bool[,] graph = new bool[8, 8]
            {
                //  0      1      2      3      4      5      6      7
                { false,  true, false, false,  true, false, false, false },
                {  true, false,  true,  true, false,  true,  true, false },
                { false,  true, false, false, false,  true, false, false },
                { false,  true, false, false, false, false, false, false },
                {  true, false, false, false, false, false,  true, false },
                { false,  true,  true, false, false, false,  true, false },
                { false,  true, false, false,  true,  true, false, false },
                { false, false, false, false, false, false, false, false },
            };
        }
    }

    public class Util
    {
        // <순차 탐색>
        // 자료구조에서 순차적으로 찾고자 하는 데이터를 탐색
        // 시간복잡도 - O(n)
        public static int IndexOf(int[] array, int target)
        {
            int result = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        // <이진 탐색>
        // 정렬이 되어있는 자료구조에서 2분할을 통해 데이터를 탐색
        // 단, 이진 탐색은 정렬이 되어 있는 자료에만 적용 가능
        // 시간복잡도 - O(logn)
        public static int BinarySearch(int[] array, int target)
        {
            int result = -1;
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;  // 중간 위치

                if (array[mid] < target)
                {
                    min = mid + 1;
                }
                else if (array[mid] > target)
                {
                    max = mid - 1;
                }
                else // if (array[mid] == target)
                {
                    result = mid;
                    break;
                }
            }

            return result;
        }


        // <깊이 우선 탐색 (Depth-First Search)>
        // 그래프의 분기를 만났을 때 최대한 깊이 내려간 뒤,
        // 분기의 탐색을 마쳤을 때 다음 분기를 탐색
        // 재귀(스택)을 통해 구현
        // 장점 : 지금 탐색하고 있는 경로에 메모리만 사용해도 동작가능
        // 단점 : 최단경로 보장 x
        // 트리에서 사용하기 좋음(트리 : 경로가 하나밖에 없음)
        public static void DFS(bool[,] graph, int start, out bool[] visited, out int[] parent)
        {
            int size = graph.GetLength(0);      // size : 그래프의 정점갯수
            visited = new bool[size];           // visited : 탐색 여부
            parent = new int[size];             // parent : 정점을 탐색한 정점이 누구인지 (역순으로 따라가면 경로)

            // 초기 세팅 (처음으로 가져야 되는 값들)
            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parent[i] = -1;
            }

            SearchNode(graph, start, visited, parent);  // 처음 정점부터 탐색 시작
        }

        public static void SearchNode(bool[,] graph, int vertex, bool[] visited, int[] parent)
        {
            int size = graph.GetLength(0);  // 정점의 갯수
            visited[vertex] = true;         // 탐색한 정점을 탐색 완료 표시

            for (int i = 0; i < size; i++)  // 전체 정점들을 전부 확인하면서
            {
                if (graph[vertex, i] == true &&     // 연결되어 있는 정점
                    visited[i] == false)            // 찾은적 없는 정점
                {
                    parent[i] = vertex;             // 해당 정점을 탐색한 정점 표시
                    SearchNode(graph, i, visited, parent);  // 정점 탐색 시작
                }
            }
        }


        // <너비 우선 탐색 (Breadth-First Search)>
        // 그래프의 분기를 만났을 때 모든 분기들을 탐색한 뒤,
        // 다음 깊이의 분기들을 탐색
        // 큐를 통해서 구현
        // 장점 : 최단경로 보장 O
        // 단점 : 다음으로 탐색해야 하는 정점들까지 메모리에 보관하고 있어야 함
        // 그래프에서 사용하기 좋음 (그래프 : 경로가 어려개 있을 수 있음)
        public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parent)
        {
            int size = graph.GetLength(0);      // size : 그래프 정점의 갯수
            visited = new bool[size];           // visited : 정점의 탐색 여부
            parent = new int[size];             // parent : 해당 정점을 누가 찾았았는지 (역순으로 따라가면 경로)

            // 초기 설정
            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parent[i] = -1;
            }

            Queue<int> queue = new Queue<int>();    // 큐 : 탐색해야하는 정점들의 대기열
            queue.Enqueue(start);           // 처음으로 탐색해야하는 정점은 시작 정점
            visited[start] = true;          // 탐색 여부 체크

            while (queue.Count > 0)         // 대기열에 아무것도 없을 때까지
            {
                int vertex = queue.Dequeue();   // 다음으로 탐색해야하는 정점 나오게 된다

                for (int i = 0; i < size; i++)  // 모든 정점들을 확인
                {
                    if (graph[vertex, i] == true &&   // 연결되어 있는 정점
                        visited[i] == false)          // 찾은적 없는 정점
                    {
                        visited[i] = true;  // 탐색 여부 체크
                        parent[i] = vertex; // 탐색하게되는 정점을 표시
                        queue.Enqueue(i);   // 탐색해야하는 정점을 대기열에 추가
                    }
                }
            }
        }
    }
}