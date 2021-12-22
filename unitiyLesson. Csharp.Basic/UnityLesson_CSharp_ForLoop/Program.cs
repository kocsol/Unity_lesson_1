using System;

namespace UnityLesson_CSharp_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
            //형태
            //for (인덱스용 변수 선언 초기화;for문이 반복될 조건; for문 내용이 끝난후 마지막에 실행할 구문)
            //{
            //     for문이 반복될 조건이 참일때 반복될 내용
            //}
            string[] arr_PersonName = new string[6];
            arr_PersonName[0] = "김아무개";
            arr_PersonName[1] = "이아무개";
            arr_PersonName[2] = "김아무개";        
            arr_PersonName[3] = "최아무개";
            arr_PersonName[4] = "김아무개";
            arr_PersonName[5] = "박아무개";

            // for 문을 배열길이 만큼 돌리면서 if 문으로 조건 확인 후 출력
            int length = arr_PersonName.Length;
            for (int i = 0; i < length; i++)
            {
                if (arr_PersonName[i] == "김아무개")
                {
                    Console.WriteLine(arr_PersonName[i]);
                }
                   
            }
            // 위에거는 좋지만 문제가 있으면 어쨌든 for문은 여섯번 돌아감 그런데 배열에 규칙이 있음 그래서
            // 김아무개씨가 2n 마다 있는 규칙을 이용하여
            //for 문의 인덱스를 2 씩 증가시키는 예시 훨씬 효율이 좋음
            for (int i = 0; i < length; i+=2)
            {
                Console.WriteLine(arr_PersonName[i]);
            }
        }
    }
}
