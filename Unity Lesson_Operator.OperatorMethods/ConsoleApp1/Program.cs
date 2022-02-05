﻿using System;

namespace UnityLesson_CSharp_Arraay
{
    internal class Program
    {
        //array
        //형태 : 자료형[]
        //자료형이 정적으로 나열되어있는 형태
        ////크기를 한번 정해놓으면 바꿀수 없다.
        static int[] arr_TestInt = new int[5];
        static float[] arr_TestFloat = new float[3];
        static float[] arr_TestFloat2 = { 1.0f, 2.0f, 3.0f, 4.0f };
        static string[] arr_TestString = new string[3];

        static void Main(string[] args)
        {
            arr_TestInt[0] = 5;
            arr_TestInt[1] = 4;
            arr_TestInt[2] = 3;
            arr_TestInt[3] = 2;
            arr_TestInt[4] = 1;

            Console.WriteLine(arr_TestInt[0]);
            Console.WriteLine(arr_TestInt[1]);
            Console.WriteLine(arr_TestInt[2]);
            Console.WriteLine(arr_TestInt[3]);
            Console.WriteLine(arr_TestInt[4]);


            arr_TestString[0] = "게임";
            arr_TestString[1] = "컴퓨터";

            Console.WriteLine(arr_TestString[0]);
            Console.WriteLine(arr_TestString[1]);





            ;
        }





    }


}


