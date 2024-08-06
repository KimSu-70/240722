using static System.Formats.Asn1.AsnWriter;

namespace algorithm_Problem
{
    //순위 알고리즘(RANK)
    //주어진 범위 안에서 순위를 구하는 알고리즘이며,
    //순위 배열을 1등으로 값을 초기화 한 후 초기값 보다 큰 값이 나오면
    //1증가 낮으면 변동 없이 순위를 낮추는(1등 값이 나올수록 뒤에 점수는 밀림) 알고리즘입니다.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 67, 81, 91, 100, 32, 48 };
            int[] rankings = Enumerable.Repeat(1, 6).ToArray();

            Array.Sort(score);
            for (int i = 0; i < score.Length; i++)
            {
                rankings[i] = 1; //1등으로 초기화, 순위 배열을 매 회전마다 1등으로 초기화
                for (int j = 0; j < score.Length; j++)
                {
                    if (score[i] < score[j]) //현재(i)와 나머지(j) 비교
                    {
                        rankings[i]++;         //RANK: 나보다 큰 점수가 나오면 순위 1증가
                    }
                }
            }


            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine($"{score[i],3}점 : {rankings[i]}등");
            }
        }
    }
}
