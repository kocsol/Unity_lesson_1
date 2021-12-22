using System;

namespace UnityLesson_CSharp_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =14;
            int b = 5;
            int c;

            //산술 연산
            //덧셈, 뺄셈. 나눗셈, 곱셈. 나머지셈
            // =======================
            //덧셈
            c = a + b;
            c = FunctionsForOperators.Sum(a, b);
            Console.WriteLine(c);
            c = FunctionsForOperators.Sum(a,b);
            //뺼셈
            c = a - b;
            c = FunctionsForOperators.Sub(a, b);
            Console.WriteLine(c);
            //나눗셈
            c = a / b; //정수와 정수간의 연산 결과가 실수이면 소숫점은 버린다.
            c = FunctionsForOperators.Div(a, b);
            Console.WriteLine(c);
            //곲셈
            c = a * b;
            c = FunctionsForOperators.Mul(a, b);
            Console.WriteLine(c);
            //나머지셈
            c = a % b;
            c = FunctionsForOperators.Mod(a, b);
            Console.WriteLine(c); // 실수간 연산을 해도 ,정수간의 연산으로 처리한다.

            //증감 연산 
            //증가 연산자, 감소 연산자
            Console.WriteLine($"Last C Value : {c}");
            //증가 연산자 : 1 을 증가시키는 연산자
            c++; // c의 값이 하나씩 증가  c = c + 1
            c = FunctionsForOperators.Increase(c);
            Console.WriteLine(c);

            //감소 연산자 : 1을 감소시키는 연산자
            c--; // c의 값이 하나씩 감소 c = c- 1
            c = FunctionsForOperators.Decrease(c);
            Console.WriteLine(c);

            //관계 연산
            //결과값은 논리형(bool) 참, 거짓


            //같은 비교
            FunctionsForOperators.IsSame(a, b);
            Console.WriteLine(a == b); // 다르니 false 출력
            //다름 비교
            FunctionsForOperators.IsDifferent(a, b);
            Console.WriteLine(a != b);
            //큼
            FunctionsForOperators.IsBigger(a, b);
            Console.WriteLine(a > b);
            //크거나 같음
            FunctionsForOperators.IsBiggerOrSame(a, b);

            Console.WriteLine(a >= b);

            //작음
            FunctionsForOperators.IsSmaller(a, b);
            Console.WriteLine(a < b);
            //작거나 같음
            FunctionsForOperators.IsSmallerOrSame(a, b);
            Console.WriteLine(a <= b);

            //대입 연산 "="
            //오른쪽 변수의 값을 왼쪽 변수에 (그냥, 더해서, 뺴서, 나누어서, 곱해서, 나머지를 계산해서)대입한다.

            Console.WriteLine($"Last C Value : {c}");
            c += a; // 더해서 대입 c = c + a 랑 같음
            c = FunctionsForOperators.PlusBTOA(a, b);
            Console.WriteLine(c);
            
            
            c -= a; //빼서 대임
            c = FunctionsForOperators.MinusBTOA(a, b);
            Console.WriteLine(c);
            c += 50; //이건 c++ 과 같음
            c = FunctionsForOperators.PlusBTOA(c, 50);
            Console.WriteLine($"Last C Value : {c}");

            c /= a; //나누어서 대입
            c = FunctionsForOperators.DivBToA(a, b);
            Console.WriteLine(c);
            c *= a; //곱해서 대입
            c = FunctionsForOperators.MulBTOA(a, b);
            Console.WriteLine(c);
            c %= a; // 나머지를 대입
            c = FunctionsForOperators.ModBToA(a, b);
            Console.WriteLine(c);

            // 논리연산 (참 거짓 판단)
            // 피연산자(들)을 비교해서 연산 수행
            bool A = true;
            bool B = false;
            //OR 
            //A 와 B 둘중에 하나라도 true 이면 true 반환, 나머지 경우에는 false 반환
            FunctionsForOperators.LogicOR(A, B);
            Console.WriteLine(A | B) ;
            //A와 B중에 하나라도 참이면 결과값 참 

            //AND
            //A 와 B 모두 true 이면 true 반환, 나머지 경우엔 false반환
            FunctionsForOperators.LogidAND(A, B);
            Console.WriteLine(A & B);

            // NOT
            // A 의 값을 반전. True이면 False로 바꿔주고 false면 true로 반전 시켜줌
            FunctionsForOperators.LogicNOT(A);
            Console.WriteLine(!A);

            //XOR
            //A와 B 둘 중에 하나만 true 일때 true 반환. 나머지의 경우는 false
            FunctionsForOperators.LogicXOR(A, B);
            Console.WriteLine(A ^ B);

            // 조건부 논리연산
            // 연산의 필요성에 대해서 판단을 한 후 연산이 필요 없으면 정해진 결과를 반환함.
            // 연산이 필요하면 연산후의 결과를 반환함.
            // 연산이 필요할때만 연산을 하기 때문에 연산속도가 조금이나마 빠르다.

            //조건부 OR 연산
            FunctionsForOperators.ConditionalLogicOR(A, B);
            Console.WriteLine(A || B);
            //조건부 AND 연산
            FunctionsForOperators.ConditionalLogicAND(A, B);
            Console.WriteLine(A && B);

            // 왜 이걸해?
            //예시 if 문 쓸때
            //if 의 조건을 계산하는데 시간이 걸림
            //if 문이 수백개다 -> 렉이 걸림, 연산하는데 시간이 많이 걸려서 렉이 걸림.

            // 비트 연산자
            // 비트 연산을 하는 이유는 데이터를 효율적으로 관리하기 위함. 논리형의 경우 1bit만 필요한데도 최소단위가 byte이기 때문에 byte 를 사용함
            // 여러개의 논리형을 쓰게 되는 경우 비효율적인 데이터 낭비
            // 이거는 요약본을 보면 더 편하게 볼 수 있을거 같다. excel을 사용해서
            // or
            FunctionsForOperators.BitLogicOR(a, b);
            Console.WriteLine(a | b); //이번에는 소문자 ab를 썼음 이거는 이진수로 해서 둘장 하나라도 있으면 1로 처리하니 
            // and
            FunctionsForOperators.BitLogicAND(a, b);
            Console.WriteLine(a & b);
            //xor, not
            FunctionsForOperators.BitLogicOR(a, b);
            Console.WriteLine(a ^ b);
            FunctionsForOperators.BitLogicNOT(a);
            Console.WriteLine(~a); //비트 연산과 논리 연산에서의 기호가 다름.

            a = 14;
            int howManyBItsYouWantToShift = 3;
            // shift - left
            FunctionsForOperators.BitShiftLeft(a, howManyBItsYouWantToShift);
            Console.WriteLine(a << howManyBItsYouWantToShift);
            // shift - right
            FunctionsForOperators.BItShiftRight(a, howManyBItsYouWantToShift);
            Console.WriteLine(a >> howManyBItsYouWantToShift);
            //언제쓰냐? 
            //FSM(Finit State Machine, 유한 상태 머신)
            //클래스의 상태에 따라 다른 동작이나 조건을 특정 해주기 위해서 사용함.
            //ex 귀환할때 맞으면 귀환이 풀림.플레이어가 귀환중일때 맞으면 귀환이 안된다 이걸 프로그램 할 때 용이함. 
            //특정한 상태의 개수. 모든 상태마다 개발자는 어떠한 것이 일어나는지 정해놈. 이걸 유한 상태 머신안에 넣어둠
            //ex) 플레이어 상태를 FSM에 따라 나누고 , 귀환이 가능한 조건을 FSM의 특정 상태(피격중, 공격중 등등.. )에 구분해 놓는다.
            //사용작 귀환을 눌렀는데 저런 특정상태 ( 피격중, 공격중 등등,,,)이면 귀환이 불가능하도록 코딩을 해놓는다.

            e_FSM FSM = e_FSM.아무것도안하는상태; // or 같은걸 사용해서 3.5 등의 숫자를 조합할 수 있다.
            if(FSM == (e_FSM.공격중인상태 | e_FSM.피격당한상태)){

            }
        }
    }

    [Flags] //Bit - Shift 연산자의 예시
    public enum e_FSM
    {
        아무것도안하는상태 = 0,
        피격당한상태 = 1 << 0,   //첫번째 비트에서 움직임0
        공격중인상태 = 1 << 1,  // 첫번쨰 비트에서 움직임1
        점프중인상태 = 1 << 2,
        달리기중인상태 =1 << 3,
    }
}
