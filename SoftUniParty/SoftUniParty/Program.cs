using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vips = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();
            string command = string.Empty;
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while ((command = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(command[0]))
                {
                    vips.Add(command);
                }
                else
                {
                    guests.Add(command);
                }
            }
            string members = string.Empty;
            while ((members = Console.ReadLine()) != "END")
            {
                if (char.IsDigit(members[0]))
                {
                    vips.Remove(members);
                }
                else
                {
                    guests.Remove(members);
                }
            }
            Console.WriteLine(vips.Count+guests.Count);
            foreach (var member in vips)
            {
                Console.WriteLine(member);
            }
            foreach (var member in guests)
            {
                Console.WriteLine(member);
            }
        }
    }
}
