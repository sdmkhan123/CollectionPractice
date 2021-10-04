using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractice.AllCollectionClassesOpertions
{
    public class DictonaryCollection
    {
        public static void DictionaryCollectionOperation()
        {
            Dictionary<int, string> My_dict1 = new Dictionary<int, string>();
            My_dict1.Add(1, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(2, "Saddam");
            My_dict1.Add(3, "Khan");

            foreach (KeyValuePair<int, string> key in My_dict1)
            {
                Console.WriteLine("at key {0} the value is :- {1}", key.Key, key.Value);
            }
            //check the availability of elements in the Dictionary
            if (My_dict1.ContainsKey(1124))
            {
                Console.WriteLine("Key is found...!!");
            }
            else
            {
                Console.WriteLine("Key is not found...!!");
            }
            // Using ContainsValue() method to check  the specified value is present or not
            if (My_dict1.ContainsValue("Saddam"))
            {
                Console.WriteLine("Value is found...!!");
            }
            else
            {
                Console.WriteLine("Value is not found...!!");
            }
            // Using Remove() method 
            My_dict1.Remove(2);
            Console.WriteLine();
            foreach (KeyValuePair<int, string> key in My_dict1)
            {
                Console.WriteLine("at key {0} the value is :- {1}", key.Key, key.Value);
            }
        }
    }
}
