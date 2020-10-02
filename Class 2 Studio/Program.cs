using System;
using System.Collections.Generic;

namespace Class_2_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text for character count: ");
            string inputText = Console.ReadLine();
            inputText = inputText.ToUpper();
            //Console.WriteLine(inputText);
            char[] inputArray = inputText.ToCharArray();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach(char c in inputArray)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else if (Char.IsLetter(c))
                {
                    counts.Add(c, 1);
                }
            }

            foreach (KeyValuePair<char,int> eachChar in counts)
            {
                Console.WriteLine(eachChar.Key + ": " + eachChar.Value);
            }
        }
    }
}
