using System;
// structure
//변수들의 집합을 하나의 자료형으로 표현
//변수들을 여러가지 써야하는데, 해당 변수들의 집합을 사용한 곳이 많거나
//변수 집합의 요소가 너무 많아, 묶어서 따로 분리해야 가독성과 관리가 편할 거 같을 때 사용
// 구조체의 구조는 클래스에서 함수가 빠진것과 같다.

namespace UnityLesson_CSharp_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior._stats._STR = 10;
            warrior._stats._DEX = 20;
            warrior._stats._CON = 30;
            warrior._stats._WIS = 40;
            warrior._stats._INT = 50;
            warrior._stats._REG = 60;

            Warrior[] arr_Warrior = new Warrior[10];
            //구조체 변수를 생성하고 초기화 하는 방법
            Stats stats_Warrior = new Stats();
            

            int length = arr_Warrior.Length;
            for (int i = 0; i < length; i++)
            {
                arr_Warrior[i] = new Warrior();
                arr_Warrior[i]._stats = stats_Warrior;
            }

            for (int i = 0; i < length; i++)
            {
                arr_Warrior[i].SetStats(100,200,300,400,500,600);  // 하나 하나 입력하는 것이 아닌 warrior에 SetStats 함수를 만들어서 짧고 보기 좋게 만든다
            }

            // EquipmentAbility equipmentAbility = new EquipmentAbility();
            // int a = EquipmentAbility._ATK; 만약에 ATK를 static으로 설정해서 이 값을 변하지 않게 하려면 
        }
    }
}
