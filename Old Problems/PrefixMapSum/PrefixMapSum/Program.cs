using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixMapSum
{
    class Program
    {

        //Implement a PrefixMapSum class with the following methods:
        //insert(key: str, value: int) : Set a given key's value in the map. If the key already exists, overwrite the value.
        //sum(prefix: str) : Return the sum of all values of keys that begin with a given prefix.
        static void Main(string[] args)
        {
            Dictionary< string, int> My_dict1 = new Dictionary<string, int>();
            AddOrUpdateDictionaryEntry(  "Welcome", 1123);
            AddOrUpdateDictionaryEntry(   "to", 1124);
            AddOrUpdateDictionaryEntry( "GeeksforGeeks", 1125 );
            AddOrUpdateDictionaryEntry("GeeksforGeeks", 1124);


            foreach (KeyValuePair< string, int> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();

            string result = FindKey(My_dict1, "Wel");
            Console.WriteLine(result);


            void AddOrUpdateDictionaryEntry(string key, int value)
            {
                if (My_dict1.ContainsKey(key))
                {
                    My_dict1[key] = value;
                }
                else
                {
                    My_dict1.Add(key, value);
                }
            }

            string FindKey<T>(Dictionary<string, T> dict, string prefix)
            {
                foreach (string key in dict.Keys)
                {
                    if (key.StartsWith(prefix))
                    {
                        return key;
                    }
                }
                return null;
            }
        }

     
    }
}
