using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string countMe = Console.ReadLine();
            SortedDictionary<char, int> lettersCount = new SortedDictionary<char, int>();
            foreach (var ch in countMe)
            {
                if (!lettersCount.ContainsKey(ch))
                {
                    lettersCount.Add(ch, 0);
                }
                lettersCount[ch]++;
            }
            foreach (var ch in lettersCount)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
