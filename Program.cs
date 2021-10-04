using System;
using CollectionPractice.AllCollectionClassesOpertions;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================================================\n");
            Console.WriteLine("Welcome to Collection Practice");
            Console.WriteLine("\n===============================================================================\n");
            Console.WriteLine("Welcome to List Collection Practice");
            ListCollection.ListCollectionOperation();
            Console.WriteLine("\n===============================================================================\n");
            Console.WriteLine("Welcome to HashSet Collection Practice");
            HashSetCollection.HashSetCollectionOperation();
            Console.WriteLine("\n===============================================================================\n");
            Console.WriteLine("Welcome to Dictionaary Collection Practice");
            DictonaryCollection.DictionaryCollectionOperation();
            Console.WriteLine("\n===============================================================================\n");
            Console.WriteLine("Welcome to LinkedList Collection Practice");
            LinkedListCollection.LinkedListCollectionOperation();
            Console.WriteLine("\n===============================================================================\n");
            Console.WriteLine("Welcome to Stack Collection Practice");
            Stackcollection.StackCollectionOperation();
            Console.WriteLine("\n===============================================================================\n");
            Console.WriteLine("Welcome to Queue Collection Practice");
            QueueCollection.QueueCollectionOperation();
            Console.WriteLine("\n===============================================================================");
        }
    }
}
