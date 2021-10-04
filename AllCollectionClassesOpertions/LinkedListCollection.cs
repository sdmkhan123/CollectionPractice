using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractice.AllCollectionClassesOpertions
{
    public class LinkedListCollection
    {
        public static void LinkedListCollectionOperation()
        {
            //C# LinkedList<T> class uses the concept of linked list. It allows us to insert and delete elements fastly.
            //It can have duplicate elements. It is found in System.Collections.Generic namespace.
            var LL = new LinkedList<string>();
            LL.AddLast("Hello");
            LL.AddLast("Hi");
            LL.AddLast("Saddam");
            LL.AddLast("Khan");
            LL.AddFirst("BridgeLabz");
            LL.AddFirst("Happy");
            foreach (var item in LL)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            // check the availability of the elements in the LinkedList
            if (LL.Contains("Saddam") == true)
            {
                Console.WriteLine("Element Found...!!");
            }
            else
            {
                Console.WriteLine("Element Not found...!!");
            }

            // remove elements from the LinkedList
            LL.Remove(LL.First);
            foreach (var item in LL)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            LL.Remove("Saddam");
            foreach (var item in LL)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            LL.RemoveLast();
            foreach (var item in LL)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
