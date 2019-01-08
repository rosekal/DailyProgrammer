using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge002{
    class Easy{
        public static void Run() {
            Console.WriteLine("\nStandard Deviation Calculator\n");
            Console.WriteLine("Enter all the numbers, with spaces between each one: ");
            string[] numbersStr = Console.ReadLine().Split(' ');

            double[] numbers = new double[numbersStr.Length];

            int numOfNumbers = numbers.Length;

            double avg = 0;
            double sum = 0;

            foreach(string num in numbersStr) {
                int currIndex = Array.IndexOf(numbersStr, num);

                try {
                    numbers[currIndex] = Double.Parse(num);
                } catch (Exception) {
                    Console.WriteLine("Bad numbers, please try again");
                    return;
                }

                sum += numbers[currIndex];
            }

            avg = sum / numOfNumbers;


            double summation = 0;

            foreach (int currNum in numbers) {
                summation += Math.Pow((currNum - avg), 2);
            }

            double std = Math.Sqrt(summation / numOfNumbers);

            Console.WriteLine($"The standard deviation is {std}");

        }
    }
}
