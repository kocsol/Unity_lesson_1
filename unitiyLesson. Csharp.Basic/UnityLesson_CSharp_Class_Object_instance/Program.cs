using System;

namespace UnityLesson_CSharp_Class_Object_instance
{
    class Program
    {
        static void Main(string[] args)
        {
            //객체생성 키워드 new
            //객체를 생성했지만 메모리에 할당해주지 않았기 때문에 우리는 접근할 수가 없다.
            new AA(); // 생성자 : 클래스와 같은 이름의 함수 AA클래스로 객체를 만든다.

            // 인스턴스화
            // 메모리 공간에 생성된 객체를 할당시킴
            //AA a AA에라는 클래스 타입에 소문자 a라는 변수를 쓴다. int age 생각 타입은 int 변수 age
            AA a = new AA(); // 생성된 객체를 a  변수a에 할당시킴 int age = 20 ,20을 변수 age에 할당
            //AA 타입의 a 변수에 new AA()로 생성된 객체가 할당 되었다.
            //이제 소프트웨어 세계에서 우리는 a에 접근할 수 있다.
            //a 를 인스턴스라고 함.

        }
        // 클래스 AA {설계도}
        public class AA
        {
          
        }
    }
}
