using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CharFinder f = new CharFinder();
            var result=f.findFirstNonRepeatingChar("a green apple");
            Console.WriteLine(result);
        }
    }

    public class CharFinder
    {
        public char findFirstNonRepeatingChar(string str)
        {
            Dictionary<string,int> dictionarycharacter = new Dictionary<string,int>();

            foreach (char s in str)
            {
                if (dictionarycharacter.ContainsKey(s.ToString()))
                {
                    var count = dictionarycharacter[s.ToString()];
                    dictionarycharacter[s.ToString()] = count+1;
                }
                else
                {
                    dictionarycharacter[s.ToString()] = 1;
                }
            }

            foreach (char s in str)
            {
                if(dictionarycharacter[s.ToString()]==1)
                {
                    return s;
                }
            }

            return char.MinValue;
        }
        
    }
}
