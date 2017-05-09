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
    delegate void DelegateType(string str);

    class A
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A Test = new ConsoleApplication7_delegate.A();
            DelegateType delMethod1 = new DelegateType(Test.Print); // C# 1.0 이상
            delMethod1("Hello World");

            DelegateType delMethod2 = Test.Print;
            delMethod2("Hello World!!!!!"); // C# 2.0 이상 



        }
    }
}
