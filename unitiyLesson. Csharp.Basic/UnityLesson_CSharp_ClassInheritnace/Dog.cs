using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSharp_ClassInheritnace
{
    class Dog : Creature, iFourLeggedWalker
    {
        public float tailLength;

        public void FourLeggedWalk()
        {
            Console.WriteLine("네발로 걷는다.");
        }
    }
}
