using System;
using System.IO;

namespace Challenge005 {
    public class Easy {
        public static void Run() {
            //Getting username
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            //Getting password
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            //Printing out authentication results
            Console.WriteLine(VerifyCredentials(username, password) ? "You have access" : "Access denied");
        }

        private static bool VerifyCredentials(string username, string password) {
            string fileName = "C:\\Users\\Kalen\\credentials.txt";

            //Going through each line, comparing username and passwords to the text file
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