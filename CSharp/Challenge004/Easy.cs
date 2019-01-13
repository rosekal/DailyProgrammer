using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge004{
    class Easy{
        public static void Run() {
            char[] alphaNumbericSymbols = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm!@#$%^&*()-_!@#$%^&*()-_!@#$%^&*()".ToCharArray();
            Random r = new Random();

            int amountOfPasswords = 0, amountOfChars = 0;
            while (true) {
                try {
                    Console.Write("\nHow many passwords? ");
                    amountOfPasswords = Int32.Parse(Console.ReadLine());

                    if(amountOfPasswords > 1)
                        break;
                } catch { }
            }

            while (true) {
                try {
                    Console.Write("\nHow many characters? ");
                    amountOfChars = Int32.Parse(Console.ReadLine());

                    if (amountOfChars > 5) {
                        break;
                    } else {
                        Console.WriteLine("\nMust be more than 5 characters.");
                    }
                } catch { }
            }

            for(int i = 0; i < amountOfPasswords; i++) {
                string password = "";

                for (int j = 0; j < amountOfChars; j++)
                    password += alphaNumbericSymbols[r.Next(0, alphaNumbericSymbols.Length)];

                Console.WriteLine($"A password: {password}");
            }
        }
    }
}
