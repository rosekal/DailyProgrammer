using System;
using System.IO;

namespace Challenge005 {
    public class Easy {
        public static void Run() {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            Console.WriteLine(VerifyCredentials(username, password) ? "You have access" : "Access denied");
        }

        private static bool VerifyCredentials(string username, string password) {
            string fileName = "C:\\Users\\Kalen\\credentials.txt";

            foreach (string line in File.ReadAllLines(fileName)) {
                string[] info = line.Split('\t');

                if(info[0].Equals(username) && info[1].Equals(password)) {
                    return true;
                }
            }

            return false;
        }
    }
}