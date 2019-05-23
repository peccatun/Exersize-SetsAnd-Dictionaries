using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            HashSet<int> numsOne = new HashSet<int>();
            HashSet<int> numsTwo = new HashSet<int>();
            for (int i = 0; i < nums[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numsOne.Add(number);
            }
            for (int i = 0; i < nums[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numsTwo.Add(number);
            }
            List<int> result = new List<int>();
            foreach (var number in numsOne)
            {
                if (numsTwo.Contains(number))
                {
                    result.Add(number);
                }
            }
            Console.WriteLine(string.Join(' ',result));
        }
    }
}
