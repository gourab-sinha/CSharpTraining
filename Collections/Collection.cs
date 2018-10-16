using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    class Program
    {
        public void show()
        {
            Console.WriteLine("Show is called");
        }
        public static void Main()
        {
            //List Collection ****************
            List<string> list = new List<string>() { "Pranay","Rahul"};// Collection initialization
            list.Add("Gourab");
            list.Add("Sourab");
            list.Add("Aryan");
            //IEnumerable for iterate all the names present in the list of string.
            IEnumerable<string> it = list;
            foreach (var names in it)
            {
                if (names == "Gourab")
                    new Program().show();
                Console.WriteLine(names);
            }
            //IEnumerable for iterate all the addresses where values are stored in the list
            IEnumerator<string> it1 = list.GetEnumerator();
            while(it1.MoveNext())
            {
                if (it1.Current == "Gourab")
                    new Program().show();
                Console.WriteLine(it1.Current); // current is used to access the value present in the list;
            }
            //List End ***************
            Console.WriteLine();
            //Dictionary (Key,Value) ***************
            Dictionary<int, string> dictionary = new Dictionary<int, string>() { { 1, "Gourab" }, { 2, "Aryan" }
                , { 3, "Rohit" }, { 4, "Akshay" } }; // collection initializer
            dictionary[4] = "Ankit";
            dictionary[5] = "Rahul";
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            IDictionary<int, string> itDictionary = dictionary;
            foreach(var item in itDictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            //Dictionary End *************************
            Console.WriteLine();
            //Stack Collection
            Stack<string> stack = new Stack<string>();
            stack.Push("Gourab");
            stack.Push("Aryan");
            stack.Push("Akshay");
            IEnumerable<string> itstack = stack; //stack is list of collections with push,peek,pop functions
            foreach (var item in itstack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //Stack End ****************************

            Console.WriteLine();
            //Queue Collection
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Gourab");
            queue.Enqueue("Aryan");
            queue.Enqueue("Akshay");
            IEnumerable<string> itqueue = queue; //queue is list of collections with Enqueue,dequeue functions
            foreach (var item in itstack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //Queue End ******************************

            Console.ReadKey();
        }
    }
}
