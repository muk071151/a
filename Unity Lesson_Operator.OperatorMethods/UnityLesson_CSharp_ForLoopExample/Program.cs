using System;


// Orc객체를 10마리 만들고
// Orc들의 인스턴스는 Orc타입 배열에 넣어준다.
// 각 오크의 이름은 "오크0", "오크1" ... , "오크9"
//각 오크에게 is Reseting 맴버 변수 값은 랜덤으로 넣어준다.
//각 오크가 쉬고 있는지 확인해서 쉬고 있다면 점프하도록 한다.

namespace UnityLesson_CSharp_ForLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            orc[] arr_orc = new orc[10]; // 오크 10개를 넣을수 있는 배열이다 라고 정의함
                                        //orc orc1 =  new orc(); 오크를 객체화 하고 인스턴스화 한것 위와는 다르다 new 를 썻다고 오크를 생성한게 아님
            int length = arr_orc.Length;
            for (int i = 0; i < length; i++)
            {
                arr_orc[i] = new orc();
                arr_orc[i].name = $"주식{i}";
            }

            //is Resting 랜덤 세팅
            for (int i = 0; i < length; i++)
            {
                arr_orc[i].isResting = GetRandomBool();
            }

            for (int i = 0; i < length; i++) 
            {
                if (arr_orc[i].isResting)
                {
                    arr_orc[i].Jump();
                }
            }
        }
        static private bool GetRandomBool()
        {
            Random random = new Random();
            int randomInt = random.Next(0, 2); //minValue ~ maxValue -1
            bool randomBool = Convert.ToBoolean(randomInt); //0 만 false 나머지는 true
            return randomBool;
        }
    }
    public class orc
    {
        public string name;
        public float height;
        public float weight;
        public int age;
        public char genderChar;
        public bool isResting;

        public void Smash()
        {
            Console.WriteLine($"{name} (이)가 휘둘렀다");
        }
        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 상승했다");
        }
    }
}

