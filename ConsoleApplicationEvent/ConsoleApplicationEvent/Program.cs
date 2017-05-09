using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationEvent
{

    /*
     * [접근한정자] event 델리게이트형명 이벤트명 
     * */


    delegate void DelegateType(string message);
    
    class A
    {
        public event DelegateType EventHandler; // eventHandler에 여러가지 메소드들이 연결될 예정
        public void Func(string Message) 
        {
            EventHandler(Message); // 메소드 안에서 event를 호출
        }
    }

    class B
    {
        public void printA(string Message)
        {
            Console.WriteLine(Message);
        }

        public void printB(string Message)
        {
            Console.WriteLine(Message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A Test1 = new A();
            B Test2 = new B();

            // 객체.이벤트핸들러 += new 델리게이트형(객체.메소드);
            // 객체.이벤트핸들러 += 객체.메소드1;
            // 객체.이벤트핸들러 += 객체.메소드2;

            Test1.EventHandler += new DelegateType(Test2.printA);
            Test1.EventHandler += new DelegateType(Test2.printB);
            Test1.Func("Good");
            Test1.EventHandler -= Test2.printB;
            Test1.Func("Hi ~~~~~~");
            Test1.EventHandler -= Test2.printA;

            Test1.EventHandler += Test2.printA;
            Test1.EventHandler += Test2.printB;
            Test1.Func("Um....");
        }
    }
}
