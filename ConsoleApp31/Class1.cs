using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Class1
    {
        private int v;

        public Class1(int v)
        {
            this.v = v;
        }

        public void Method1()
        {
            Console.WriteLine("Method1");
            Console.WriteLine("Method1");
            Console.WriteLine("Method1");
            //test
        }
    }

    public class Class2
    {
        Class1 obj = new(2);
        public Class2(int v) {
        }

        public class Class3
        {
            Class1 obj = new(3);
    }
    }
}