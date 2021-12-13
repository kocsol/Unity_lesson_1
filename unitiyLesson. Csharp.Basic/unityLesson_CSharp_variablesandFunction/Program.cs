using System;

namespace unityLesson_CSharp_variablesandFunction
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //CamelCase (이름 설정 규칙)
        //class Function namespace 등은 대문자로 시작한다.
        //변수는 소문자로 시작한다.
        //단어가 바뀔경우 첫문자를 대문자로 한다.
        //SayAge()를 SA() Sh() 막 줄이면 알아보기 힘듦 즉 줄임말은 되도록 사용하지 않는다.
        //이름을 보았을때 어떤 기능, 목적인지 알 수 있도록 작성한다.
        //애매한 부분이 있으면 주석을 달아준다. 

        class Person
        {
            int age; //나이
            float heihgt; //키
            bool isFemale; //여자인가?
            char genderChar; // 성별 문자
            string name; // 이름


            
            void SayAllInfo()
            {

                //Console.WriteLine($"나이 : {age}, 키 : {height}, "); 이렇게 쭉쭉 적어난가는 것보단 만들어 놓은 함수들을 사용해 나가는 것이 훨신 좋음
                SayAge();
                Sayheight();
                SayisFemale();
                SayGenderChar();
                SayName();


            }


            
            void SayAge() //콘솔창에 반환하는 것이 아닌 콘솔에 나오기만하면되니
            {
                Console.WriteLine($"나이 : {age}"); //문자끼리 더할때 플러스 연산자 사용 C샵에서는 알아서 문자형을 바꿔주니 포멧팅 안해줘도 됨 그래도 비추 오해가 생길 수 있으니 해당 괄호처럼 사용
            }
            void Sayheight()
            {
                Console.WriteLine($"키 : {heihgt}");
            }
            void SayisFemale()
            {
                Console.WriteLine($"여자인가? : {isFemale}");

            }

            void SayGenderChar()
            {
                Console.WriteLine($"성별문자 : {genderChar}");
            }

            void SayName()
            {
                Console.WriteLine($"이름 : {name}");
            }
        }


    }
}
