using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge004{
    class Hard{
        public static void Run() {
            //Getting input
            Console.Write("Enter your numbers (spaces in-between): ");
            string[] nums = Console.ReadLine().Split(' ');

            //Converting input to doubles
            double[] numbers = new double[nums.Length];
            for(int i = 0; i < numbers.Length; i++) {
                try {
                    numbers[i] = Double.Parse(nums[i]);
                } catch(FormatException) {
                    Console.WriteLine("Bad numbers, try again.");
                }
            }

            
            string ops = "+-*/";

            //Looping through each number
            foreach(double num1 in numbers) {
                //Looping through each number again
                foreach (double num2 in numbers) {
                    //If subloop's number is the same as loop's number, ignore
                    if (Array.IndexOf(numbers, num1) == Array.IndexOf(numbers, num2)) {
                        continue;
                    }

                    //Print out each operation to the console
                    foreach (char op in ops) {
                        Console.WriteLine($"{num1} {op} {num2} = {Calc(num1, num2, op)}");
                    }
                }
            }
        }

        static double Calc(double num1, double num2, char op) {
            //Switching operators for + - / *
            switch (op) {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
            }

            return 0.0;
        }
    }
}
