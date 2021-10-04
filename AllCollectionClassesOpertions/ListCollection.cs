using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractice.AllCollectionClassesOpertions
{
    public class ListCollection
    {
        public static void ListCollectionOperation()
        {
            //add elements from the List
            var list = new List<string>();
            list.Add("Saddam Khan");
            list.Add("Hello");
            list.Add("Hi");
            list.Add("BridgeLabz");
            /*for (int a = 0; a < list.Count; a++)
            {
                Console.WriteLine(list[a]);
            }*/
            //list.ForEach (i => Console.WriteLine(i)) ;
            foreach (var item in list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            var list2 = new List<int>();
            list2.Add(1);
            list2.Add(10);
            list2.Add(100000);
            list2.Add(496);
            list2.Add(100);
            list2.Add(1000000);
            list2.Add(1000);
            list2.Add(10000);
            list2.ForEach(item => Console.Write(item + ", "));
            Console.WriteLine("\n");

            //to sort list
            Console.WriteLine("Sort the given List");
            Console.WriteLine("Before sorting the List:");
            list2.ForEach(item => Console.Write(item + ", "));
            Console.WriteLine("After sorting the List:");
            list2.Sort();
            list2.ForEach(item => Console.Write(item + ", "));
            Console.WriteLine("\n");
            //remove elements from the List
            Console.WriteLine("remove elements from the List");
            // remove the first occurrence of a specific object from the List.
            list2.Remove(10);
            // remove the element at the specified index of the List.
            list2.RemoveAt(4);
            // remove a range of elements from the List.
            list2.RemoveRange(0, 2);
            Console.WriteLine("After removing elements ");
            list2.ForEach(item => Console.Write(item + ", "));
            Console.WriteLine("\n");
            // remove all elements from the List
            list2.Clear();
            Console.WriteLine("After clear the list, elements in the lsit are ");
            list2.ForEach(item => Console.Write(item + ", "));
            Console.WriteLine("List is empty");
        }
    }
}
