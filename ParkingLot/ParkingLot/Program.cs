using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split(", ");
                string comd = input[0];
                string plate = input[1];
                if (comd == "IN")
                {
                    cars.Add(plate);
                }
                if (comd == "OUT")
                {
                    if (cars.Contains(plate))
                    {
                        cars.Remove(plate);
                    }
                }
            }
            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var plate in cars)
                {
                    Console.WriteLine(plate);
                }
            }
        }
    }
}
