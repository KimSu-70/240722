namespace Dijkstra_sAlgorithm
{
    internal class Program
    {
        /********************************************************************
         * 다익스트라 알고리즘 (Dijkstra Algorithm)
         * 
         * 특정한 노드에서 출발하여 다른 노드로 가는 각각의 최단 경로를 구함
         * 방문하지 않은 노드 중에서 최단 거리가 가장 짧은 노드를 선택 후,
         * 해당 노드를 거쳐 다른 노드로 가는 비용 계산
         ********************************************************************/

        const int INF = 99999;

        static void Main(string[] args)
        {
            int[,] graph = new int[8, 8]
            {
                // 0    1    2    3    4    5    6    7 
                {   0,   1,   8,   9, INF, INF, INF, INF},
                {   1,   0, INF, INF, INF,   3, INF, INF},
                {   8, INF,   0, INF,   1, INF,   3, INF},
                {   9, INF, INF,   0, INF,   9, INF,   1},
                { INF, INF,   1, INF,   0, INF,   9, INF},
                { INF,   3, INF,   9, INF,   0,   3, INF},
                { INF, INF,   3, INF,   9,   3,   0,   9},
                { INF, INF, INF,   1, INF, INF,   9,   0}
            };

            Dijkstra(graph, 0, out bool[] visited, out int[] distance, out int[] parent);

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                Console.Write($" {i} ");
                Console.Write($" {visited[i]} ");
                Console.Write($" {distance[i]} ");
                Console.Write($" {parent[i]} ");
                Console.WriteLine();

            }
        }

        public static void Dijkstra(int[,] graph, int start, out bool[] visited, out int[] distance, out int[] parent)
        {
            // 0. 초기 설정
            int size = graph.GetLength(0);      // size : 그래프의 정점 갯수
            visited = new bool[size];           // visited : 각 정점의 탐색 여부
            distance = new int[size];           // distance : 각 정점의 최단거리
            parent = new int[size];             // parent : 각 정점을 탐색한 정점이 누구인지 (역순으로 해보면 경로가 나온다)

            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                distance[i] = INF;
                parent[i] = -1;
            }
            distance[start] = 0;        // 처음 시작 위치의 거리는 0으로

            for (int i = 0; i < size; i++)
            {
                // 1. 가장 가까운 정점부터 선택
                int minIndex = -1;      // minIndex : 가장 작은 거리를 가진 위치를 기록해두기 위한 변수
                int minCost = INF;      // minCost : 가장 작은 거리 수치를 기록해두기 위한 변수
                for (int j = 0; j < size; j++)
                {
                    if (visited[j] == false &&  // 탐색한 적이 없는 정점
                        distance[j] < minCost)  // 거리가 가장 작은 정점
                    {
                        // 더 작은 거리를 찾았으면
                        minIndex = j;           // 가장 작은 거리를 찾은 위치로
                        minCost = distance[j];  // 가장 작은 거리의 수치를 보관
                    }
                }
                if (minIndex < 0)               // 연결되어 있으면서 탐색한 적이 없는 정점이 없었던 경우
                    break;                      // 탐색 종료

                visited[minIndex] = true;       // 다음으로 찾을 정점은 탐색했다고 표시

                // 2. 선택한 정점을 거쳐서 더 짧아지는 경우 갱신
                for (int j = 0; j < size; j++)
                {
                    // distance[j] : 목적지까지 직접 연결된 거리
                    // distance[minIndex] : 선택한 정점까지의 거리
                    // graph[minIndex, j] : 선택한 정점에서 목적지까지의 거리

                    // 목적지까지 직접 연결된 거리가 거쳐서가는 거리보다 더 큰 경우
                    if (distance[j] > distance[minIndex] + graph[minIndex, j])
                    {
                        // 목적지까지 직접 연결된 거리를 거쳐서가는 거리로 바꿔준다
                        distance[j] = distance[minIndex] + graph[minIndex, j];
                        parent[j] = minIndex;   // 탐색한 정점을 변경
                    }
                }
            }
        }
    }
}

