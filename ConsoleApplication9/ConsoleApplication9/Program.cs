using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class MyClass
    {
        int count;
        string name;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public MyClass(int count)
        {
            this.count = count;
        }

        public void Print()
        {
            Console.WriteLine(count);
        }
    }


    class A
    {
        int number;
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set
            {
                if (value < 0 || value > 9)
                    number = 0;
                else
                    number = value;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            MyClass Test = new ConsoleApplication9.MyClass(3);
            Console.WriteLine(Test.Count); // get

            int Sum = Test.Count + 10;
            Console.WriteLine(Sum);

            Test.Count = 20; // set
            Test.Print();

            Console.WriteLine("\n\n\n");

            A MyTest = new ConsoleApplication9.A();
            MyTest.Name = "C#";
            MyTest.Number = 3;
            Console.WriteLine("{0} {1}", MyTest.Name, MyTest.Number);

            MyTest.Number = -3;
            Console.WriteLine(MyTest.Number);
        }
    }
}
