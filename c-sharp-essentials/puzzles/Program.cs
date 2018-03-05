using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzles {
    class Program {

        public static void randomArray() {
            List<int> randomArray = new List<int>();
            Random rand = new Random();
            int sum = 0;
            for (int i = 0; i < 10; i++) {
                randomArray.Add(rand.Next(5, 25));
            }
            int min = randomArray[0];
            int max = randomArray[0];
            for (int i = 0; i < randomArray.Count; i++) {
                sum += randomArray[i];
                if (randomArray[i] > max) {
                    max = randomArray[i];
                }
                if (randomArray[i] < min) {
                    min = randomArray[i];
                }
            }
            randomArray.ForEach(number => Console.WriteLine(number));
            Console.WriteLine($"Min: {min}\nMax: {max}\nSum: {sum}");
        }

        public static string TossCoin() {
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int coin = rand.Next(0, 2);
            if (coin == 0) {
                Console.WriteLine("Heads");
                return "Heads";
            } else {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }

        public static void TossMultipleCoins(int num) {
            int heads = 0;
            int tails = 0;
            double ratio = 0;
            for (int i = 0; i < num; i++) {
                string result = TossCoin();
                if (result == "Heads") {
                    heads++;
                } else {
                    tails++;
                }
            }
            ratio = heads / tails;
            Console.WriteLine(ratio);
        }

        public static void Names() {
            List<string> names = new List<string>();
            var rnd = new Random();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            // Randomize the order of the list
            names = names.OrderBy(x => rnd.Next()).ToList();
            // Print the new shuffled array
            Console.WriteLine("SHUFFLED NAMES");
            foreach(var name in names) {
                Console.WriteLine(name);
            }
            // Print names that are longer than 5 characters
            Console.WriteLine("LONGER THAN 5");
            foreach(var name in names) {
                if(name.Length > 5) {
                    Console.WriteLine(name);
                }
            }
        }
        static void Main(string[] args) {
            Names();
        }
    }
}