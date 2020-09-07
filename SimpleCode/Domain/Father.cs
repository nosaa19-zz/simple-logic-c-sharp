using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCode.Domain
{
    public class Father
    {
        public virtual void method01() 
        {
            Console.WriteLine("Father:Method01");
        }

        public void method02()
        {
            Console.WriteLine("Father:Method02");
        }

        public void method03()
        {
            Console.WriteLine("Father:Method03");
            method01();
            method02();
        }
    }
}
