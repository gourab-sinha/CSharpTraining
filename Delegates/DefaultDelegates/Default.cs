using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    //default delegates
    class Show
    {
        public void Fun(int x)
        {
            Console.WriteLine(x);
        }
    }
    class Program
    {
        public static void Main()
        {
            //Func is delegate is already implemented and it always returns hence lambda expression can't be use with it.
            Func<int, int> func = delegate (int x) { return x * x; };
            int result = func(10);
            Console.WriteLine(result);

            //Predicate is default delegates in C# which takes upto 16 parameter and return bool
            Predicate<int> pred = delegate (int x) { if (x % 2 == 0) return true; return false; };// with anonymouy function
            Console.WriteLine(pred(5));

            Predicate<int> pred1 = (x) => false ; // Predicate with lambda expression
            Console.WriteLine(pred1(10)); ;

            Predicate< int> pred2 = (x) => // Predicates with lambda statement
             {
                 if (x == 5)
                     return true;
                 return false;
             };
            Console.WriteLine(pred2(5));

            //Action delegates
            Action<int, int> act = delegate (int x, int y) //anonymous function
             {
                 Console.WriteLine(x*y);
             };
            act(5, 15);

            Action<int> act1 = new Action<int>(new Show().Fun); //action with existing function
            act1(5);

            Action<int> act2 = (x) => { Console.WriteLine(x); };// action with lambda statement
            act2(10);
            Console.ReadKey();

        }
    }
}
