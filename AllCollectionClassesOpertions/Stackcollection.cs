using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractice.AllCollectionClassesOpertions
{
    public class Stackcollection
    {
        public static void StackCollectionOperation()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(5);
            stack.Push(6);
            stack.Push(3);
            stack.Push(20);
            if (stack.Contains(6) == true)
            {
                Console.WriteLine("Element 6 is found...!!");
            }
            else
            {
                Console.WriteLine("Element 6 is not found...!!");
            }
            Console.WriteLine("Total elements present in " + "stack: {0}", stack.Count);
            foreach (int item in stack)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Peek element: " + stack.Peek());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("After Pop, Peek element: " + stack.Peek());
        }
    }
}
