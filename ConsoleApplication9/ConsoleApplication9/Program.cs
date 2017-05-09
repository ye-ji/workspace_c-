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
        public int Count
        {
            get { return count; }
            set { count = value; }
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

        }
    }
}
