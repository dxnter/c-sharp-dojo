using System;
using System.Collections.Generic;

namespace collections_practice {
    class Program {
        static void Main(string[] args) {
            // Three Basics Arrays
            int[] zeroToNine = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] names = { "Tim", "Martin", "Nikki", "Sara" };
            bool[] truefalse = { true, false, true, false, true, false, true, false, true, false };

            // Multiplication Table
            int[, ] multiplicationTable = new int[10, 10];
            for (int x = 0; x <= 9; x++) {
                for (int z = 0; z <= 9; z++) {
                    multiplicationTable[x, z] = (x + 1) * (z + 1);
                    Console.Write(string.Format("{0} ", multiplicationTable[x, z]));
                }
                Console.Write(Environment.NewLine);
            };

            // List of Flavors
            List<string> flavors = new List<string>();
            flavors.Add("Cookies 'N Cream");
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Mint Chocolate Chip");
            // Display the length of the list
            Console.WriteLine("Length: {0}", flavors.Count);
            // Output the third then remove it's value
            Console.WriteLine(flavors[2]);
            flavors.Remove("Chocolate");
            // Output the new length
            Console.WriteLine("Length: {0}", flavors.Count);

            // User Info Dictionary
            Dictionary<string, string> users = new Dictionary<string, string>();
            Random rand = new Random();
            foreach (string name in names) {
                users.Add(name, flavors[rand.Next(0, flavors.Count)]);
            }

            // Output each user and their favorite flavor
            foreach (var user in users) {
                Console.WriteLine("{0} {1}", user.Key, user.Value);
            }
        }
    }
}