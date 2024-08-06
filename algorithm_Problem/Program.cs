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
            int[] score = { 67, 81, 91, 100, 32, 48 };          //플레이어 점수값 목록
            int[] rankings = Enumerable.Repeat(1, 6).ToArray(); //순위 배열 만들기

            Array.Sort(score);  // 점수를 정렬 시킨다.
            for (int i = 0; i < score.Length; i++)
            {
                rankings[i] = 1; //1등으로 초기화, 순위 배열을 매 회전마다 1등으로 초기화 한다
                for (int j = 0; j < score.Length; j++)
                {
                    if (score[i] < score[j]) //현재 점수와 나머지 점수 비교를 비교한다
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

// 1.Enumerable 클래스는 IEnumerable<T> 인터페이스를 구현하는 컬렉션 객체에 대해
//   LINQ 쿼리를 수행할 수 있는 메서드를 제공한다.

//*LINQ .NET Framework에서 데이터 쿼리를 지원하기 위해 도입된 기술로,
// C# 및 VB.NET에서 사용할 수 있는 쿼리 언어이다.
// 데이터를 검색, 정렬, 필터링, 그룹화 등을 할 수 있다.

// 2.Repeat 메서드는 특정 숫자를 특정 횟수만큼 반복한 집합을 만들 때 사용하는 메서드이다.

// 3.ToArray 메서드는 T[]배열로 만들때 사용 할 수 있다.
