using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge003{
    class Easy{
        static char[] alphabetArr = null, cipherArr = null;
        public static void Run() {
            alphabetArr = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            cipherArr = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();

            while (true) {
                Console.Write("\nPlease input information (! to exit): ");
                string input = Console.ReadLine().ToLower();

                if (input.Equals("!")) {
                    return;
                }

                Console.Write("\nDo you want to (e)ncrypt or (d)ecrypt? ");

                switch (Console.ReadLine().ToLower()) {
                    case "e":
                        Console.WriteLine($"\nThe encrypted message is: {Encrypt(input)}");
                        break;
                    case "d":
                        Console.WriteLine($"\nThe decrypted message is: {Decrypt(input)}");
                        break;
                    default:
                        Console.WriteLine("\nBad input.  Needs to be either an 'e' or a 'd'");
                        break;
                }
            }

        }

        public static string Encrypt(string message) {
            string encryptedMessage = "";
            foreach(char curr in message.ToCharArray()) {
                try {
                    encryptedMessage += cipherArr[Array.IndexOf(alphabetArr, curr)];
                } catch (IndexOutOfRangeException) {
                    encryptedMessage += curr;
                }
            }

            return encryptedMessage;
        }

        public static string Decrypt(string message) {
            string decryptedMessage = "";

            foreach (char curr in message.ToCharArray()) {
                try {
                    decryptedMessage += alphabetArr[Array.IndexOf(cipherArr, curr)];
                } catch (IndexOutOfRangeException) {
                    decryptedMessage += curr;
                }
            }

            return decryptedMessage;
        }
    }
}
