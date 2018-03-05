using System;
using System.Collections.Generic;

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
        static void Main(string[] args) {
            randomArray();
        }
    }
}