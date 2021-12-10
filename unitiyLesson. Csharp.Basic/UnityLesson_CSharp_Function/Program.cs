using System;

namespace UnityLesson_CSharp_Function
{
    class Program
    {
        static bool doPrintHelloWorld = true;
        static void Main(string[] args)
        {
            if (doPrintHelloWorld == true)
            {
                PrintHelloWorld();
            }

            string tmpsomething = "blah blah";
            bool tmpisFInished = false;
            tmpisFInished = PrintSomethingAndReturnIfFinished(tmpsomething);
            Console.WriteLine(tmpisFInished);
            
            
            PrintSomething(tmpsomething);  //tmpseomthing 은 여기서 parameter

            PrintSomethingAndReturnIfFinished(tmpsomething);
        }

        static void PrintHelloWorld() //main이 정적인 함수이기에 main에서 사용하려면 이거도 정적인 함수여야함.
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintSomething(string something) //args 이름 something
        {
            Console.WriteLine(something);
        }
        static bool PrintSomethingAndReturnIfFinished(string something)
        {
            bool isFinished = false;
            Console.WriteLine(something);
            isFinished = true;
            return isFinished;
        }

    }
}
