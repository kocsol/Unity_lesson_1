using System;

namespace UnityLesson_CSharp_Variable_Function_Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(); // person1이라는 객체를 새로 만듬
            // . 점 연산자
            // 클래스의 멤버에 접근할 때 사용 namespace 안의 클래스에 접근할 때도 사용
            // 객체의 멤버에 접근할 때도 사용. 멤버-> 구성원 함수를 구성하는 것들 함수안에 있는 것들! 
            person1.name = "김아무개";
            person1.age = 123;
            person1.heihgt = 224.31f;
            person1.isFemale = false;
            person1.genderChar = '남';

            Person person2 = new Person();  // 알트 시프트 드래그 하면 편함
            person2.name = "이아무개";
            person2.age = 78;
            person2.heihgt = 124.11f;
            person2.isFemale = true;
            person2.genderChar = '여';

            person1.SayAllInfo();
            person2.SayAllInfo();



        }
       
    }
    class Person
    {
        //접근 제한자 자료형 앞에 붙여 준다.
        //public. private. prtoected
        // public: 다른 클래스가 접근 할 수 있다.
        //private : 다른 클래스는 접근 할 수 없다. 아무것도 안써주면 암묵적으로 private
        //protected : 상속자만 접근 할 수 있다. 
        public int age; //나이
        public float heihgt; //키
        public bool isFemale; //여자인가?
        public char genderChar; // 성별 문자
        public string name; // 이름

        public void SayAllInfo()
        {

            //Console.WriteLine($"나이 : {age}, 키 : {height}, "); 이렇게 쭉쭉 적어난가는 것보단 만들어 놓은 함수들을 사용해 나가는 것이 훨신 좋음
            SayAge();
            Sayheight();
            SayisFemale();
            SayGenderChar();
            SayName();
        }

        public void SayAge() //콘솔창에 반환하는 것이 아닌 콘솔에 나오기만하면되니
        {
            Console.WriteLine($"나이 : {age}"); //문자끼리 더할때 플러스 연산자 사용 C샵에서는 알아서 문자형을 바꿔주니 포멧팅 안해줘도 됨 그래도 비추 오해가 생길 수 있으니 해당 괄호처럼 사용
        }
        public void Sayheight()
        {
            Console.WriteLine($"키 : {heihgt}");
        }
        public void SayisFemale()
        {
            Console.WriteLine($"여자인가? : {isFemale}");

        }

        public void SayGenderChar()
        {
            Console.WriteLine($"성별문자 : {genderChar}");
        }

        public void SayName()
        {
            Console.WriteLine($"이름 : {name}");
        }
    }

}
