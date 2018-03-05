using System;
using System.Collections.Generic;

namespace boxing_unboxing {
    class Program {
        static void Main(string[] args) {
            List<object> values = new List<object>();
            values.Add(7);
            values.Add(28);
            values.Add(-1);
            values.Add(true);
            values.Add("chair");
            // Loop through and display their values
            foreach (var value in values) {
                Console.WriteLine(value);
            }
            // Add up all the ints and display the sum
            int sum = 0;
            foreach (var value in values) {
                if (value is int) {
                    sum += (int)value;
                }
            }
            Console.WriteLine(sum);
        }
    }
}