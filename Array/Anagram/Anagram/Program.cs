namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            isAnagram("geeksforgeeks", "forgeeksgeeks");
            Console.WriteLine(isAnagram("geeksforgeeks", "forgeeksgeeks"));
        }

        public static bool isAnagram(string a, string b)
        {

            if(a.Length != b.Length)
            {
                return false;
            }

            int[] alphabet = new int[26];

            foreach (char i in a.ToLower())
            {
                int index =  i-97;
                alphabet[index]++;
            }
            foreach (char i in b.ToLower())
            {
                int index = i-97;
                alphabet[index]--; 
            }

            return alphabet.Any(x => x > 0)==false?true:false;
            //return true;
        }
    }
}
