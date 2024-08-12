namespace LevelTest
{
    public class LevelTest9
    {
        public string[] solution(string[] strings, int n) //// 입력 문자열 배열(strings)과 정수 n을 받아서
                                                          //// 특정 작업을 수행하는 메서드
        {

            int array = strings.Length; //// 입력 문자열 배열의 길이를 저장
            string[] answer = new string[array]; //// 결과를 저장할 문자열 배열을 생성

            for (int i = 0; i < array; i++)  // 문자열 배열을 순회하면서 각 문자열에 대해 작업 수행
            {
                answer[i] = (strings[i][n]) + strings[i];  
                /// 각 문자열에서 인덱스 n에 위치한 문자를 추출하고, 이를 문자열의 앞에 붙여서 새로운 문자열 생성
                // 예: strings[i][n] + strings[i]는 n번째 문자를 맨 앞에 붙인 문자열을 의미
            }

            Array.Sort(answer); // // 결과 배열을 사전순으로 정렬

            for (int i = 0; i < array; i++)
            // 정렬된 문자열 배열에서 각 문자열의 첫 번째 문자를 제거
            // 이는 원래 문자열이 아닌 n번째 문자가 붙은 상태의 문자열에서 첫 번째 문자를 제거하는 것
            {
                answer[i] = answer[i].Substring(1);
            }
            return answer;
        }

    }
}
