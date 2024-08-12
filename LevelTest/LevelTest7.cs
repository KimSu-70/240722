namespace LevelTest
{
    internal class LevelTest7
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class LevelTest7a
    {
        public int[] solution(int[] array)
        {
            int max = array[0];
            int cout = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    cout = i;
                }
            }
            int[] answer = new int[2];
            answer[0] = max;
            answer[1] = cout;

            return answer;
        }
    }
}

