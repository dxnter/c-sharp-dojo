using System;

namespace fundamentals_1 {
    class Program {
        static void Main (string[] args) {
            // Obj #1
            for (int i = 1; i <= 255; i++) {
                Console.WriteLine (i);
            }

            // Obj #2
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine ("FizBuzz");
                } else if (i % 5 == 0) {
                    Console.WriteLine ("Buzz");
                } else if (i % 3 == 0) {
                    Console.WriteLine ("Fizz");
                } else {
                    Console.WriteLine (i);
                }
            }
        }
    }
}