using System;
// Orc 객체 10명 만들고, 오크들의 인스턴스는 Orc 타입 배열에 넣어준다.
//각 오크의 이름은 오크0, 오크1 ..... 오크9
//각 오크에게 랜덤한 isResting  값을 선정해준다. (true or false)
//각 오크가 쉬고 있으면 jump 쉬지 않고 있으면 아무것도 안시킨다.
namespace UnityLesson_CSharp_ForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc[] arr_Orc = new Orc[10];
            int length = arr_Orc.Length;
            for (int i = 0; i < length; i++)
            {
                arr_Orc[i] = new Orc();
                arr_Orc[i].name = $"오크{i}";
                arr_Orc[i].isResting = GetRandomBool();
            }
            for (int i = 0; i < length; i++)
            {
                if (arr_Orc[i].isResting)
                {
                    arr_Orc[i].Jump();
                }

            }


        }
        static public bool GetRandomBool()
        {
            Random rand = new Random(); // 랜덤 클라스 객체 생성
            bool value = Convert.ToBoolean(rand.Next(0, 2)); //0또는 1출력, Next 함수는 minValue ~ maxValue -1 범위.....bool값으로 나타낼때 0이면 false 고 나머지는 다 true 임    
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
