using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7_Indexer
{
    /*
     * 클래스 내의 배열 또는 컬렉션을 외부에서 접근할 수 있게 한다.
     * 배열/컬렉션이 public이 아닌 private 인 경우 사용
     */

    class A
    {
        int[] number = { 1, 2, 3, 4, 5 };
        public int this[int index] // 인덱서
        {
            get { return number[index]; }
            set { number[index] = value; }
        }
    }


    class B
    {
        ArrayList List = new ArrayList();
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < List.Count)
                    return (string)List[index];
                else
                    return null;
            }

            set
            {
                if (index > 0 && index < List.Count)
                    List[index] = value;
                else
                    List.Add(value);
            }
        }

        public void Print()
        {
            foreach(string m in List)
            {
                Console.WriteLine(m);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A Test = new ConsoleApplication7_Indexer.A();
            Console.WriteLine(Test[2]);
            Test[2] = 300;
            Console.WriteLine(Test[2]);
            // --------------------------------------------

            B test = new ConsoleApplication7_Indexer.B();
            test[3] = "A";
            test[3] = "B";
            test[3] = "C";
            test[3] = "D";
            test[3] = "E";

            test.Print();

            Console.WriteLine("\n{0}", test[2]);

        }
    }
}
