using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    //generic class with no generic function
    
    class Fun1<T>
    {
       public void fun1()
        {
            Console.WriteLine("Show is called");
        }
    }
    //non generic class with generic function
    class Fun11
    {
        public void fun11<T>(T x)// generic function
        {
            Console.WriteLine(x);
        }
    }
    //generic class with generic function
    delegate void delegatewithGeneric<T>(T x);
    class Fun2<T1,T2>
    {
        public void fun2(T1 x,T2 y)// generic function with two generic types
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
    class Program
    {
        public static void Main()
        {
            //class with non generic funciton
            Fun1<int> fun1obj = new Fun1<int>();
            fun1obj.fun1();
            Console.WriteLine();
            //generic class with generic function
            Fun2<Fun1<int>, int> fun2obj = new Fun2<Fun1<int>, int>();
            fun2obj.fun2(fun1obj, 10);
            Console.WriteLine();
            //generic function call with generic delegates
            delegatewithGeneric<int> dlwithGeneric = new delegatewithGeneric<int>(new Fun11().fun11);
            dlwithGeneric(10);
            Console.WriteLine();
            //generic delegate with anonymous function
            delegatewithGeneric<double> dlanonymous = delegate (double x) { Console.WriteLine(x); };
            dlanonymous(102.0154);
            Console.ReadLine();
        }
    }
}
