using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSharp_ClassInheritnace
{
    class Human : Creature  , iTwoLeggedWalker // 콜론을 쓰면 Creature class 를 상속 받았다는 의미  ,하고 iTwo는 인터페이스를 받아 온 것이다.
    {
        public float height;

        // overide 키워드 : 부모의 virtual 키워드가 붙은 함수를 재정의 하는 키워드
        public override void Breath()
        {
            base.Breath(); // base 키워드는 부모 클래스를 지칭 이 경우 Creature 클라스
            weight += 0.00002f;
            height += 0.00004f;

        }

        public void TwoLeggedWalk()
        {
            Console.WriteLine("두발로 걷는다.");
        }
    }
}
