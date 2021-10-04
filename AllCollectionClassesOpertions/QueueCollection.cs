using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractice.AllCollectionClassesOpertions
{
    public class QueueCollection
    {
        public static void QueueCollectionOperation()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(8);
            queue.Enqueue(100);
            queue.Enqueue(301);
            queue.Enqueue(20);
            queue.Enqueue(1);
            queue.Enqueue(5);
            Console.WriteLine("Total elements present in queue: {0}", queue.Count);
            if (queue.Contains(20))
            {
                Console.WriteLine("Element  20 available...!!");
            }
            else
            {
                Console.WriteLine("Element 20 not available...!!");
            }
            foreach (var item in queue)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Peek element: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + queue.Peek());
        }
    }
}
