using System;

namespace UnityLesson_CSharp_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//while 의 구조
            while (조건)
            {
                조건이 참일때 반복할 내용
            }
            //무한루프 ( while의 조건이 항상 참일 경우)
            // 절대 코드에 있어서 안되는 존재


            while (true)
            {

            }*/
            string[] arr_PersonName = new string[3];
            arr_PersonName[0] = "도";
            arr_PersonName[1] = "래";
            arr_PersonName[2] = "미";


            int length = arr_PersonName.Length; 
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine(arr_PersonName[count]);
                count++;
            }
            while (true)
            {
                if(count < length)
                {
                    Console.WriteLine(arr_PersonName[count]);
                }
                else
                {
                    break;
                }
            }

        }
    }
}
