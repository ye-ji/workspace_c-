using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7_delegate
{
    /*
     * [접근한정자] delegate return형 델리케이트형명(메소드 매개변수);
     * delegate int DelegateType(string Name);
     */
    // delegate void DelegateType(string str);

    class A
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }


    /*
     * 멀티캐스트 델리케이트
     * multicast delegate 
     */


    delegate void DelegateType();
    class C
    {
        public void printA()
        {
            Console.WriteLine("printA");
        }

        public void printB()
        {
            Console.WriteLine("printB");
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            /*
            A Test = new ConsoleApplication7_delegate.A();
            DelegateType delMethod1 = new DelegateType(Test.Print); // C# 1.0 이상
            delMethod1("Hello World");

            DelegateType delMethod2 = Test.Print;
            delMethod2("Hello World!!!!!"); // C# 2.0 이상 
            */
            // --------------------------------------

            C test = new C();
            DelegateType delFunc = test.printA;
            delFunc += test.printB; // add delegate
            delFunc();
            delFunc -= test.printB; // remove delegate
            delFunc();

        }
    }
}
