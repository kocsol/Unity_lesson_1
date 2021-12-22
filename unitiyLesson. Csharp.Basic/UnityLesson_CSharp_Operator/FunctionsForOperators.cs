using System;
using System.Collections.Generic;
using System.Text;
// cs는 씨샵 스크립트를 말함 그리고 앞에는 클라스 이름 그런데 우리는 지금까지 program 클래스 안에 다른 걸 만들었음 하지만 그거는 안돼 원래는 이런식으로 만들어야함
namespace UnityLesson_CSharp_Operator
{
    class FunctionsForOperators
    {
        //산술연산
        //덧셈
        static public int Sum(int a, int b) //메인에서는 static 함수만 사용 할 수 있음.
        {
            return a + b;
        }
        //뺄셈
        static public int Sub(int a, int b)
        {
            return a - b;
        }
        //나눗셈
        static public int Div(int a, int b)
        {
            return a / b;
        }
        //곲셈
        static public int Mul(int a, int b)
        {
            return a * b;
        }
        //나머지셈
        static public int Mod(int a, int b)
        {
            return a % b;
        }
        //=================================================================
        // 증감 연산
        static public int Increase(int a)
        {
            return a++;
        }
        static public int Decrease(int a)
        {
            return a--;
        }

        //============================================================
        //관계연산
        //같은가?
        static public bool IsSame(int a, int b)
        {
            return a == b;
        }
        static public bool IsDifferent(int a, int b)
        {
            return a != b;
        }
        static public bool IsBigger(int a, int b)
        {
            return a > b;
        }
        static public bool IsBiggerOrSame(int a, int b)
        {
            return a >= b;
        }
        static public bool IsSmaller(int a, int b)
        {
            return a < b;
        }
        static public bool IsSmallerOrSame(int a, int b)
        {
            return a <= b;
        }
        // ==========================================================
        //대입연산자
        static public int PlusBTOA(int a, int b)
        {
            return a += b;
        }
        static public int MinusBTOA(int a, int b)
        {
            return a -= b;
        }
        static public int DivBToA(int a, int b)
        {
            return a /= b;
        }
        static public int MulBTOA(int a, int b)
        {
            return a *= b;
        }
        static public int ModBToA(int a, int b)
        {
            return a %= b;
        }

        //====================================
        //논리연산

        static public bool LogicOR(bool a bool b)
        {
            return a | b;
        }
        static public bool LogidAND(bool a, bool b)
        {
            return a & b;
        }
        static public bool LogicNOT(bool a)
        {
            return !a;
        }
        static public bool LogicXOR(bool a, bool b)
        {
            return a ^ b;
        }

        //==========================
        //조건부 연산
        static public  bool ConditionalLogicOR(bool a, bool b)
        {
            return a || b;
        }
        static public bool ConditionalLogicAND(bool a, bool b)
        {
            return a && b;
        }
        //=============================================================
        //비트연산
        static public int BitLogicOR(int a, int b)
        {
            return a | b;
        }
        static public int BitLogicAND(int a, int b)
        {
            return a & b;
        }
        static public int BitLogicNOT(int a)
        {
            return ~a;
        }
        static public int BitLogicXOR(int a, int b)
        {
            return a ^ b;
        }
        static public int  BitShiftLeft(int a, int howManyBitsYouWantToShift)
        {
            return a << howManyBitsYouWantToShift;
        }
        static public int BItShiftRight(int a, int howManyBitsYouWantToShift)
        {
            return a >> howManyBitsYouWantToShift;
        }

    }
}
