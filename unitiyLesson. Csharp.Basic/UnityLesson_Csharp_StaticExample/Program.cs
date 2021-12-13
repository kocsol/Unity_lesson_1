using System;

namespace UnityLesson_Csharp_StaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.name = "김아무개";

            Person person2 = new Person();
            person2.name = "이아무개";

            //person2.; // 스태틱은 타입네임은 안나옴 name은 나오는데

            Person.typeName = "사람 타입"; //여기는 나옴 객체에는 사용이 안되는데 person의 클라스의 특성 person1,2가 아니라 
            Orc.typeName = "오크 타입";
            //person1 에게 saytypename? 안됨 스테틱이라 person의 설계도로 접근을 해야함
            Person.SayTypeName();

            //static 써진건 객체가 아닌 클라스 접근, 안써진것은 dynamic으로 객체에만 접근가능?
            Orc orc1 = new Orc();//그냥 클라스 오크일때는 되지만 스태틱 클라스면 안됨 와이 설계도 보단 설명서 느낌 고유의 정보만을 사용
            //스태틱으로 정의된 클래스는 객체생성 불가. 인스턴스화 안됨!  예를 들면 게임 맵정보 아이템 수량 포탈의 좌표

            
        }
    }
    static class Orc // 클라스에도 스태틱을 쓸수도 있다.
    {
        static public string typeName; //변수에 대한 스테틱
        


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
        static public string typeName; //스태틱 예시

        static public void SayTypeName()
        {
            Console.WriteLine(typeName);
        }


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
