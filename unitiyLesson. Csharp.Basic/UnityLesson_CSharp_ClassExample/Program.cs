using System;

namespace UnityLesson_CSharp_ClassExample1

{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.name = "상급오크";
            orc1.height = 240.2f;
            orc1.weight = 200;
            orc1.age = 140;
            orc1.isMale = true;
            orc1.haveTime = false;

            Orc orc2 = new Orc();
            orc2.name = "하급오크";
            orc2.height = 140.4f;
            orc2.weight = 120.0f;
            orc2.age = 60;
            orc2.isMale = false;
            orc2.haveTime = true;

            if (orc1.haveTime == true) { 
                orc1.Jump();
                orc1.Smash();      
            }
            else
            {
                Console.WriteLine($"{orc1.name}(이)가 바쁘다.");
            }
            if (orc2.haveTime == true)
            {
                orc2.Jump();
                orc2.Smash();
            }
            else
            {
                Console.WriteLine($"{orc2.name}(이)가 바쁘다.");
            }
        }
    }
    class Orc
    {
        public string name;
        public float height;
        public float weight;
        public int age;
        public bool isMale;
        public bool haveTime;

        public void Smash()
        {
            Console.WriteLine($"{name}(이)가 휘둘렀다.");
        }
        public void Jump()
        {
            Console.WriteLine($"{name}(이)가 점프를 했다.");
        }
        

        
        public void SayAllInfo()
        {
           
            SayName();
            SayHeight();
            SayAge();
            SayIsMale();
            SayHaveTime();
            Smash();
            Jump();

        }
        
        
        public void SayName()
        {
            Console.WriteLine($"Orc의 이름은 {name}이다.");
        }
        public void SayHeight()
        {
            Console.WriteLine($"Orc의 키는 {height}이다");
        }
        public void SayAge()
        {
            Console.WriteLine($"Orc의 나이는는 {age}이다.");
        }
        public void SayIsMale()
        {   if (isMale == true)
            {
                Console.WriteLine($"Orc의 성별은 남자이다.");
            }
            else
            {
                Console.WriteLine($"Orc의 성별은 여자이다.");
            }
        }
        public void SayHaveTime()
        {
            if (haveTime == true)
            {
                Console.WriteLine($"Orc는 현재 놀고 있다.");
            }
            else
            {
                Console.WriteLine($"Orc는 현재 놀고 있지 않다.");
            }
        }

    }

}
