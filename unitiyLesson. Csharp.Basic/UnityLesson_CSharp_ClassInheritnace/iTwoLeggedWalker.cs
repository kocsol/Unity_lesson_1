using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSharp_ClassInheritnace
{
    // interface
    // 클래스랑 비슷하게 생겼지만
    // 함수, 이벤트. 인덱서, 속성(Attribute) 만 멤버로 가질 수 없고
    // 각 멤버는 기본적으로 접근 권한자가  public 
    // 멤버들은 선언말 할 뿐 정의하지 않는다. ( 어떤 기능에 대한 이름만 명시하고 내용 구현은 안한다.)
    // 인터페이스는 클래스와 다르게 다중상속이 가능하다.
    // 클래스의 추상화를 할 때, 함수들이 같은 이름이 필요한 경우 집합으로 명시하고 따로 관리할 수 있다.
    interface iTwoLeggedWalker // 인터페이스는 구분을 위해 앞에 i 를 붙여줌
    {
        void TwoLeggedWalk(); // 함수 정의 아직 기능은 써주지 않음
        

        
    }
}
