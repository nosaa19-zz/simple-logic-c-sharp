using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCode.Domain
{
    class Child : Father
    {
        public override void method01() 
        {
            Console.WriteLine("Child:Method01");
        }

        public new void method02()
        {
            Console.WriteLine("Child:Method02");
        }

        public new void method03()
        {
            Console.WriteLine("Child:Method03");
        }
    }
}
