using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7_static
{


    class MyClass
    {
        public static int number = 12;
        public static void Print()
        {
            Console.WriteLine("Hello World");
        }
    }

    class Program
    {

        static string Message = "Hello";
        static void Print() { Console.WriteLine(Message); }

        static void Main(string[] args)
        {

            Print();


            MyClass.Print();
            Console.WriteLine(MyClass.number);


            MyClass.number = 200;

            MyClass test = new MyClass();
            Console.WriteLine(MyClass.number);

        }


    }
}
