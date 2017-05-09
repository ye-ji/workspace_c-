using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8Class
{
    class MyClass
    {
        public int number;
        public MyClass()
        {
            number = 12;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyTest = new MyClass();
            MyClass RefClass = MyTest;
            RefClass.number = 7;
            Console.WriteLine(MyTest.number);
        }
    }
}
