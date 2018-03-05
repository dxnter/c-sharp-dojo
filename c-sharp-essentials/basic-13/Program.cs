using System;
using System.Collections.Generic;

namespace basic_13 {
    class Program {
        public static void oneTo255() {
            for (int i = 1; i <= 255; i++) {
                Console.WriteLine(i);
            }
        }

        public static void oddOneTo255() {
            for (int i = 0; i <= 255; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }

        public static void sum() {
            int sum = 0;
            for (int i = 0; i <= 255; i++) {
                sum += i;
                Console.WriteLine("New Number: {0} Sum {1}", i, sum);
            }
        }

        public static void iterateArray() {
            int[] numbers = { 1, 3, 5, 7, 9, 15 };
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
        }

        public static void findMax(int[] list) {
            int max = list[0];
            for (int i = 0; i < list.Length; i++) {
                if (list[i] > max) {
                    max = list[i];
                }
            }
            Console.WriteLine(max);
        }

        public static void findAverage(int[] list) {
            int sum = 0;
            for (int i = 0; i < list.Length; i++) {
                sum += list[i];
            }
            int avg = sum / list.Length;
            Console.WriteLine("Average {0}", avg);
        }

        public static void arrayWithOdds() {
            List<int> array = new List<int>();
            for (int i = 1; i <= 255; i++) {
                if (i % 2 != 0) {
                    array.Add(i);
                }
            }
            array.ForEach(number => Console.WriteLine(number));
        }

        public static void greaterThanY(int[] array, int target) {
            int greaterThan = 0;
            foreach (int number in array) {
                if (number > target) {
                    greaterThan++;
                }
            }
            Console.WriteLine($"{greaterThan} numbers greater than {target}");
        }

        public static void squareTheValues(int[] numbers) {
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] *= numbers[i];
                Console.WriteLine(numbers[i]);
            }
        }

        public static void eliminateNegatives(int[] numbers) {
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] < 0) {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
        }

        public static void minMaxAvg(int[] numbers) {
            int sum = 0;
            int max = 0;
            int min = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
                if (numbers[i] > max) {
                    max = numbers[i];
                } else if (numbers[i] < min) {
                    min = numbers[i];
                }
            }
            int avg = sum / numbers.Length;
            Console.WriteLine("Min: {0}, Max: {1}, Avg: {2}", min, max, avg);
        }

        public static void shift(int[] numbers) {
            for (int i = 0; i < numbers.Length - 1; i++) {
                int temp = numbers[i];
                numbers[i] = numbers[i + 1];
                numbers[i + 1] = temp;
            }
            numbers[numbers.Length - 1] = 0;
            foreach (int value in numbers) {
                Console.WriteLine(value);
            }
        }
        public static List<object> numberToString(int[] numbers) {
            List<object> newArray = new List<object>();
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] < 0) {
                    newArray.Add("Dojo");
                } else {
                    newArray.Add(numbers[i]);
                }
            }
            return newArray;
        }
        static void Main(string[] args) { }
    }
}