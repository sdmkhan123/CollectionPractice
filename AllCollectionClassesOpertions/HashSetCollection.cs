using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractice.AllCollectionClassesOpertions
{
    public class HashSetCollection
    {
        public static void HashSetCollectionOperation()
        {
            var hashSet = new HashSet<string>();
            hashSet.Add("Saddam");
            hashSet.Add("Khan");
            hashSet.Add("Hello");
            hashSet.Add("Hi");
            hashSet.Add("BridgeLabz");
            foreach(var item in hashSet)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n");
            //
            hashSet.Remove("Hello");
            foreach (var item in hashSet)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n");
            //Union and Intersection opearton on set
            var hashSet1 = new HashSet<string>();
            var hashSet2 = new HashSet<string>();
            hashSet1.Add("C");
            hashSet1.Add("C++");
            hashSet1.Add("C#");
            hashSet1.Add("Java");
            hashSet1.Add("Ruby");
            hashSet2.Add("PHP");
            hashSet2.Add("C++");
            hashSet2.Add("Perl");
            hashSet2.Add("Java");
            // Using Union operation
            hashSet1.UnionWith(hashSet2);
            foreach (var item in hashSet1)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n");
            //Using intersection operation
            hashSet1.IntersectWith(hashSet2);
            foreach (var item in hashSet1)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n");
        }
    }
}
