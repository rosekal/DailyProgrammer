using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge004{
    class Easy{
        public static void Run() {
            char[] alphaNumbericSymbols = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm!@#$%^&*()-_!@#$%^&*()-_!@#$%^&*()".ToCharArray();
            Random r = new Random();
            string password = "";

            for(int i = 0; i < 15; i++) 
                password += alphaNumbericSymbols[r.Next(0, alphaNumbericSymbols.Length)];

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
