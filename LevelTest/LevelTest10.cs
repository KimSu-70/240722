namespace LevelTest
{
    public class Move
    {
        public int solution(int[,] maps)
        {
            int[] x = { -1, 1, 0, 0 };  // 좌 우
            int[] y = { 0, 0, -1, 1 };  // 상 하

            int mapRow = maps.GetLength(0);     // 맵의 행의 수
            int mapColumn = maps.GetLength(1);  // 맵의 열의 수

            Queue<int> queue = new Queue<int>();
            bool[,] visited = new bool[mapRow, mapColumn];
            int[,] parent = new int[mapRow, mapColumn];

            
        }
        internal class LevelTest10
        {
            static void Main(string[] args)
            {
                int[,] map = new int[5, 5]
                {
           // 0  1  2  3  4
            { 1, 0, 1, 1, 1 },
            { 1, 0, 1, 0, 1 },
            { 1, 0, 1, 1, 1 },
            { 1, 1, 1, 0, 1 },
            { 0, 0, 0, 0, 1 }
                };
            }
        }
    }
}

