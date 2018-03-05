using System;
using System.Collections.Generic;

namespace puzzles {
    class Program {

        public static void randomArray() {
            List<int> randomArray = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 10; i++) {
                randomArray.Add(rand.Next(5, 25));
            }
            foreach (var number in randomArray) {
                Console.WriteLine(number);
            }
        }
        static void Main(string[] args) {
            randomArray();
        }
    }
}