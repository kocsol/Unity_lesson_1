using System;

namespace UnityLesson_CSharp_Array
{
    class Program
    {
        //array
        //형태 : 자료형[]
        //자료형이 정적으로 나열되어있는 형태. 정적이라는 것은 가변적으로 데이터 할당 안됨 즉 한번 데이터 크기를 정하면 바꿀 수 없다.
        static int[] arr_TestInt = new int[5];   //크기가 5
        static float[] arr_TestFloat = new float[3]; // 크기가 3
        static float[] arr_TestFloat2 = { 1.0f, 2.0f, 3.0f, 4.0f }; //크기가 아닌 값을 넣을 수 도 있음
        static string[] arr_TestString = new string[3];
        
        static void Main(string[] args)
        {
            arr_TestInt[0] = 5; // 배열의 특정위치에 값을 넣어주기
            arr_TestInt[1] = 4; // 대괄호 안에 있는 숫자를 index라 함
            arr_TestInt[2] = 3; // arr_TestInt 타입은 배열 arr_TestInt[2] 값은 int형 why? 이건 값이 나와있으니
            arr_TestInt[3] = 2;
            arr_TestInt[4] = 1;
      
            Console.WriteLine(arr_TestInt[0]);
            Console.WriteLine(arr_TestInt[1]);
            Console.WriteLine(arr_TestInt[2]);
            Console.WriteLine(arr_TestInt[3]);
            Console.WriteLine(arr_TestInt[4]);

            arr_TestFloat[0] = 2.0f;
            arr_TestFloat[1] = 4.0f;
            arr_TestFloat[2] = 6.0f;

            Console.WriteLine(arr_TestFloat[0] = 2.0f);
            Console.WriteLine(arr_TestFloat[1] = 4.0f);
            Console.WriteLine(arr_TestFloat[2] = 6.0f);

            arr_TestString[0] = "김아무개";
            arr_TestString[1] = "이아무개";
            arr_TestString[2] = "박아무개";

            Console.WriteLine(arr_TestString[0] = "김아무개");
            Console.WriteLine(arr_TestString[1] = "이아무개");
            Console.WriteLine(arr_TestString[2] = "박아무개");



        }
    }
}
