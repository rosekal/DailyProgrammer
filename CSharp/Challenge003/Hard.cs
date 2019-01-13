using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge003{
    class Hard{
        static string[] wordBank = null;
        static string[] words = null;
        public static void Run() {
            wordBank = System.IO.File.ReadAllLines(@"C:\wordlist.txt");

            words = new string[] { "mkeart", "sleewa", "edcudls", "iragoge", "usrlsle", "nalraoci",
                                   "nsdeuto", "amrhat", "inknsy", "iferkna" };

            foreach(string scrambledWord in words) {
                foreach(string word in wordBank) {
                    if(word.Length == scrambledWord.Length) {
                        char[] scrambledWordArr = scrambledWord.ToCharArray();
                        Array.Sort(scrambledWordArr);

                        char[] wordArr = word.ToCharArray();
                        Array.Sort(wordArr);

                        bool match = true;
                        foreach(char curr in wordArr) {
                            if (curr != scrambledWordArr[Array.IndexOf(wordArr, curr)]) {
                                match = false;
                            }
                        }

                        if (match) {
                            Console.WriteLine($"{scrambledWord} unscrambled is: {word}");
                        }
                    }
                }
            }
        }
    }
}
