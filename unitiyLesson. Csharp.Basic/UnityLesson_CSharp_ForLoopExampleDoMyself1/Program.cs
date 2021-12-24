using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_ForLoopExampleDoMyself1
{
    class Program
    {
        static void Main(string[] args)

        {
            Orc[] arr_Orc = new Orc[10];
            int length = arr_Orc.Length;
            for (int i = 0; i < length; i++)  //코드는 한줄씩 실행되지만 i++을 마지막에 실행됨 그후 다시 조건빅 그리고 다시 실행 그후 i실행 반복
            {
                arr_Orc[i] = new Orc();
                arr_Orc[i].name = $"오크{i}";
                arr_Orc[i].isResting = GetRandomBool();

            }
        }
        public static bool GetRandomBool()
        {
            Random rand = new Random();    
            int randint = rand.Next(0, 2);  //매개변수. 매개체로 쓰는 변수. randint 처럼 편하게 하기 위해
            bool value = Convert.ToBoolean(randint); // 왜 변수로 만들어서 return 하냐? 그냥 하면 안되냐? 뭐가 틀린지 모르자나 안에 rand.Next도 따로 빼서 변수로 만들어서 하는게 보기 쉽고 버그 찾기도 쉬움
            return value;
        }
    }
    class Orc
    {
        public string name;

        public float height;

        public float weight;

        public int age;

        public char genderChar;

        public bool isResting;

        public void Smash()
        {
            Console.WriteLine($"{name} (이)가 휘둘렀다!");
        }
        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프했다!");
        }
    }
}
