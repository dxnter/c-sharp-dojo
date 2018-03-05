using System;
using System.Collections.Generic;

namespace puzzles {
    class Program {

        public static void randomArray() {
            List<int> randomArray = new List<int>();
            Random rand = new Random();
            int sum = 0;
            int min = 0;
            int max = 0;
            for (int i = 0; i < 10; i++) {
                randomArray.Add(rand.Next(5, 25));
                sum += randomArray[i];
                if (randomArray[i] > max) {
                    max = randomArray[i];
                } else if (randomArray[i] < min) {
                    min = randomArray[i];
                }
            }
            Console.WriteLine($"Min: {min}, Max: {max}, Sum: {sum}");
        }
        static void Main(string[] args) {
            randomArray();
        }
    }
}