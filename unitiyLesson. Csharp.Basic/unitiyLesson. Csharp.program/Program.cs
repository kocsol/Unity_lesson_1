//키워드- 특정한 기능 담당. 파란색 표시. 바꿀 수 없음.
//using- 무언가를 사용하겠다 라고 선언하는 키워드
// using을 언제쓰냐?
//1) 특정 namespace를 가져다 쓸 때 사용
//다른 사람이 Unity Lesson_Csharp_ progam namespace에 있는 내용을 가져다 쓰고 싶으면
// 스크립트 최 상단에 using UnityLesson Csharp program을 선언 해줘야 한다. 
//여기서 우리는 System을 사용하는 것이다. 
//2) 혹은 우선순위에가 차순위인 함수를 호출 할 때도 쓰기도 한다.
//UnityEngine.Physics에 RayCast()라는 함수가 있다. 
//UnityPhysics에 RayCast()라는 함수가 또 있음
//engine에 있는거와 그냥 Physics에 있는 것이 다른데 
//UnityEngine.Physics가 우선순위이기 때문에
//using UnityEngine.Physics;
//using Unity.Physics;
//둘다 선언했을때
//RayCast()라는 함수를 호출하면
//UnityEngine.Physics.RayCast()가 호출됨.
//근데 일반적으로 RayCast()를 호출했는데 Unity.Physics.RayCast()를 호출하고 싶으면
// using RayCast = Unity.Physics.RayCast; 해야한다.


  using System;

//namespace 이름에 대한 공간 
//동일한 변수, 이름 ,class가 충돌이 일어나지 않게 구분하기 위해
//클래스 간에 멤버 이름 충돌을 방지함.
namespace unitiyLesson._Csharp.program
{
    //C#만 특별하게 Main 함수가 class program 안에 있음
    // 이유는 객체 지향 프로그래밍 컨셉에 맞게
    
    class Program { 
        
           //Main 함수
           // 실행파일{/exe}를 실행하면
           // 하드디스크에 있던 프로젝트를 Ram으로 복제한 후 처음 실행되는 함수
          
        //static
        //static(정적)은 dynamic(동적)과 반대되는 개념의 키워드
        //static의 의미: 메모리에 할당할 수 없다.
        //dynamic의 의미: 메모리에 할당할 수 있다.

        //객체화를 한 후에 메모리에 할당을 하면 그 객체를 인스턴스라고 한다. 그 과정은 인스턴스화다. 
        //모든 것에 적용이 되는 것이 아닌 특정 기능이 필요할때 적용 사용
        //static class : 해당 클래스로 객체를 생성하고 메모리에 할당하는 것 등이 금지된다.
        //static method(함수) : 이 멤버 함수를 포함한 클래스가 여러개 객체화 되고 메모리에 할당되어도
        // 인스터스화 되어도 이 멤버함수는 객체가 아닌 클래스를 통해서만 접근가능하다. ex 내가 눌러도 되가 안되는데 운영자가 대기 누르면 다 멈춤
        
        //void?
        //반환값이 없다. 라는 자료형
        //함수의 기본형태: 입력 --> 기능수행(함수) -> 출력
        //void는 출력이 없다는 뜻

        //main은 함수의 이름

        //args argument의 줄임말
        //argument: 인자, 인수
        //함수의 입력은 함수 이름 뒤에 괄호열고 "자료형", "이름" 괄호닫고 형태.
        //이 함수의 입력 인자를 argument라고 함.
        
        static void Main(string[] args) 
        {

            //Console?
            //스크립트 최상단에 using 으로 선언한 System 이라는 namespace 에 포함된 클래스다. 
            //console을 더블클리하고 f12를 누르면 해다 console에서 사용 할 수 있는 함수들이 나온다

            //WriteLine()
            //콘솔창에 괄호안의 내용을 써주는 함수

            // .연산자
            //namespace 안에 있는 class에 접근할 때 namespace.class
            //class 안에 있는 function에 접근할때 class.function

            //WriteLine 함수 괄호 안의 내용 : WriteLine함수의 입력 변수.
            //parameter라고 함. 괄호 안에 넣어 주는것
            //여기서 arg는 WriteLine에 마우스를 올리면 나오는 string value
            Console.WriteLine("Hello World!");
        }
        //현재 Writeline 함수는 입력으로 string 형태를 받고 있고
        //string은 문자열을 똫마. 그리고 문자열은 ""로 표기함.
    }
}
