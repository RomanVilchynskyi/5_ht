using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ht
{
    public abstract class Worker
    {
        public abstract void Print();
    }

    public class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("President controls everything");
        }
    }

    public class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("secirity provides safety");
        }
    }

    public class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Manager manage projects");
        }
    }

    public class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Engineer develops technical solutions");
        }
    }

}
