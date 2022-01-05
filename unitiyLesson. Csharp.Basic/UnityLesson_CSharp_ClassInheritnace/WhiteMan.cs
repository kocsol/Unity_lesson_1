using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSharp_ClassInheritnace
{
    class WhiteMan : Human
    {
        public override void Breath()
        {
            lifeTime++;
            weight += 0.00003f;
            height += 0.00001f;
        }


    }
}
