using System;

namespace UnityLesson_CSharp_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //for 문
            //기본형태
            /*
            for (인덱스용 변수 선언 및 초기화; 
                 int i = 0; for문을 실행할 조건; 
               i < length; 루프가 한번 실행될때마다 마지막에 실행할 문장;  i++;)
            {
                반복수행시 실행할 내용
            } */

            string[] arr_PersonName = new string[9];
            arr_PersonName[0] = "도";
            arr_PersonName[1] = "래";
            arr_PersonName[2] = "미";
            arr_PersonName[3] = "파";
            arr_PersonName[4] = "솔";
            arr_PersonName[5] = "라";
            arr_PersonName[6] = "시";
            arr_PersonName[7] = "도";
            arr_PersonName[8] = "래";


            int length = arr_PersonName.Length;
            for (int i  = 0; i < length; i++)
            {
                Console.WriteLine(arr_PersonName[i]);
            }
            //미만 출력하고 다 미의 인덱스 규칙은

            //모든 배열요소를 검색한 예시
            for (int i = 0;i < length;i++)
            {
                if (arr_PersonName[i] =="미")
                {
                    Console.WriteLine (arr_PersonName [i]); 

                }
            }
                //인덱스 규칙을 활용한 예시
            for(int i = 0;i < length; i+=3)
            {
                Console.WriteLine(arr_PersonName[i]);
            }
        }
    }
}
