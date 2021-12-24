using System;
using System.Collections.Generic; // Generi collctions. 를 쓰기 위해 필요한 namespace
//collection?
//동적 배열이라고 함.
//Array 와 다르게 크기를 정해놓지 않고
//Collection 단어 뜻대로 수집하듯이
//아이템들을 추가하거나 뺄 수 있으며, 그에 따라 데이터가 유동적으로 변한다.

namespace UnityLesson_CSharp_Collection
{
	class Program
	{
		static void Main(string[] args)
		{
			//List
			//=========================================================================
			List<int> _list = new List<int>();
			_list.Add(3);
			_list.Add(2);
			_list.Add(1);
			_list.Add(0);
			_list.Add(3);

			//remove 함수
			//0번째 인덱스부터 탐색하고 , 첫번째로 인자와 같은 요소를 발견하면 삭제
			//삭제를 성공시 true를 반환. 인자와 같은 요소를 찾지 못하면 false를 반환
			_list.Remove(3);

			int length = _list.Count;
			for (int i = 0; i < length; i++)
			{
				int tmpNumber = _list[i];
				Console.WriteLine(tmpNumber);
			}

			//foreach는 collection이 가지고 있는 type의 아이템 만큼 반복문을 실행하면서 각 아이템을 반환한다.
			foreach (int num in _list)  // num매개변수 이름
			{
				Console.WriteLine(num);
				// foreach 가 첨음 돌때는 num에 _list[0]반환
				//두번째 돌때는 num에 _list[1]반환
			}

			//===========================================================================
			//dictonary
			//=============================================================================
			Dictionary<string, string> _dic = new Dictionary<string, string>();
			_dic.Add("검사", "양손대검을 사용해서 물리공격을 하는 클래스");
			_dic.Add("마법사", "지팡이를 사용하여 마법공격을 하는 클래스");
			_dic.Add("수호자", "창과 방패를 사용하여 물리공격 및 방어 위주의 클래스");

			_dic.Remove("검사");
			bool isSwordMaster = _dic.ContainsKey("검사");  //bool형으로 나옴
			if (isSwordMaster)
			{
				string tmpValue = _dic["검사"];
				Console.WriteLine($"검사 : {tmpValue}");

			}
			else
			{
				Console.WriteLine("검사를 찾을 수 없습니다.");
			}

			//Dictionary도 foreach 구문 가능하다.
			//dictionary 도 collection 이고
			//dictionary의 key도 collection이고
			//dictionary의 value도 collection이다.
			//즉 위 세가지 모두 foreach 구문이 가능하다.
			foreach (string sub in _dic.Keys)   //돌아갈때마다 각각의 key값
			{
				string tmpValue = _dic[sub];
				Console.WriteLine($"{sub} : {tmpValue}");

			}
			//아래 두가지는 실제 상ㅇ 많이 안함
			foreach (string sub  in _dic.Values)
			{
				Console.WriteLine(sub);

			}
			foreach (KeyValuePair<string,string> sub in _dic) // 변수의 타입을 모를때 var을 쓰면 컴파일러가 알아서 해주지만  var위에 오려보면 알려줌
			{
				string tmpKey = sub.Key;
				string tmpValue = sub.Value;
				Console.WriteLine($"{tmpValue} : {tmpValue}");

			}
			//위 세가지 경우가 있지만
			//dictionary는 단어 뜻대로 사전처럼 사용하기 위한 collection이ㅏㄷ.
			//자세한 내용은 onenote 에 잘 적혀있다. 12/24일 원노트 내용
					
					
		}

 			//Stack  후입선출
			//queue  선입선출

		}
	}
}
