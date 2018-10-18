using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    [Obsolete("Use class B")] //tells compiler that class A is no more in use
    class A
    {
        public void MethodA()
        {
            Console.WriteLine("Method A");
        }
    }
    class B
    {
        [Obsolete("Use MethodBB", true)] //tells compiler that MethodB is depricated 
        public void MethodB()
        {
            Console.WriteLine("Method B");
        }
        public void MethodBB()
        {
            Console.WriteLine("Method BB");
        }
    }
    class Program
    {
        public static void Main()
        {
            A a = new A();
            a.MethodA();
            B b = new B();
            b.MethodB();
            b.MethodBB();
        }
    }
}
