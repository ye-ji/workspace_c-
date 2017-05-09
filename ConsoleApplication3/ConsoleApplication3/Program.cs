using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmorSuite armorSuite = new ArmorSuite();
            armorSuite.Initialized();

            IronMan ironMan = new IronMan();
            ironMan.Initialized();

            WarMachine warMachine = new WarMachine();
            warMachine.Initialized();

        }
    }

    class ArmorSuite
    {
        public virtual void Initialized()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialized()
        {
            base.Initialized();
            Console.WriteLine("Iron Man");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialized()
        {
            base.Initialized();
            Console.WriteLine("warmachine");
        }
    }
}
