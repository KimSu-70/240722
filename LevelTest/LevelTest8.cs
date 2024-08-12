namespace LevelTest
{
    public class LevelTest8
    {
        public int solution(int[] array)
        {
            int answer = 0;

            Array.Sort(array);
            answer = array[array.Length / 2];
            return answer;
        }
    }
}
