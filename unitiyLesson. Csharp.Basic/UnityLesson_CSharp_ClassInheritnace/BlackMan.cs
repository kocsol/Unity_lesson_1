using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSharp_ClassInheritnace
{
    class BlackMan : Human
    {
        public override void Breath()
        {
            lifeTime++;
            weight += 0.00004f;
            height += 0.00006f;
        }
    }
}
