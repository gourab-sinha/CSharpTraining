using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    class Items
    {
        public string itemname { get; set; }
        public int itemquantitiy { get; set; }
        public double itemprice { get; set; }
    }
    class Store
    {
        public string NameStore { get; set; }
        public int storeNumber { get; set; }
        Items[] items = new Items[50];
        public Items this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
    }
    class Program
    {
        public static void Main()
        {
            Store store = new Store() { NameStore = "ABC", storeNumber = 101 };
            store[0] = new Items() { itemname = "Apple", itemquantitiy = 5, itemprice = 100.56 };
            store[1] = new Items() { itemname = "Banana", itemquantitiy = 10, itemprice = 102.50 };
            Console.WriteLine(store[0].itemname + " " +store[0].itemprice + " " + store[0].itemquantitiy);
            Console.ReadLine();
        }
    }
}
