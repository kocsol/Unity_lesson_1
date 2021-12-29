using System;

namespace UnityLesson_CSharp_ClassDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
        }
    }

    class AA
    {
        int level;
        public AA()  //생성자
        {

        }
        public AA(int a)  //생성자 오버로딩
        {

        }

         ~AA()  //소멸자 // 쓰지 않음 가비지 컬렉터가 알아서 삭제를 해주기 때문에
        {

        }

        //가비지 컬렉터
        //메모리에 할당되었으나 더 이상 참조되지 안흔 값들을 수집해서 삭제함.
        
        //CLR(공통 언어 런타임) .Net Framwork 의 가상 머신 구성 요소
        //프로그램 코드의 실행 환경을 정의하는 기능 자세한 내용은 google
        
        //관리되는 힙 영역 (CLR 접근 권한을 가지고 있음)
        //CLR 에 있는 가비지 컬렉터는 이 과닐되는 힙 영역에서 더 이상 참조되지 않는 값들을 삭제
        //소멸자를 C#에서 쓰지 않는 이유는
        //생성자를 통해 AA객체를 생성하고 함수가 종료되면 가비지 컬렉터가 AA 객체를 지워준다.
    }
}
